using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace FrbaHotel
{
    public class Buscador : Form
    {
        public char funcion;
        public ITraeBusqueda dondeVuelve;
        public BD bd = new BD();
        public string todos;
        private string campos;
        private string tabla;
        public string actual;

        public void crearBuscador(ITraeBusqueda owner, string camposDeBsq, string categoria)
        {
            campos = camposDeBsq;
            tabla = categoria;
            todos = "SELECT " + campos + " FROM FUGAZZETA." + categoria;
            dondeVuelve = owner;
        }

        public void cargarGrilla(DataGridView grid, string consulta)
        {
            grid.DataSource = bd.ejecutar(consulta);
            bd.cerrar();
        }

        public string top(int n, string consulta)
        {
            return "SELECT TOP " + n + " " + consulta.Substring(6);
        }

        public string cantidadResultados(string query)
        {
            SqlDataReader dr = bd.lee("SELECT COUNT(*) " + query.Substring(7 + campos.Length));
            string cant="";
            while (dr.Read())
            {
                cant = dr[0].ToString();
            }
            return cant;
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
            grid.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            grid.RowTemplate.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.RowTemplate.Resizable = DataGridViewTriState.False;
        }

        public string celdaElegida(DataGridView grid, int columna)
        {
            return grid.CurrentRow.Cells[columna].Value.ToString();
        }

        public void filtroTexto(string texto, string campoTabla, DataGridView grid)
        {
            if (texto != "")
            {
                string conCondicion;
                if (!actual.Contains("WHERE"))
                {
                    conCondicion = " WHERE ";
                }
                else
                {
                    conCondicion = " AND ";
                }
                actual = actual + conCondicion + campoTabla + " like '%" + texto + "%'";
            }
        }

        public void addFiltroTextBox(TextBox txt, string campo, DataGridView grid)
        {
            filtroTexto(txt.Text, campo, grid);
        }

        public void addFiltroComboBox(ComboBox cb, string campo, DataGridView grid)
        {
            
            filtroTexto(cb.Text, campo, grid);
        }

        public void addFiltroPorID(int idElegido, string campoTabla, DataGridView grid)
        {
            if (idElegido > 0)
            {
                string conCondicion;
                if (!actual.Contains("WHERE"))
                {
                    conCondicion = " WHERE ";
                }
                else
                {
                    conCondicion = " AND "; 
                }
                actual = actual + conCondicion + campoTabla + " like '" + idElegido + "'";
            }
        }
    }
}
