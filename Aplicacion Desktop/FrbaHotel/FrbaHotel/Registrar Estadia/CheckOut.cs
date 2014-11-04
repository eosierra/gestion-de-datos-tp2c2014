using System;
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
        int idRegimen;
        TableCarrito carrito;

        public CheckOut(MenuPrincipal mp)
        {
            parent = mp;
            InitializeComponent();
            crearBuscador(this, "Id_Consumible as ID, Descripcion, Precio", "Consumibles");
            setearGrid(GridConsumibles);
            setearGrid(GridHabitacion);
           // GridHabitacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
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
                   SqlDataReader dr = bd.lee("EXEC FUGAZZETA.ValidarEstadia " + idReserva);
                    while (dr.Read())
                    {
                        idRegimen = Int32.Parse(dr[1].ToString());
                    }
                    dr.Close();
                    GroupConsumibles.Enabled = true;
                    GroupHabitacion.Enabled = true;
                    cargarHabitaciones();
                }
                catch (SqlException ex)
                {
                   // dr.Close();
                    foreach (SqlError sqlError in ex.Errors)
                        MessageBox.Show("Error: " + sqlError.Message);
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

        private void GridCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 & e.RowIndex >= 0)
            {
                carrito.remove(e.RowIndex);
            }
        }

        private void cargarHabitaciones()
        {
            BD bd2 = new BD();
            bd2.obtenerConexion();
            string query = "EXEC FUGAZZETA.VerHabitacionesDeEstadia " + idReserva + ", '" + new DatePrograma(Program.hoy()).ToString() + "'";
            GridHabitacion.DataSource = bd2.ejecutar(query);
            bd2.cerrar();
        }

    }
}
