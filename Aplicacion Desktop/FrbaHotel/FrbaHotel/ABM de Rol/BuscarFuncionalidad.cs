using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class BuscarFuncionalidad : Buscador
    {
        public BuscarFuncionalidad(AltaRol formu)
        {
            InitializeComponent();
            crearBuscador(formu, "Id_Funcionalidad,Descripcion", "Funcionalidades");
            setearGrid(GridFunciones);
        }

        private void BuscarFuncionalidad_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            cargarGrilla(GridFunciones,todos);
        }

        private void TxtFunc_TextChanged(object sender, EventArgs e)
        {
            actual = todos;
            addFiltroTextBox(TxtFunc, "Descripcion", GridFunciones);
            cargarGrilla(GridFunciones, actual);
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            string id = celdaElegida(GridFunciones,0);
            string desc = celdaElegida(GridFunciones,1);
            dondeVuelve.agregar(id,desc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
