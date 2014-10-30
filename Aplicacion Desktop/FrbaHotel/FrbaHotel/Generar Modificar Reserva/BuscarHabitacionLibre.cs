using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class BuscarHabitacionLibre : Buscador
    {
        int hotel;
        string desde;
        string hasta;

        public BuscarHabitacionLibre(ITraeBusqueda owner, int hotelActual, string desdePick, string hastaPick)
        {
            InitializeComponent();
            hotel = hotelActual;
            desde = desdePick;
            hasta = hastaPick;
            dondeVuelve = owner;
            setearGrid(GridHabitaciones);
        }

        private void BuscarHabitacionLibre_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            string query = "EXEC FUGAZZETA.HabitacionesLibresEnPeriodo " + hotel + ", '" + desde + "', '" + hasta + "'"; 
            cargarGrilla(GridHabitaciones,query);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            string numero = celdaElegida(GridHabitaciones, 0);
            dondeVuelve.agregar(hotel.ToString(), numero);
        }
    }
}
