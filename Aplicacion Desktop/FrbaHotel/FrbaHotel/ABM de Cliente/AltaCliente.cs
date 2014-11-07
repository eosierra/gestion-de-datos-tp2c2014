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
    public partial class AltaCliente : Form
    {
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
            BD bd = new BD();
            bd.obtenerConexion();
            try
            {
                validarDocumento(bd);
                validarMail(bd);
                int tipoDoc = (TipoDoc.SelectedItem as TipoDoc).id;
                int idNac = (ComboNac.SelectedItem as Pais).id;
                int idPais = (ComboPais.SelectedItem as Pais).id;
                string query = "INSERT INTO FUGAZZETA.Clientes values (" + ifNull(TxtNombre) + ", " + ifNull(TxtApellido) + @", 
                " + tipoDoc + ", " + ifNull(TxtNroDoc) + ", '" + FechaPick.Value.ToShortDateString() + "', " + ifNull(TxtMail) + @",
                " + ifNull(TxtTelefono) + ", " + ifNull(TxtCalle) + ", " + ifNull(TxtNroDirec) + ", " + ifNull(TxtPiso) + @",
                " + ifNull(TxtDpto) + ", " + ifNull(TxtLocalidad) + ", " + idNac + ", 1)";
                MessageBox.Show(query);
            }
            catch (Exception ex)
            {
                bd.cerrar();
                MessageBox.Show("Error: No se pudo ingresar el cliente. " + ex.Message);
            }
        }

        private void limpiar(TextBox txt)
        {
            txt.Text = "";
        }

        private string ifNull(TextBox txt)
        {
            if (txt.Text == "") return "NULL";
            else return "'" + txt.Text + "'";
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

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        } 
    }
}
