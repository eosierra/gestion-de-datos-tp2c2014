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
            crearBuscador(owner, "Num_Habitacion", "Habitaciones");
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


        

        /*private void TxtRol_TextChanged(object sender, EventArgs e)
        {
            actual = todos;
            addFiltroTextBox(TxtRol, "Nombre", GridRoles);
            cargarGrilla(GridRoles, actual);

        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        /*private void button1_Click(object sender, EventArgs e)
        {
            if (funcion == 'S')
            {
                string id = celdaElegida(GridRoles, 0);
                string name = celdaElegida(GridRoles, 1);
                Rol rol = new Rol(id, name);
                dondeVuelve.agregar(id, name);
                this.Close();
            }
            if (funcion == 'M')
            {
                string id = celdaElegida(GridRoles, 0);
                string name = celdaElegida(GridRoles, 1);
                DialogResult modif = new AltaRol('M', id, name).ShowDialog();
                if (modif == DialogResult.OK)
                {
                    Close();
                }
            }
        }*/
    }
}
       

