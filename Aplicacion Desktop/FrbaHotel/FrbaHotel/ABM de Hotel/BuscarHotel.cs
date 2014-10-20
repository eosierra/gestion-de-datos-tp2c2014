using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class BuscarHotel : Buscador
    {
        public BuscarHotel(ITraeBusqueda owner)
        {
            InitializeComponent();
            crearBuscador(owner, "Id_Hotel,Nombre,Calle,Nro_Calle,Ciudad", "Hoteles");
            setearGrid(GridHoteles);
        }

        private void BuscarHotel_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            cargarGrilla(GridHoteles, todos);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtCiudad_TextChanged(object sender, EventArgs e)
        {
            filtroTexto(TxtCiudad, "Ciudad", GridHoteles);
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            string id = celdaElegida(GridHoteles,0);
            string desc = celdaElegida(GridHoteles,1);
            dondeVuelve.agregar(id,desc);
        }
    }
}
