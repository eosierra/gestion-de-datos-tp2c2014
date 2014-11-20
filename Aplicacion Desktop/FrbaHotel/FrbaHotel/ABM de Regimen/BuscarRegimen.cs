using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Regimen
{
    public partial class BuscarRegimen : Buscador
    {
        public BuscarRegimen(ITraeBusqueda owner)
        {
            InitializeComponent();
            crearBuscador(owner, "Id_Regimen as ID, Descripcion, Precio", "Regimenes WHERE Activo = 1");
            setearGrid(GridRegimenes);
        }

        private void BuscarRegimen_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            cargarGrilla(GridRegimenes, todos);
        }

        private void TxtRegimen_TextChanged(object sender, EventArgs e)
        {
            actual = todos;
            addFiltroTextBox(TxtRegimen, "Descripcion", GridRegimenes);
            cargarGrilla(GridRegimenes, actual);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            string id = celdaElegida(GridRegimenes, 0);
            string name = celdaElegida(GridRegimenes, 1);
            Regimen rol = new Regimen(id, name);
            dondeVuelve.agregar(id, name);
            this.Close();
        }
    }
}
