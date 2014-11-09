using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class AltaHabitacion : Form
    {
        public AltaHabitacion()
        {
            InitializeComponent();
            cargarTipos();
        }

        private void cargarTipos()
        {
            BD bd = new BD();
            bd.obtenerConexion();
            string query = "SELECT * FROM FUGAZZETA.TiposHabitacion ORDER BY Id_TipoHab";
            SqlDataReader dr = bd.lee(query);
            while (dr.Read())
            {
                TipoHabitacion tipo = new TipoHabitacion(dr[0].ToString(), dr[1].ToString());
                CmbTipo.Items.Add(tipo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Son todos los datos correctos? Recuerde que el Tipo de Habitación es definitivo", this.Text, MessageBoxButtons.YesNo);

            if (confirma == DialogResult.Yes)
            {
                BD bd = new BD();
                bd.obtenerConexion();
                try
                {
                    char frente='N';
                    if (Exterior.Checked==true){frente='S';}
                    if (Interior.Checked == true) { frente = 'N'; }

                    TipoHabitacion elTipo = CmbTipo.Items[CmbTipo.SelectedIndex] as TipoHabitacion;
                    
                    string query = 
                        "INSERT INTO FUGAZZETA.Habitaciones values (1,"
                        +TxtNro.Text+","
                        +TxtPiso.Text+",'"
                        +frente+"',"
                        +elTipo.id+",'"
                        +TxtDesc.Text+"',1)"
                        ;
                    bd.ejecutar(query);
                    bd.cerrar();
                    MessageBox.Show("Habitacion agregada con éxito");
                    this.Close();
                }
                catch (Exception ex)
                {
                    bd.cerrar();
                    MessageBox.Show("Error: No se pudo ingresar la habitacion. " + ex.Message);
                }
            }
        }
    }
}
