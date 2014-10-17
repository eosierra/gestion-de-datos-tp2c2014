using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Rol
{
    public abstract class Buscador : Form
    {
        public Form dondeVuelve;
        public BD bd = new BD();
        public string todos; 

        public void crearBuscador(Form owner, string campos, string categoria)
        {
            todos = "SELECT " + campos + " FROM FUGAZZETA." + categoria;
            dondeVuelve = owner;
        }

        public void cargarGrilla(DataGridView grid, string consulta)
        {
            grid.DataSource = bd.ejecutar(consulta);
            bd.cerrar();
        }

        public void filtroTexto(TextBox txt, string campo, DataGridView grid)
        {
            if (txt.Text != "")
            {
                string condicionNueva = todos + " WHERE " + campo + " like '%" + txt.Text + "%'";
                cargarGrilla(grid, condicionNueva);
            }
            else { cargarGrilla(grid, todos); }
        }
    }
}
