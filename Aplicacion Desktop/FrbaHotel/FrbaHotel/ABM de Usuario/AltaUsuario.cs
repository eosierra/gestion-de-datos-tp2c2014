using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ABM_de_Rol;
using FrbaHotel.ABM_de_Hotel;
using System.Data.SqlClient;

using System.Security.Cryptography;
using FrbaHotel.ABM_de_Cliente;
using FrbaHotel.Login;



namespace FrbaHotel.ABM_de_Usuario
{


    public partial class AltaUsuario : Buscador,ITraeBusqueda
    {
        Char busca;

        public AltaUsuario(char func, string un)
        {
            InitializeComponent();
            cargarTiposDoc();
            cargar(un);
            TxtUser.Enabled = false;
            TxtPass1.Enabled = false;
            TxtPass2.Enabled = false;
            Limpiar.Visible = false;
            CambiarPass.Visible = true;
            funcion = func;
        }

        public AltaUsuario()
        {
            InitializeComponent();
            cargarTiposDoc();
            Habilitado.Visible = false;
            CambiarPass.Visible = false;
           
        }
        #region Botones
       

        private void cargarTiposDoc()
        {
            BD bd = new BD();
            string query = "SELECT * FROM FUGAZZETA.TiposDoc";
            SqlDataReader dr = bd.lee(query);
            while (dr.Read())
            {
                CbTipoDoc.Items.Add(new ABM_de_Cliente.TipoDoc(dr[0].ToString(), dr[1].ToString()));
            }
            bd.cerrar();
        }

        
        private void LimpiarTodo_Click(object sender, EventArgs e)
        {
            TxtUser.Text = "";
            TxtPass1.Text = "";
            TxtPass2.Text = "";
            NroDoc.Text = "";
            Nombre.Text = "";
            Direc.Text = "";
            Telefono.Text = "";
            TxtMail.Text = "";
            CbTipoDoc.Items.Clear();
            Apellido.Text = "";
            NroDirec.Text = "";
            Calendario.Value = Program.hoy();
            ListHoteles.Items.Clear();

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (funcion=='M')
            {
                DialogResult modif = MessageBox.Show("Son todos los datos correctos?", "Confirmar actualización de usuario", MessageBoxButtons.YesNo);
                if (modif == DialogResult.Yes) actualizarUsuario();
            }
            else
            try
            {
                agregarUsuario();
                MessageBox.Show("Usuario agregado con exito.", this.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        #endregion

        private void actualizarUsuario()
        {
            BD bd = new BD();
            bd.obtenerConexion();
            string comando =
                @"UPDATE FUGAZZETA.Usuarios
                SET Nombre = '" + Nombre.Text + "', Apellido = '" + Apellido.Text +
                "', Id_TipoDoc = " + (CbTipoDoc.SelectedItem as TipoDoc).id + ", Nro_Doc = " + NroDoc.Text +
                ", Mail = '" + TxtMail.Text +
                "', Telefono = " + Telefono.Text +
                ", Calle = '" + Direc.Text +
                "', NroCalle = " + NroDirec.Text + ", Fecha_Nac = '" + Calendario.Value.ToShortDateString() +
                "', Habilitado = " + Convert.ToSByte(Habilitado.Checked)+ 
                " WHERE Username = '" + TxtUser.Text + "'";
            bd.ejecutar(comando);

            bd.eliminar("[Usuarios x Hoteles x Rol]", "Username='" + TxtUser.Text +"'");
            agregarHotelesxRol(bd);

            MessageBox.Show("Actualización realizada con éxito.", this.Text,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            Calendario.MaxDate = Program.hoy();
        }

        private void validarDatosIngresados()
        {
            if (TxtPass1.Text == "" || TxtPass1.Text != TxtPass2.Text)
                throw new Exception("La contraseña no es válida.");
            if (CbTipoDoc.SelectedIndex == -1)
                throw new Exception("No eligió un tipo de documento.");
            verVacio(TxtUser, "El usuario");
            verVacio(Nombre,"El nombre");
            verVacio(Apellido,"El apellido");
            verVacio(Direc,"La calle");
            verVacio(NroDirec,"La altura");
            verVacio(TxtMail, "El mail");
            verVacio(NroDoc, "El número de documento");
            verVacio(Telefono, "El teléfono");           
        }

        private void verVacio(TextBox txt, string a)
        {
            if (txt.Text == "") throw new Exception(a + " no puede ser vacío.");
        }

        private void agregarUsuario()
        {

            BD bd = new BD();
            bd.obtenerConexion();
            ABM_de_Cliente.TipoDoc tipoDni = CbTipoDoc.Items[CbTipoDoc.SelectedIndex] as ABM_de_Cliente.TipoDoc;
            string valores = "'" + TxtUser.Text + "','" + Hashing.SHA256Encrypt(TxtPass1.Text) + "',' " + Nombre.Text + "',' " + Apellido.Text + "',' " + tipoDni.id + "', '" + NroDoc.Text + "',' " + TxtMail.Text + "', '" + Telefono.Text + "',' " + Direc.Text + "',' " + NroDirec.Text + "',' " + Calendario.Value.ToShortDateString() + "','" + 0 + "','" + 1 + "'"; 
            bd.insertar("Usuarios", valores);

            agregarHotelesxRol(bd);
            bd.cerrar();
        }

        private void agregarHotelesxRol(BD bd)
        {
            for (int i = 0; i < ListHoteles.Items.Count; i++)
            {
                Hotel h = ListHoteles.Items[i] as Hotel;
                string v = "'" + TxtUser.Text + "', " + h.id + ", " + TxtRol.Tag.ToString() + ", 0";
                bd.insertar("[Usuarios x Hoteles x Rol]", v);
            }
        }

        public void cargar(string username)
        {
            ListHoteles.Items.Clear();
            BD bd = new BD();
            bd.obtenerConexion();
            string query = "SELECT * FROM FUGAZZETA.Usuarios WHERE Username = '" + username + "'";
            SqlDataReader dr = bd.lee(query);
            
            while (dr.Read())
            {
                TxtUser.Text = dr["Username"].ToString();
                TxtPass1.Text = dr["Contraseña"].ToString();
                TxtPass2.Text = dr["Contraseña"].ToString();
                Nombre.Text = dr["Nombre"].ToString();
                Apellido.Text = dr["Apellido"].ToString();
                NroDoc.Text = dr["Nro_Doc"].ToString();
                TxtMail.Text = dr["Mail"].ToString();
                Telefono.Text = dr["Telefono"].ToString();
                Direc.Text = dr["Calle"].ToString();
                NroDirec.Text = dr["NroCalle"].ToString();
                Habilitado.Checked = Convert.ToBoolean(dr["Habilitado"].ToString());

                string elItem = "";
                for (int i = 0; i < CbTipoDoc.Items.Count; i++)
                {

                    if ((CbTipoDoc.Items[i] as ABM_de_Cliente.TipoDoc).id.ToString() == dr["Id_TipoDoc"].ToString())
                    {
                        elItem = CbTipoDoc.Items[i].ToString();
                    }
                }
                CbTipoDoc.Text = elItem;
                
            }
            dr.Close();
            
            query = @"SELECT TOP 1 HXR.Id_Rol, R.Nombre FROM FUGAZZETA.[Usuarios x Hoteles x Rol] HXR,
                    FUGAZZETA.Roles R WHERE HXR.Id_Rol = R.Id_Rol AND Username = '" + TxtUser.Text + "'";
            dr = bd.lee(query);
            while (dr.Read())
            {
                TxtRol.Text = dr[1].ToString();
                TxtRol.Tag = dr[0].ToString();
            }
            dr.Close();
            query = @"SELECT HXR.Id_Hotel, H.Nombre FROM FUGAZZETA.[Usuarios x Hoteles x Rol] HXR,
            FUGAZZETA.Hoteles H WHERE HXR.Id_Hotel = H.Id_Hotel  AND Username = '" + TxtUser.Text + "'";
            dr = bd.lee(query);
            while (dr.Read())
            {
                Hotel h = new Hotel(dr[0].ToString(), dr[1].ToString());
                ListHoteles.Items.Add(h);
            }
            dr.Close();
            bd.cerrar();

        }

        


        #region Botones



        private void LinkValida_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            validarUser();
        }

        private void LimpiarPantalla_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Está seguro de borrar todos los datos?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirma == DialogResult.OK) LimpiarTodo_Click(sender, e);
        }
        
        

        #endregion

        private void validarContraseñas(object sender, EventArgs e)
        {
            if (TxtPass1.Text != TxtPass2.Text) LblError1.Text = "Las contraseñas no coinciden.";
            else LblError1.Text = "";
        }

        private void validarUser()
        {
            if (TxtUser.Text != "")
            {
                BD bd = new BD();
                SqlConnection conexion = bd.obtenerConexion();
                string comando = "SELECT Username,Contraseña FROM FUGAZZETA.Usuarios WHERE Username='" + TxtUser.Text + "'";
                DataTableReader tabla = new DataTableReader(bd.ejecutar(comando));
                if (!tabla.HasRows) MessageBox.Show("El nombre de usuario está disponible.");
                else LblError1.Text = "El usuario ya existe.";
            }
            else
            {
                LblError1.Text = "El usuario debe tener al menos un caracter";
            }
        }



        void ITraeBusqueda.agregar(string id, string descripcion)
        {
            switch (busca)
            {
                case 'H':
                    Hotel agregable = new Hotel(id, descripcion);
                    bool sePuede = true;
                    bool sigue = true;
                    for (int i = 0; (i < ListHoteles.Items.Count) && sigue; i++)
                    {
                        if (ListHoteles.Items[i].ToString() == agregable.ToString())
                        {
                            sigue = false;
                            sePuede = false;
                        }
                    }
                    if (sePuede) ListHoteles.Items.Add(agregable);
                    else MessageBox.Show("No se puede agregar. Ya está el hotel en la lista.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 'R':
                    TxtRol.Text = descripcion;
                    TxtRol.Tag = id;
                    break;
            }
        }


        private void CmdAddHotel_Click(object sender, EventArgs e)
        {
            busca = 'H';
            new BuscarHotel(this).ShowDialog();
        }

        private void CambiarPass_Click(object sender, EventArgs e)
        {
            new NuevoPass(TxtUser.Text).ShowDialog();
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void RolClick_Click(object sender, EventArgs e)
        {
            busca = 'R';
            new BuscarRol(this, 'S').ShowDialog();
                
        }
            

        
    }
}
