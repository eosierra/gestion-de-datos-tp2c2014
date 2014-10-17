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
        public BuscarFuncionalidad(Form formu)
        {
            InitializeComponent();
            crearBuscador(formu, "Descripcion", "Funcionalidades");
            setearGrid(GridFunciones);
        }

        private void BuscarFuncionalidad_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            cargarGrilla(GridFunciones,todos);
        }

        private void TxtFunc_TextChanged(object sender, EventArgs e)
        {
            filtroTexto(TxtFunc, "Descripcion", GridFunciones);
        }
    }
}
