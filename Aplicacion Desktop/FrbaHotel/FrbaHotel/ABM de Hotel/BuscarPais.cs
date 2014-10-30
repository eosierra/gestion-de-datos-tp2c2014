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
    public partial class BuscarPais : Buscador
    {
        public BuscarPais(ITraeBusqueda owner)
        {
            InitializeComponent();
            crearBuscador(owner, "*", "Paises");
            setearGrid(GridPaises);
            GridPaises.AllowUserToAddRows = true;
        }

        private void BuscarPais_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            cargarGrilla(GridPaises, todos);
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            actual = todos;
            addFiltroTextBox(TxtNombre, "Nombre", GridPaises);
            cargarGrilla(GridPaises, actual);
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            string id = celdaElegida(GridPaises, 0);
            string desc = celdaElegida(GridPaises, 1);
            dondeVuelve.agregar(id, desc);
        }


    }
}
