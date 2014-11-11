using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaHotel.ABM_de_Hotel;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class AltaCliente : Buscador
    {
        public AltaCliente(char fun,string id)
        {
            InitializeComponent();
            CargarTipoDocNacPaises();
            cargar(id);
            funcion = 'M';
        }
        public AltaCliente()
        {
            InitializeComponent();
            CargarTipoDocNacPaises();
        }

        private void CmdLimpiar_Click(object sender, EventArgs e)
        {
            limpiar(TxtApellido);
            limpiar(TxtCalle);
            limpiar(TxtLocalidad);
            limpiar(TxtMail);
            limpiar(TxtNombre);
            limpiar(TxtNroDoc);
            limpiar(TxtTelefono);
            limpiar(TxtNroDirec);
            limpiar(TxtPiso);
            limpiar(TxtDpto);
            FechaPick.Value = Program.hoy();
            TipoDoc.SelectedIndex = -1;
            ComboNac.SelectedIndex = -1;
            ComboPais.SelectedIndex = -1;
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            if (funcion=='M'){
                    BD bd = new BD();
                    bd.obtenerConexion();
                    try
                        {
                        validarDocumento(bd);
                        validarDocumento(bd);
                        bd.cerrar();
                        DialogResult modif = MessageBox.Show("Son todos los datos correctos?", "Confirmar actualización de cliente", MessageBoxButtons.YesNo);
                        if (modif == DialogResult.Yes)
                            {
                                actualizarCliente();
                            }
                    }

                    catch (Exception ex)
                    {
                        bd.cerrar();
                        MessageBox.Show("Error: No se pudo actualizar al cliente. " + ex.Message);
                    }

                
            }
            else{
            DialogResult confirma = MessageBox.Show("Son todos los datos correctos?", this.Text, MessageBoxButtons.YesNo);

            if (confirma == DialogResult.Yes)
            {
                BD bd = new BD();
                bd.obtenerConexion();
                try
                {                    
                    ValidarTxt(TxtNombre, "Nombre");
                    ValidarTxt(TxtApellido, "Apellido");
                    ValidarTxt(TxtNroDoc, "Número de Documento");
                    ValidarTxt(TxtTelefono, "Teléfono");
                    ValidarTxt(TxtCalle, "Calle");
                    ValidarTxt(TxtNroDirec, "Número Calle");
                    validarDocumento(bd);
                    validarMail(bd);
                    string tipoDoc = setTipoDoc(TipoDoc);
                    string idNac = setPais(ComboNac);
                    string idPais = setPais(ComboPais);
                    string query = "INSERT INTO FUGAZZETA.Clientes values (" + ifNull(TxtNombre) + ", " + ifNull(TxtApellido) + @", 
                " + tipoDoc + ", " + ifNull(TxtNroDoc) + ", '" + FechaPick.Value.ToShortDateString() + "', " + ifNull(TxtMail) + @",
                " + ifNull(TxtTelefono) + ", " + ifNull(TxtCalle) + ", " + ifNull(TxtNroDirec) + ", " + ifNull(TxtPiso) + @",
                " + ifNull(TxtDpto) + ", " + ifNull(TxtLocalidad) + ", " + idPais + ", " + idNac + ", 1)";
                    bd.ejecutar(query);
                    bd.cerrar();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    bd.cerrar();
                    MessageBox.Show("Error: No se pudo ingresar el cliente. " + ex.Message);
                }
            }
        }
        }

        

        private void actualizarCliente()
        {
            BD bd = new BD();
            bd.obtenerConexion();
            Pais elPais = ComboNac.Items[ComboNac.SelectedIndex] as Pais;
            TipoDoc elTipoDoc = TipoDoc.Items[TipoDoc.SelectedIndex] as TipoDoc;
            string comando =
                "UPDATE FUGAZZETA.Clientes SET Nombre = '" + TxtNombre.Text +
                "', Apellido = '" + TxtApellido.Text +
                "', Nro_Doc = '" + TxtNroDoc.Text +
                "', Fecha_Nac = '" + FechaPick.Value.ToShortDateString() +
                "', Mail = '" + TxtMail.Text +
                "', Telefono = '" + TxtTelefono.Text +
                "', Dom_Calle = '" + TxtCalle.Text +
                "', Nro_Calle = '" + TxtNroDirec.Text +
                "', Piso = '" + TxtPiso.Text +
                "', Depto = '" + TxtDpto.Text +
                "', Localidad = '" + TxtLocalidad.Text +
                "', Nacionalidad = '" + elPais.id +
                "', Id_TipoDoc = '" + elTipoDoc.id +
                "' WHERE Id_Cliente = '" + Id.Text + "'";
            bd.ejecutar(comando);
            
            MessageBox.Show("Actualización realizada con éxito");
            bd.cerrar();
        }

        private void limpiar(TextBox txt)
        {
            txt.Text = "";
        }

        private void cargar(string id)
        {
            BD bd = new BD();
            bd.obtenerConexion();
            int elId = Convert.ToInt32(id);
            string query = "SELECT * FROM FUGAZZETA.Clientes WHERE Id_Cliente = " + elId;
            SqlDataReader dr = bd.lee(query);

            while (dr.Read())
            {
                Id.Text = dr["Id_Cliente"].ToString();
                TxtNombre.Text = dr["Nombre"].ToString();
                TxtApellido.Text = dr["Apellido"].ToString();
                TxtNroDoc.Text = dr["Nro_Doc"].ToString();
                TxtMail.Text = dr["Mail"].ToString();
                TxtTelefono.Text = dr["Telefono"].ToString();
                TxtCalle.Text = dr["Dom_Calle"].ToString();
                TxtNroDirec.Text = dr["Nro_Calle"].ToString();
                TxtPiso.Text = dr["Piso"].ToString();
                TxtDpto.Text = dr["Depto"].ToString();
                TxtLocalidad.Text = dr["Localidad"].ToString();

                string fecha = dr["Fecha_Nac"].ToString();
                FechaPick.Value = convertirFecha(fecha);
                               
                string elItem = "";
                for (int i = 0; i < ComboNac.Items.Count; i++)
                {

                    if ((ComboNac.Items[i] as Pais).id.ToString() == dr["Nacionalidad"].ToString())
                    {
                        elItem = ComboNac.Items[i].ToString();
                    }
                }
                ComboNac.Text = elItem;

                elItem = "";
                for (int i = 0; i < TipoDoc.Items.Count; i++)
                {

                    if ((TipoDoc.Items[i] as TipoDoc).id.ToString() == dr["Id_TipoDoc"].ToString())
                    {
                        elItem = TipoDoc.Items[i].ToString();
                    }
                }
                TipoDoc.Text = elItem;
            }
            dr.Close();

            

            /* query = "SELECT FR.Id_Rol,FR.Id_Funcionalidad, F.Descripcion FROM FUGAZZETA.[Funcionalidades x Roles] FR, FUGAZZETA.Funcionalidades F where FR.Id_Funcionalidad = F.Id_Funcionalidad AND FR.Id_Rol = " + elId;
             dr = bd.lee(query);
             while (dr.Read())
             {
                 ListFunciones.Items.Add(new Funcionalidad(dr[1].ToString(), dr[2].ToString()));
             }*/
            bd.cerrar();
        }

        private DateTime convertirFecha(string fecha)
        {
            return Convert.ToDateTime(fecha);
        }

        private string ifNull(TextBox txt)
        {
            if (txt.Text == "") return "NULL";
            else return "'" + txt.Text + "'";
        }

        private string setPais(ComboBox cb)
        {
            if (cb.SelectedIndex == -1) return "NULL";
            else return (cb.SelectedItem as Pais).id.ToString();
        }

        private string setTipoDoc(ComboBox cb)
        {
            if (cb.SelectedIndex == -1) return "NULL";
            else return (cb.SelectedItem as TipoDoc).id.ToString();
        }

        private void CargarTipoDocNacPaises()
        {
            BD bd = new BD();
            bd.obtenerConexion();
            string query = "SELECT * FROM FUGAZZETA.Paises ORDER BY Nombre";
            SqlDataReader dr = bd.lee(query);
            while (dr.Read())
            {
                Pais pais = new Pais(dr[0].ToString(), dr[1].ToString());
                ComboPais.Items.Add(pais);
                ComboNac.Items.Add(pais);
            }
            dr.Close();
            query = "SELECT * FROM FUGAZZETA.TiposDoc";
            dr = bd.lee(query);
            while (dr.Read()) TipoDoc.Items.Add(new TipoDoc(dr[0].ToString(), dr[1].ToString()));
            bd.cerrar();
        }

        private void validarDocumento(BD bd)
        {
            string comando = "SELECT Id_TipoDoc, Nro_Doc FROM FUGAZZETA.Clientes WHERE Nro_Doc = " + TxtNroDoc.Text + " AND Id_TipoDoc ";
            if (TipoDoc.SelectedIndex == -1) comando += "IS NULL";
            else comando += "= " + (TipoDoc.SelectedItem as TipoDoc).id.ToString();
            SqlDataReader tabla = bd.lee(comando);
            if (tabla.HasRows)
                {
                    tabla.Close();
                    throw new Exception("Ya está registrado ese documento en el sistema.");
                }
            tabla.Close();
        }

        private void validarMail(BD bd)
        {
            string comando = "SELECT Mail FROM FUGAZZETA.Clientes WHERE Mail='" + TxtMail.Text + "'";
            SqlDataReader tabla = bd.lee(comando);
            if (tabla.HasRows)
            {
                tabla.Close();
                throw new Exception("Ya existe un usuario registrado con ese mail.");
            }
            tabla.Close();
        }

        private void ValidarTxt(TextBox txt, string campo)
        {
            if (txt.Text == "") throw new Exception("No completó el campo: " + campo + ".");
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            FechaPick.MaxDate = Program.hoy();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        } 
    }
}
