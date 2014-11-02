﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            crearBuscador(this, "Id_Consumible as ID, Descripcion, Precio", "Consumibles");
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
            if (TxtReserva.Text == "")
            {
                MessageBox.Show("No se ingresó ninguna reserva.");
            }
            else
            {
                idReserva = Int32.Parse(TxtReserva.Text);
                BD bd = new BD();
                bd.obtenerConexion();
                try
                {
                    bd.ejecutar("EXEC FUGAZZETA.ValidarEstadia " + idReserva);
                    TabSalida.Enabled = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Errors.ToString());
                }
            }
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

        private void AgregarCarrito_Click(object sender, EventArgs e)
        {
            carrito.add((TxtConsumible.Tag as Consumible),Convert.ToInt32(Cantidad.Value));
            Cantidad.Value = 1;
            LblPrecio.Text = "$";
            TxtConsumible.Text = "";
            TxtConsumible.Tag = null;
            AgregarCarrito.Enabled = false;
        }

        private void mostrarConsumible()
        {
            agregar(celdaElegida(GridConsumibles, 0), celdaElegida(GridConsumibles, 1));
            retPrecio((TxtConsumible.Tag as Consumible).precio * Convert.ToInt32(Cantidad.Value));
            AgregarCarrito.Enabled = true;
        }

        private void GridConsumibles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mostrarConsumible();
        }

        private void GridConsumibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarConsumible();
        }

    }
}
