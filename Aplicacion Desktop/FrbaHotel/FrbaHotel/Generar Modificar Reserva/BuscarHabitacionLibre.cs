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
        char fx;
        int hotel;
        string desde;
        string hasta;
        string idRegimen;
        GenerarReserva padre;
        ModificarReserva padreM;

        public BuscarHabitacionLibre(ITraeBusqueda owner, int hotelActual, string desdePick, string hastaPick, string regimen)
        {
            InitializeComponent();
            hotel = hotelActual;
            desde = desdePick;
            hasta = hastaPick;
            idRegimen = regimen;
            dondeVuelve = owner;
            setearGrid(GridHabitaciones);
        }

        public BuscarHabitacionLibre(GenerarReserva owner, int hotelActual, string desdePick, string hastaPick, string regimen,char fun)
        {
            fx = fun;
            InitializeComponent();
            hotel = hotelActual;
            desde = desdePick;
            hasta = hastaPick;
            idRegimen = regimen;
            padre = owner;
            setearGrid(GridHabitaciones);
        }

        public BuscarHabitacionLibre(ModificarReserva owner, int hotelActual, string desdePick, string hastaPick, string regimen, char fun)
        {
            fx = fun;
            InitializeComponent();
            hotel = hotelActual;
            desde = desdePick;
            hasta = hastaPick;
            idRegimen = regimen;
            padreM = owner;
            setearGrid(GridHabitaciones);
        }

        private void BuscarHabitacionLibre_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            string query = "EXEC FUGAZZETA.HabitacionesLibresEnPeriodo " + hotel + ", '" + desde + "', '" + hasta + "', " + idRegimen; 
            cargarGrilla(GridHabitaciones,query);
            if (GridHabitaciones.RowCount == 0)
            {
                LabelAll.Visible = true;
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            if (fx=='G'){
                string numero = celdaElegida(GridHabitaciones, 0);
                string tipo = celdaElegida(GridHabitaciones, 1);
                string pu = celdaElegida(GridHabitaciones, 4);
                padre.habitacionParaReserva(hotel.ToString(), numero,tipo,pu);
            }
            else{
                if (fx == 'M')
                {
                    string numero = celdaElegida(GridHabitaciones, 0);
                    string tipo = celdaElegida(GridHabitaciones, 1);
                    string pu = celdaElegida(GridHabitaciones, 4);
                    padreM.habitacionParaReserva(hotel.ToString(), numero, tipo, pu);
                }
                else
                {
                    string numero = celdaElegida(GridHabitaciones, 0);
                    dondeVuelve.agregar(hotel.ToString(), numero);
                }
            }
        }
    }
}
