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

namespace FrbaHotel.ABM_de_Usuario
{


    public partial class AltaUsuario : Form, ITraeBusqueda
    {

        public AltaUsuario(char func, string un)
        {
            InitializeComponent();
            cargar(un);
        }

        public AltaUsuario()
        {
            InitializeComponent();
           
        }
        #region Botones
        private void CmdQuitar_Click(object sender, EventArgs e)
        {
            ListaRoles.Items.Remove(ListaRoles.SelectedItem);
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
            comboBox2.Items.Clear();
            ListaRoles.Items.Clear();
            Apellido.Text = "";
            NroDirec.Text = "";
            Calendario.Dispose(); //no estoy segura si esta es la funcion que borra pero es lo mas parecido
            ListHoteles.Items.Clear();

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                agregarUsuario();
                MessageBox.Show("Usuario agregado con exito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        
        private void validarDatosIngresados()
        {
            if (Nombre.Text == "")
            {
                throw new Exception("El nombre no puede ser vacío");
            }
            if (Apellido.Text == "")
            {
                throw new Exception("El apellido no puede ser vacio");
            }
            //faltan mas validaciones de los datos del usuario
        }

        private void agregarUsuario()
        {

            BD bd = new BD();
            bd.obtenerConexion();
            TipoDoc tipoDni = comboBox2.Items[comboBox2.SelectedIndex] as TipoDoc;
            string valores = "'" + TxtUser.Text + "',' " + TxtPass1.Text + "',' " + Nombre.Text + "',' " + Apellido.Text + "',' " + tipoDni.id + "', '" + NroDoc.Text + "',' " + TxtMail.Text + "', '" + Telefono.Text + "',' " + Direc.Text + "',' " + NroDirec.Text + "',' " + Calendario.Value.ToShortDateString() +"','"+1 +"','"+0+ "'"; 
            bd.insertar("Usuarios", valores);



        }

        public void cargar(string username)
        {
            ListaRoles.Items.Clear();
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
            }
            dr.Close();


            bd.cerrar();

        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            Calendario.MaxDate = Program.hoy();
           
            BD bd = new BD();
            string query = "SELECT * FROM FUGAZZETA.TiposDoc";
            SqlDataReader dr = bd.lee(query);
            while (dr.Read())
            {
                comboBox2.Items.Add(new TipoDoc(dr[0].ToString(), dr[1].ToString()));
            }

        }


        #region Botones
        private void AgregarRol_Click_1(object sender, EventArgs e)
        {
            new BuscarRol(this,'S').ShowDialog();
        }

        private void QuitarRol_Click(object sender, EventArgs e)
        {
            ListaRoles.Items.Remove(ListaRoles.SelectedItem);
        }

        private void LinkValida_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            validarUser();
        }

        private void LimpiarPantalla_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Está seguro de borrar todos los datos?", "Nuevo Usuario", MessageBoxButtons.OKCancel);
            if (confirma == DialogResult.OK)
            {
                TxtUser.Text = "";
                TxtPass1.Text = "";
                TxtPass2.Text = "";
                ListaRoles.Items.Clear();
                LblError1.Text = "";



            }
        }
        
        

        #endregion

        private void validarContraseñas(object sender, EventArgs e)
        {
            if (TxtPass1.Text != TxtPass2.Text)
            {
                LblError1.Text = "Las contraseñas no coinciden";
            }
            else
            {
                LblError1.Text = "";
            }
        }

        private void validarUser()
        {
            if (TxtUser.Text != "")
            {
                BD bd = new BD();
                SqlConnection conexion = bd.obtenerConexion();
                string comando = "SELECT Username,Contraseña FROM FUGAZZETA.Usuarios WHERE Username='" + TxtUser.Text + "'";
                DataTableReader tabla = new DataTableReader(bd.ejecutar(comando));
                if (!tabla.HasRows)
                {
                    MessageBox.Show("El nombre de usuario está disponible");
                }
                else { LblError1.Text = "El usuario ya existe"; }
            }
            else
            {
                LblError1.Text = "El usuario debe tener al menos un caracter";
            }
        }



        void ITraeBusqueda.agregar(string id, string descripcion)
        {
            bool sePuede = true;
            bool sigue = true;
            for (int i = 0; (i < ListaRoles.Items.Count - 1) && sigue; i++)
            {
                if (ListaRoles.Items[i].ToString() == descripcion)
                {
                    sigue = false;
                    sePuede = false;
                }
            }
            if (!sePuede)
            {
                MessageBox.Show("No se puede agregar");
            }
            else
            {
                ListaRoles.Items.Add(new Rol(id, descripcion));
            }
        }


        private void CmdAddHotel_Click(object sender, EventArgs e)
        {
            new BuscarHotel(this).ShowDialog();
        }


        
    }
}
