using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaHotel.ABM_de_Regimen;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class ModificarReserva : Form
    {
        MenuPrincipal menu;
        int idReserva;
        int idHotel;
        List<Regimen> regimenes;
        string idRegimen;

        public ModificarReserva(MenuPrincipal parent)
        {
            InitializeComponent();
            menu = parent;
            GroupReserva.Enabled = false;
            Desde.MinDate = Program.hoy();
            Hasta.MinDate = Program.hoy();
            regimenes = new List<Regimen>();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            if (TxtReserva.Text == "") MessageBox.Show("No se ingresó ninguna reserva.", this.Text, MessageBoxButtons.OK);
            else
            {
                idReserva = Int32.Parse(TxtReserva.Text);
                BD bd = new BD();
                bd.obtenerConexion();

                //CARGA DATOS ESTADIA
                SqlDataReader dr = bd.lee("SELECT * FROM FUGAZZETA.[ReservasModificables] WHERE Id_Reserva = " + idReserva);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        idHotel = Int32.Parse(dr[2].ToString());
                        Desde.Value = Convert.ToDateTime(dr[4].ToString());
                        Hasta.Value = Convert.ToDateTime(dr[6].ToString());
                        idRegimen = dr[7].ToString();
                    }
                    dr.Close();

                    //CARGA REGIMENES
                    regimenes.Clear();
                    dr = bd.lee("SELECT R.Id_Regimen, R.Descripcion FROM FUGAZZETA.Regimenes R, FUGAZZETA.[Regimenes x Hotel] H WHERE H.Id_Regimen = R.Id_Regimen and H.Id_Hotel = " + idHotel);
                    while (dr.Read())
                        regimenes.Add(new Regimen(dr[0].ToString(), dr[1].ToString()));
                    dr.Close();
                    CbRegimen.DataSource = regimenes;
                    CbRegimen.Text = idRegimen;

                    //
                    GroupReserva.Enabled = true;
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No se encontró la reserva.", this.Text);
                }
            }
        }

        private void TxtReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) Mostrar_Click(sender, e);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void QuitarHab_Click(object sender, EventArgs e)
        {
            if (ListHabitaciones.SelectedIndex != -1) ListHabitaciones.Items.Remove(ListHabitaciones.SelectedItem);
        }
    }
}
