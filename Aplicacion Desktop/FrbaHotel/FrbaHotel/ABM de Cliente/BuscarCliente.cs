using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class BuscarCliente : Buscador
    {
        public BuscarCliente(ITraeBusqueda owner)
        {
            InitializeComponent();
            crearBuscador(owner,"*","Clientes");
            setearGrid(GridClientes);
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            cargarGrilla(GridClientes, todos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            addFiltroTextBox(TxtNumero,"Nro_Doc",GridClientes);
        }

        private void TxtMail_TextChanged(object sender, EventArgs e)
        {
            addFiltroTextBox(TxtMail, "Mail", GridClientes);
        }

    }
}
