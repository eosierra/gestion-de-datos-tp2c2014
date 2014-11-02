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
        int n = 100;

        public BuscarCliente(ITraeBusqueda owner)
        {
            InitializeComponent();
            BD bd = new BD();
            bd.obtenerConexion();
            dondeVuelve = owner;
            setearGrid(GridClientes);
            crearBuscador(dondeVuelve, "*", "Clientes");
            bd.rellenarDesde("Descripcion", "TiposDoc", ComboDoc);
            bd.cerrar();
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            mostrarCantidadResultados(todos);
            cargarGrilla(GridClientes, top(n, todos));            
        }

        private void Cancelar_Click(object sender, EventArgs e)
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
            cargarGrilla(GridClientes, top(n,actual));
        }

        private void mostrarCantidadResultados(string consulta)
        {
            int cant = Int32.Parse(cantidadResultados(consulta));
            if (cant > n)
            {
                LblResultados.Text = "Mostrando primeros " +  n + " de " + cant + " resultados.";
            } else
            {
                LblResultados.Text = "Se encontraron " + cant + " resultados.";
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
