using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            FechaPick.SelectionStart = Program.hoy();
            FechaPick.SelectionEnd = Program.hoy();
            TipoDoc.SelectedIndex = 0;
            ComboNac.SelectedIndex = 0;
            ComboPais.SelectedIndex = 0;
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            bd.obtenerConexion();
            validarNroDoc();

            //  string valores = "'" + TxtNombre.Text + "','" + TxtApellido + "','" + TipoDoc.Text + "','" + TxtNroDoc.Text + "','" + FechaPick.Text + TxtMail.Text + "','" +TxtTelefono.Text+"','"+TxtCalle.Text+"','"+ textBox1.Text+"','"
            //bd.insertar("Clientes", valores);

        }

        private void limpiar(TextBox txt)
        {
            txt.Text = "";
        }

        private void CargarTipoDocNacPaises()
        {
            BD bd = new BD();
            bd.obtenerConexion();
            bd.rellenarDesde("Descripcion", "TiposDoc", TipoDoc);
            bd.rellenarDesde("Nombre", "Paises", ComboNac);
            bd.rellenarDesde("Nombre", "Paises", ComboPais);
        }

        private void validarNroDoc()
        {
            if (TxtNroDoc.Text != "")
            {
                BD bd = new BD();
                SqlConnection conexion = bd.obtenerConexion();
                string comando = "SELECT Nro_Doc FROM FUGAZZETA.Clientes WHERE Nro_Doc='" + TxtNroDoc.Text + "'";
                DataTableReader tabla = new DataTableReader(bd.ejecutar(comando));
                if (tabla.HasRows)
                {
                    MessageBox.Show("El usuario ya esta registrado");
                }
                else{
                    MessageBox.Show("Se debe ingresar un numero de documento");
                }


            }





        }
    }
}
