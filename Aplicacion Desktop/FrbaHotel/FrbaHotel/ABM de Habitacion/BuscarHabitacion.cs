using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class BuscarHabitacion : Buscador
    {
        int idHotel;

        public BuscarHabitacion(ITraeBusqueda owner,int hotel)
        {
            InitializeComponent();
            crearBuscador(owner, "Num_Habitacion,Piso,Id_TipoHab [Tipo Habitacion],Frente,Habilitado", "Habitaciones");
            setearGrid(GridHabitaciones);
            idHotel = hotel;
            
        }

        private void BuscarHabitacion_Load_1(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            actual = todos;
            addFiltroPorID(idHotel, "Id_Hotel", GridHabitaciones);
            cargarGrilla(GridHabitaciones, actual);
        }

            

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtHabitacion_TextChanged(object sender, EventArgs e)
        {
            actual = todos;
            addFiltroTextBox(TxtHabitacion, "Num_Habitacion", GridHabitaciones);
            addFiltroPorID(idHotel, "Id_Hotel", GridHabitaciones);
            cargarGrilla(GridHabitaciones, actual);
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            string id = celdaElegida(GridHabitaciones, 0);
            DialogResult modif = new AltaHabitacion('M',id,idHotel).ShowDialog();
            if (modif == DialogResult.OK)
            {
                Close();
            }
        }
        }
    }

       

