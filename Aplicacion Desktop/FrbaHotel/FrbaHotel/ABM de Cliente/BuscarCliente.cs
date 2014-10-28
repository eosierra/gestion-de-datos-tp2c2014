using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class BuscarCliente : Buscador
    {
        public BuscarCliente(ITraeBusqueda owner)
        {
            InitializeComponent();
            BD bd = new BD();
            bd.obtenerConexion();
            bd.rellenarDesde("Descripcion", "TiposDoc", ComboDoc);
            //crearBuscador(owner,"*","[TodosLosClientes]");
            dondeVuelve = owner;

            SqlDataAdapter dAdap = new SqlDataAdapter("SELECT * FROM FUGAZZETA.Clientes", bd.getConexion());
            DataSet ds = new DataSet();
            dAdap.Fill(ds, "FUGAZZETA.Clientes");
            GridClientes.DataSource = ds;
            //GridClientes.DataMember = "*";
            GridClientes.Refresh();
            setearGrid(GridClientes);
            bd.cerrar();
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            //cargarGrilla(GridClientes, todos);
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
            cargarGrilla(GridClientes, actual);
        }

        private void AgregarCliente_Click(object sender, EventArgs e)
        {
            new ABM_de_Cliente.AltaCliente().ShowDialog();
        }

    }
}
