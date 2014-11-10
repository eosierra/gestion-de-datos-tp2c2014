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
    public partial class ModificarReserva : Form,ITraeBusqueda
    {
        MenuPrincipal menu;
        int idReserva;
        int idHotel;
        List<Regimen> regimenes;
        string idRegimen;
        int nBuscador;
        DataTable habitacionesALiberar;
        bool cambioReserva;

        public ModificarReserva(MenuPrincipal parent)
        {
            InitializeComponent();
            menu = parent;
            GroupReserva.Enabled = false;
            Desde.MinDate = Program.hoy();
            Hasta.MinDate = Program.hoy();
            regimenes = new List<Regimen>();
            habitacionesALiberar = new DataTable();
            habitacionesALiberar.Columns.Add("Reserva");
            habitacionesALiberar.Columns.Add("Hotel");
            habitacionesALiberar.Columns.Add("Numero");
            cambioReserva = false;
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            string condicion = "";
            if (TxtReserva.Text == "") MessageBox.Show("No se ingresó ninguna reserva.", this.Text, MessageBoxButtons.OK);
            else
            {
                idReserva = Int32.Parse(TxtReserva.Text);
                BD bd = new BD();
                bd.obtenerConexion();
                if (menu.usuarioActual != "guest")
                {
                    HotelClick.Enabled = false;
                    idHotel = menu.hotelActual;
                    TxtHotel.Text = idHotel.ToString();
                    condicion = " AND Id_Hotel = " + idHotel;
                }
                //CARGA DATOS ESTADIA
                SqlDataReader dr = bd.lee("SELECT * FROM FUGAZZETA.[ReservasModificables] WHERE Id_Reserva = " + idReserva + condicion);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        idHotel = Int32.Parse(dr[2].ToString());
                        TxtHotel.Text = idHotel.ToString();
                        Desde.Value = Convert.ToDateTime(dr[4].ToString());
                        Hasta.Value = Convert.ToDateTime(dr[6].ToString());
                        idRegimen = dr[7].ToString();
                    }
                    dr.Close();

                    //CARGA REGIMENES
                    restaurarRegimenes(bd);
                    CbRegimen.Text = idRegimen;

                    //CARGA HABITACIONES
                    cargarYLiberarHabitaciones(bd);
                    GroupReserva.Enabled = true;
                    MostrarDatos.Enabled = false;
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No se encontró la reserva o la misma no pertenece al hotel logueado.", this.Text);
                }
            }
        }

        private void restaurarRegimenes(BD bd)
        {
            regimenes.Clear();
            SqlDataReader dr = bd.lee("SELECT R.Id_Regimen, R.Descripcion FROM FUGAZZETA.Regimenes R, FUGAZZETA.[Regimenes x Hotel] H WHERE H.Id_Regimen = R.Id_Regimen and H.Id_Hotel = " + idHotel);
            while (dr.Read())
                regimenes.Add(new Regimen(dr[0].ToString(), dr[1].ToString()));
            dr.Close();
            CbRegimen.DataSource = regimenes;
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

        #region ITraeBusqueda Members

        public void agregar(string id, string descripcion)
        {
            switch (nBuscador)
            {
                case 1:
                    idHotel = Int32.Parse(id);
                    TxtHotel.Text = descripcion;
                    BD bd = new BD();
                    bd.obtenerConexion();
                    restaurarRegimenes(bd);
                    bd.cerrar();
                    break;
                case 2:
                    ListHabitaciones.Items.Add(new ABM_de_Habitacion.Habitacion(id, descripcion));
                    break;
            }
        }

        #endregion

        private void HotelClick_Click(object sender, EventArgs e)
        {
            nBuscador = 1;
            DialogResult nuevoHotel = new ABM_de_Hotel.BuscarHotel(this).ShowDialog();
            if (nuevoHotel == DialogResult.OK)
            {
                ListHabitaciones.Items.Clear();
            }
        }

        private void AddHabitacion_Click(object sender, EventArgs e)
        {
            nBuscador = 2;
            string reg;
            if (CbRegimen.SelectedIndex == -1) reg = "NULL";
            else reg = (CbRegimen.SelectedItem as Regimen).id.ToString();
            
            DialogResult agregado = new BuscarHabitacionLibre(this, idHotel, Desde.Value.ToShortDateString(), Hasta.Value.ToShortDateString(), reg).ShowDialog();
            if (agregado == DialogResult.OK)
            {
                validarOtrasHabitaciones();
            }
        }

        private void validarOtrasHabitaciones()
        {
            for (int i = 0; i < ListHabitaciones.Items.Count - 1; i++)
            {
                if (ListHabitaciones.Items[i].ToString() == ListHabitaciones.Items[i + 1].ToString())
                {
                    string eliminado = ListHabitaciones.Items[i].ToString();
                    ListHabitaciones.Items.RemoveAt(i);
                    MessageBox.Show("La habitación " + eliminado + " ya había sido elegida.");
                }
            }
        }

        private void cargarYLiberarHabitaciones(BD bd)
        {
            SqlDataReader dr = bd.lee("SELECT * FROM FUGAZZETA.[Habitaciones x Reservas] WHERE Id_Reserva = " + idReserva);
            ListHabitaciones.Items.Clear();
            while (dr.Read())
            {
                DataRow row = habitacionesALiberar.NewRow();
                ListHabitaciones.Items.Add(new ABM_de_Habitacion.Habitacion(dr[1].ToString(),dr[2].ToString()));
                row.SetField(0, dr[0].ToString());
                row.SetField(1, dr[1].ToString());
                row.SetField(2, dr[2].ToString());
                habitacionesALiberar.Rows.Add(row);
            }
            dr.Close();
            bd.ejecutar("DELETE FROM FUGAZZETA.[Habitaciones x Reservas] WHERE Id_Reserva = " + idReserva);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerHabitaciones_Click(object sender, EventArgs e)
        {
            HotelClick.Enabled = false;
            Desde.Enabled = false;
            Hasta.Enabled = false;
            VerHabitaciones.Enabled = false;
            ListHabitaciones.Items.Clear();
            GroupHabitaciones.Enabled = true;
        }

        private void ModificarReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cambioReserva)
            {
                DialogResult confirma = MessageBox.Show("Está seguro de cancelar la modificación?", this.Text, MessageBoxButtons.OKCancel);
                if (confirma == DialogResult.OK)
                {
                    BD bd = new BD();
                    bd.obtenerConexion();
                    ListHabitaciones.Items.Clear();
                    for (int i = 0; i < habitacionesALiberar.Rows.Count; i++)
                    {
                        string reserva = habitacionesALiberar.Rows[i][0].ToString();
                        string hotel = habitacionesALiberar.Rows[i][1].ToString();
                        string habitacion = habitacionesALiberar.Rows[i][2].ToString();
                        bd.ejecutar("INSERT INTO FUGAZZETA.[Habitaciones x Reservas] values(" + reserva + ", " + hotel + ", " + habitacion + ")");
                    }
                    bd.cerrar();
                    MessageBox.Show("Reserva cancelada.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ActualizarDatos_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Son todos los datos correctos?", this.Text, MessageBoxButtons.OKCancel);
            if (confirma == DialogResult.OK)
            {
                try
                {
                    validarRegimen();
                    validarHabitaciones();
                    BD bd = new BD();
                    bd.obtenerConexion();
                    string query = "EXEC FUGAZZETA.RealizarModificacion " + idReserva + ", '" + menu.usuarioActual + "', '" + Program.ahora() + "', " + ifNull(Motivo.Text);
                    bd.ejecutar(query);
                    query = "EXEC FUGAZZETA.ActualizarReserva " + idReserva + ", " + idHotel + ", '" + Desde.Value.ToShortDateString() + "', '" + Hasta.Value.ToShortDateString() + "', " + (CbRegimen.SelectedItem as Regimen).id;
                    bd.ejecutar(query);
                    for (int i = 0; i < ListHabitaciones.Items.Count; i++)
                    {
                        query = "INSERT INTO FUGAZZETA.[Habitaciones x Reservas] values(" + idReserva + ", " + idHotel + ", " + ListHabitaciones.Items[i].ToString() + ")";
                        bd.ejecutar(query);
                    }
                    cambioReserva = true;
                    MessageBox.Show("Modificación realizada con éxito.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    confirma = DialogResult.Cancel;
                    MessageBox.Show("Error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void validarHabitaciones()
        {
           if (ListHabitaciones.Items.Count == 0) throw new Exception ("No hay habitaciones para esta reserva.");
        }

        private string ifNull(string p)
        {
            if (p.Length == 0) return "NULL";
            else return "'" + p + "'";
        }

        private void validarRegimen()
        {
            if (CbRegimen.SelectedIndex == -1) throw new Exception ("No seleccionó ningún régimen.");
        }

        private void revalidarFecha(object sender, EventArgs e)
        {
            if (!(Desde.Value < Hasta.Value))
            {
                DateTime nuevo = Desde.Value;
                Hasta.MinDate = new DateTime(nuevo.Year, nuevo.Month, nuevo.Day + 1);
            }
        }
    }
}
