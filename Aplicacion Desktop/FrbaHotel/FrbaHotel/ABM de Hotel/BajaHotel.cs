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
    public partial class BajaHotel : Form
    {
        public BajaHotel(string id)
        {
            InitializeComponent();
            HastaPick.MinDate = Program.hoy();
            TxtId.Text = id;
        }

        private void BajarHotel_Click(object sender, EventArgs e)
        {
            DialogResult confirmaBaja = MessageBox.Show("Está seguro de deshabilitar este hotel?", "Deshabilitar hotel", MessageBoxButtons.OKCancel);
            if (confirmaBaja == DialogResult.OK)
            {
                BD bd = new BD();
                try
                {
                    string query = "EXEC BajarHotel " + TxtId.Text + " " + Program.hoy() + " " + HastaPick.Value.ToString() + " " + TxtMotivo.Text;
                    bd.ejecutar(query);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("No se pudo dar de baja el hotel. " + ex.Message);
                }
            }

        }

    }
}
