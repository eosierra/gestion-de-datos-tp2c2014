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
            crearBuscador(owner,,"Clientes");
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
