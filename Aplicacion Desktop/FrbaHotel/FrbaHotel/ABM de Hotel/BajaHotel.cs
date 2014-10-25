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
                string parametros = TxtId.Text + ", '" + dateSolo(Program.hoy()) + "', '" + dateSolo(HastaPick.Value) + "'"; 
                try
                {
                    string query = "EXEC FUGAZZETA.VerReservasHotel " + parametros;
                    SqlCommand dr = new SqlCommand(query,bd.getConexion());
                    int cantidadReservas = (int)dr.ExecuteScalar();
                    MessageBox.Show(cantidadReservas.ToString());
                    if (cantidadReservas > 0)
                    {
                        throw new Exception("Hay reservas en ese período para el hotel.");
                    }
                    else
                    {
                        string query2 = "INSERT INTO FUGAZZETA.MovimientosHotel values (" + parametros +  ", '" + TxtMotivo.Text + "')";
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


        public string dateSolo(DateTime fecha)
        {
            return (fecha.Day + "/" + fecha.Month + "/" + fecha.Year);
        }

    }
}
