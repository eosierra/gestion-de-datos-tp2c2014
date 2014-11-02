using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class CheckOut : Buscador, ITraeBusqueda
    {
        MenuPrincipal parent;
        int idReserva;
        TableCarrito carrito;

        public CheckOut(MenuPrincipal mp)
        {
            parent = mp;
            InitializeComponent();
            crearBuscador(this, "*", "Consumibles");
            setearGrid(GridConsumibles);
            carrito = new TableCarrito();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            cargarGrilla(GridConsumibles, todos);
            GridCarrito.DataSource = carrito.tabla;
        }

        private void VerCO_Click(object sender, EventArgs e)
        {
            TabSalida.Enabled = true;
        }


        #region ITraeBusqueda Members

        public void agregar(string id, string descripcion)
        {
            TxtConsumible.Tag = new Consumible(id, descripcion);
            TxtConsumible.Text = TxtConsumible.Tag.ToString();
        }

        #endregion

        private void Cantidad_ValueChanged(object sender, EventArgs e)
        {
            double precio = (TxtConsumible.Tag as Consumible).precio * Convert.ToInt32(Cantidad.Value);
            retPrecio(precio);
        }

        private void retPrecio(double precio)
        {
            LblPrecio.Text = "$ " + precio + ".-";
        }

        private void GridConsumibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            agregar(celdaElegida(GridConsumibles, 0), celdaElegida(GridConsumibles, 1));
        }

        private void AgregarCarrito_Click(object sender, EventArgs e)
        {
            carrito.add((TxtConsumible.Tag as Consumible),Convert.ToInt32(Cantidad.Value));
            Cantidad.Value = 1;
            LblPrecio.Text = "$";
            TxtConsumible.Text = "";
        }

    }
}
