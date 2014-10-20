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
        //string hotelElegido;

        public ModificarHotel()
        {
            InitializeComponent();
        }

        private void ModificarHotel_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            FechaPick.MaxDate = Program.hoy();
            
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
            SqlCommand cmd = new SqlCommand(query, bd.getConexion());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TxtId.Text = dr["Id_Hotel"].ToString();
                TxtNombre.Text = dr["Nombre"].ToString();
                TxtMail.Text = dr["Mail"].ToString();
                TxtTelefono.Text = dr["Telefono"].ToString();
                TxtCalle.Text = dr["Calle"].ToString();
                TxtNumero.Text = dr["Nro_Calle"].ToString();
                TxtCiudad.Text = dr["Ciudad"].ToString();
                ComboPais.Text = dr["Pais"].ToString();
                FechaPick.Value = Convert.ToDateTime(dr["Fec_creacion"].ToString());
            }
            bd.cerrar();
        }

    }
}
