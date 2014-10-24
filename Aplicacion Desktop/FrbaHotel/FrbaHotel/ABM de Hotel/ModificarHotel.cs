using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class ModificarHotel : Form, ITraeBusqueda
    {
        //Hotel hotelin;

        public ModificarHotel()
        {
            InitializeComponent();
        }

        private void ModificarHotel_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            FechaPick.MaxDate = Program.hoy();
            
            BD bd = new BD();
            string query = "SELECT * FROM FUGAZZETA.Paises ORDER BY Nombre";
            SqlDataReader dr = bd.lee(query);
            while (dr.Read())
            {
                ComboPais.Items.Add(new Pais(dr[0].ToString(), dr[1].ToString()));
            }
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            new ABM_de_Hotel.BuscarHotel(this).ShowDialog();
            groupBox1.Enabled = true;
        }

        public void agregar(string id, string descripcion)
        {
            BD bd = new BD();
            bd.obtenerConexion();
            int elId = Convert.ToInt32(id);
            string query = "SELECT * FROM FUGAZZETA.Hoteles WHERE Id_Hotel = " + elId;
            SqlDataReader dr = bd.lee(query);

            while (dr.Read())
            {
                TxtId.Text = dr["Id_Hotel"].ToString();
                TxtNombre.Text = dr["Nombre"].ToString();
                TxtMail.Text = dr["Mail"].ToString();
                TxtTelefono.Text = dr["Telefono"].ToString();
                TxtCalle.Text = dr["Calle"].ToString();
                TxtNumero.Text = dr["Nro_Calle"].ToString();
                TxtCiudad.Text = dr["Ciudad"].ToString();
                string elItem = "";
                for (int i = 0; i < ComboPais.Items.Count; i++)
                {
                    
                    if ((ComboPais.Items[i] as Pais).id.ToString() == dr["Pais"].ToString())
                    {
                        elItem = ComboPais.Items[i].ToString();
                    }
                }
                ComboPais.Text = elItem;
                ComboCE.Text = dr["CantEstrella"].ToString();
                string fecha = dr["Fec_creacion"].ToString();
                if (fecha != "") { FechaPick.Value = convertirFecha(fecha); }

            }
            bd.cerrar();
        }

        private DateTime convertirFecha(string fecha)
        {
            return Convert.ToDateTime(fecha);
        }

        private void ActualizarDatos_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Son todos los datos correctos?", "Confirmar actualización de hotel", MessageBoxButtons.YesNo);

            if (confirma == DialogResult.Yes)
            {
                actualizarHotel();
            }
        }
 

        private void actualizarHotel()
        {
            int elId = Convert.ToInt32(TxtId.Text);
            int nc = Convert.ToInt32(TxtNumero.Text);
            Pais elPais = ComboPais.Items[ComboPais.SelectedIndex] as Pais;
            int cantE = Convert.ToInt16(ComboCE.Text);
            Hotel hotelin = new Hotel(
                elId, TxtNombre.Text, TxtMail.Text, TxtTelefono.Text, TxtCalle.Text,
                nc, TxtCiudad.Text, elPais, cantE, FechaPick.Value);

            hotelin.actualizar();
            MessageBox.Show("Actualización realizada con éxito");
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ComboPais.Text);
        }


    }
}
