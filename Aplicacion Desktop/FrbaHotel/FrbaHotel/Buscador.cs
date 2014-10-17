using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel
{
    public class Buscador : Form
    {
        public ITraeBusqueda dondeVuelve;
        public BD bd = new BD();
        public string todos;
         

        public void crearBuscador(ITraeBusqueda owner, string campos, string categoria)
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Buscador
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "Buscador";
            this.ResumeLayout(false);

        }

        public void setearGrid(DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public string celdaElegida(DataGridView grid, int columna)
        {
            return grid.CurrentRow.Cells[columna].Value.ToString();
        }
    }
}
