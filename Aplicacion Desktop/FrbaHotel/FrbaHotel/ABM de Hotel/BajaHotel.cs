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
                bd.obtenerConexion();
                string parametros = TxtId.Text + ", '" + Program.hoy().ToShortDateString() + "', '" + HastaPick.Value.ToShortDateString() + "'"; 
                try
                {
                    string query = "EXEC FUGAZZETA.OcupacionEnHotelEnPeriodo " + parametros;
                    SqlDataReader dr = bd.lee(query);
                    if (dr.HasRows)
                    {
                        throw new Exception("Hay reservas en ese período para el hotel.");
                    }
                    else
                    {
                        string query2 = "INSERT INTO FUGAZZETA.HistorialBajasHotel values (" + parametros +  ", '" + TxtMotivo.Text + "')";
                        bd.ejecutar(query2);

                    }

                }
                catch (Exception ex)
                {
                    this.DialogResult = DialogResult.Abort;
                    MessageBox.Show("No se pudo dar de baja el hotel. " + ex.Message);
                }
                
            }

        }
    }
}
