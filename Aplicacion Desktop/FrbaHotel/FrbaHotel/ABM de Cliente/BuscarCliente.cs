using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class BuscarCliente : Buscador
    {
        public BuscarCliente(ITraeBusqueda owner)
        {
            InitializeComponent();
            BD bd = new BD();
            bd.obtenerConexion();
            dondeVuelve = owner;
            setearGrid(GridClientes);
            crearBuscador(dondeVuelve, "*", "[TodosLosClientes]");
            bd.rellenarDesde("Descripcion", "TiposDoc", ComboDoc);
            bd.cerrar();
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            mostrarCantidadResultados(todos);
            cargarGrilla(GridClientes, top(5000, todos));            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDoc.Text = "";
            ComboDoc.SelectedIndex = -1;
            TxtMail.Text = "";
            cargarGrilla(GridClientes, todos);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            actual = todos;
            filtroTexto(TxtNombre.Text, "Nombre", GridClientes);
            addFiltroTextBox(TxtApellido, "Apellido", GridClientes);
            //addFiltroComboBox(ComboDoc, "Id_TipoDoc", GridClientes);
            addFiltroTextBox(TxtDoc, "Nro_Doc", GridClientes);
            addFiltroTextBox(TxtMail, "Mail", GridClientes);
            mostrarCantidadResultados(actual);
            cargarGrilla(GridClientes, top(5000,actual));
        }

        private void mostrarCantidadResultados(string consulta)
        {
            int cant = Int32.Parse(cantidadResultados(consulta));
            if (cant > 5000)
            {
                LblResultados.Text = "Mostrando primeros 5000 resultados de " + cant + ".";
            } else
            {
                LblResultados.Text = cant + " resultados.";
            }
        }

        private void AgregarCliente_Click(object sender, EventArgs e)
        {
            new ABM_de_Cliente.AltaCliente().ShowDialog();
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            string apellidonombre = celdaElegida(GridClientes, 2) + ", " + celdaElegida(GridClientes, 1); 
            dondeVuelve.agregar(celdaElegida(GridClientes, 0), apellidonombre);
        }

    }
}
