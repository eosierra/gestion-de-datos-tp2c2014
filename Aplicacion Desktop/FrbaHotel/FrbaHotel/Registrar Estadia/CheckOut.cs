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
        int cantDiasEstadia;
        int cantDiasReserva;
        int idHotel;
        int idCliente;
        DateTime fechaInicio;
        TableCarrito carrito;

        public CheckOut(MenuPrincipal mp)
        {
            parent = mp;
            InitializeComponent();
            crearBuscador(this, "Id_Consumible as ID, Descripcion, Precio", "Consumibles");
            setearGrid(GridConsumibles);
            setearGrid(GridHabitacion);
            carrito = new TableCarrito();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            cargarGrilla(GridConsumibles, todos);
            GridCarrito.DataSource = carrito.tabla;
            BD bd2 = new BD();
            bd2.obtenerConexion();
            loadBancos();
            loadTarjetas();
            SqlDataReader dr = bd2.lee("SELECT Id_TipoPago FROM FUGAZZETA.TiposPago WHERE Descripcion = 'Efectivo'");
            while (dr.Read()) OpEfectivo.Tag = dr[0].ToString();
            dr.Close();
            bd2.cerrar();
        }

        private void loadBancos()
        {
            BD bd2 = new BD();
            bd2.obtenerConexion();
            CbBanco.Items.Clear();
            try
            {
                string comando = "SELECT * FROM FUGAZZETA.Bancos";
                SqlDataReader respuesta = bd2.lee(comando);
                while (respuesta.Read())
                {
                    CbBanco.Items.Add(new Banco(Int16.Parse(respuesta[0].ToString()),respuesta[1].ToString()));
                }
                respuesta.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al completar: " + ex.Message);
            }
            bd2.cerrar();
        }

        private void loadTarjetas()
        {
            BD bd2 = new BD();
            bd2.obtenerConexion();
            CbTipoPago.Items.Clear();
            try
            {
                string comando = "SELECT * FROM FUGAZZETA.TiposPago WHERE Descripcion != 'Efectivo'";
                SqlDataReader respuesta = bd2.lee(comando);
                while (respuesta.Read())
                {
                    CbTipoPago.Items.Add(new TipoPago(respuesta[0].ToString(), respuesta[1].ToString()));
                }
                respuesta.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al completar: " + ex.Message);
            }
            bd2.cerrar();
        }

        private void VerCO_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            GroupTotal.Visible = true;
            LabelAllinc.Visible = false;
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
                   SqlDataReader dr = bd.lee("EXEC FUGAZZETA.ValidarEstadia " + idReserva + ", '" + Program.hoy().ToShortDateString() + "'");
                    while (dr.Read())
                    {
                        idRegimen = Int32.Parse(dr[1].ToString());
                        fechaInicio = Convert.ToDateTime(dr[2].ToString());
                        cantDiasReserva = Convert.ToInt16((Convert.ToDateTime(dr[3].ToString()) - fechaInicio).TotalDays);
                        cantDiasEstadia = Convert.ToInt16((Program.hoy() - fechaInicio).TotalDays);
                        idHotel = Int16.Parse(dr[4].ToString());
                        idCliente = Int32.Parse(dr[5].ToString());
                    }
                    dr.Close();
                    GroupConsumibles.Enabled = true;
                    GroupHabitacion.Enabled = true;
                    TxtDiasReserva.Text = cantDiasReserva.ToString();
                    TxtDiasEstadia.Text = cantDiasEstadia.ToString();
                    TxtDiasNoEstadia.Text = (cantDiasReserva - cantDiasEstadia).ToString();
                    TxtDiasReserva.Visible = true;
                    TxtDiasEstadia.Visible = true;
                    TxtDiasNoEstadia.Visible = true;
                    if (idRegimen == 2) LabelAllinc.Visible = true;
                    cargarHabitaciones();
                    mostrarTotalHabitacion();
                    mostrarTotalTotal();
                }
                catch (SqlException ex)
                {
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
            if (idRegimen == 2) LblPrecio.Text = "$ 0.-";
            else LblPrecio.Text = "$ " + precio + ".-";
        }

        private void AgregarCarrito_Click(object sender, EventArgs e)
        {
            carrito.add((TxtConsumible.Tag as Consumible),Convert.ToInt32(Cantidad.Value),idRegimen);
            Cantidad.Value = 1;
            LblPrecio.Text = "$";
            TxtConsumible.Text = "";
            TxtConsumible.Tag = null;
            mostrarTotalConsumible();
            mostrarTotalTotal();
            AgregarCarrito.Enabled = false;
            Cantidad.Enabled = false;

        }

        private void mostrarConsumible()
        {
            agregar(celdaElegida(GridConsumibles, 0), celdaElegida(GridConsumibles, 1));
            retPrecio((TxtConsumible.Tag as Consumible).precio * Convert.ToInt32(Cantidad.Value));
            AgregarCarrito.Enabled = true;
            Cantidad.Enabled = true;
        }

        #region GridConsumibles
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
                mostrarTotalConsumible();
                mostrarTotalTotal();
            }
        }
        #endregion

        private void cargarHabitaciones()
        {
            BD bd2 = new BD();
            bd2.obtenerConexion();
            string query = "EXEC FUGAZZETA.VerHabitacionesDeEstadia " + idReserva + ", '" + Program.hoy().ToShortDateString() + "'";
            GridHabitacion.DataSource = bd2.ejecutar(query);
            bd2.cerrar();
            
        }

        private void TxtReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                VerCO_Click(sender, e);
            }
        }

        #region Mostrar Totales
        private void mostrarTotalConsumible()
        {
            LblSubConsumibles.Text = carrito.total().ToString();
        }
        
        private void mostrarTotalHabitacion()
        {
            double totalHabitacion = 0;
            for (int i = 0; i < GridHabitacion.Rows.Count; i++)
            {
                double tot = Convert.ToDouble(GridHabitacion.Rows[i].Cells[4].Value.ToString());
                totalHabitacion = tot + totalHabitacion;
            }
            LblSubEstadia.Text = totalHabitacion.ToString();
        }

        private void mostrarTotalTotal()
        {
            LblTotal.Text = (Int32.Parse(LblSubConsumibles.Text) + Int32.Parse(LblSubEstadia.Text)).ToString();
        }

        #endregion

        private void OpOtro_CheckedChanged(object sender, EventArgs e)
        {
            GroupAbono.Enabled = OpOtro.Checked;
        }

        private void validarAbono()
        {
            if (!OpEfectivo.Checked && !OpOtro.Checked) throw new Exception("No seleccionó ninguna forma de pago.");
            else
            {
                if (OpOtro.Checked)
                {
                    if (CbTipoPago.SelectedIndex == -1) throw new Exception("Debe seleccionar algún tipo de pago.");
                    if (CbBanco.SelectedIndex == -1) throw new Exception("Debe seleccionar algún banco.");
                    if (!OpCA.Checked && !OpCC.Checked) throw new Exception("Debe seleccionar algún tipo de cuenta.");
                    if (TxtNCuenta.TextLength == 0) throw new Exception ("El número de cuenta no es válido.");
                }
            }
        }

        private void TxtNCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void RealizarEgreso_Click(object sender, EventArgs e)
        {
            BD bd2 = new BD();
            bd2.obtenerConexion();
            try
            {
                validarAbono();
                int nroFactura = 0;
                SqlDataReader dr = bd2.lee("EXEC FUGAZZETA.GenerarFactura " + idHotel + ", '" + Program.hoy().ToShortDateString() + "', " + LblTotal.Text + ", " + idCliente);
                while (dr.Read()) nroFactura = Int32.Parse(dr[0].ToString());
                dr.Close();
                bd2.ejecutar("EXEC FUGAZZETA.RealizarEgreso " + idReserva + ", '" + Program.ahora().ToString() + "', '" + parent.usuarioActual + "'");
                
                //Items Hospedaje
                string query = "INSERT INTO FUGAZZETA.Items_Hospedaje values (" + nroFactura + ", 1, " + cantDiasEstadia + ", " + LblSubEstadia.Text + ")";
                bd2.ejecutar(query);
                query = "INSERT INTO FUGAZZETA.Items_Hospedaje values (" + nroFactura + ", 0, " + (cantDiasReserva - cantDiasEstadia).ToString() + ", 0)";
                bd2.ejecutar(query);
                
                foreach (DataGridViewRow row in GridHabitacion.Rows)
                {
                    query = "INSERT INTO FUGAZZETA.HistorialHabitaciones values(" + row.Cells[0].Value.ToString() + ", " + row.Cells[1].Value.ToString() + ", '" + fechaInicio.ToShortDateString() + "', " + cantDiasEstadia + ")";
                    bd2.ejecutar(query);
                }

                
                //Items Consumible
                registrarConsumibles(nroFactura);

                //Abono
                registrarAbono(nroFactura);

                MessageBox.Show("Egreso realizado con éxito.");
                this.Close();
            }
            catch (Exception ex)
            {
                bd2.cerrar();
                MessageBox.Show("Error: No se pudo realizar el egreso. " + ex.Message,this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void registrarAbono(int nf)
        {
            string tipoPago;
            string banco;
            string tipoCuenta;
            string nroCuenta;

            if (OpEfectivo.Checked)
            {
                tipoPago = OpEfectivo.Tag.ToString();
                banco = "NULL";
                tipoCuenta = "NULL";
                nroCuenta = "NULL";
            }
            else
            {
                tipoPago = (CbTipoPago.SelectedItem as TipoPago).id.ToString();
                banco = (CbBanco.SelectedItem as Banco).id.ToString();
                nroCuenta = TxtNCuenta.Text;
                if (OpCA.Checked) tipoCuenta = OpCA.Tag.ToString();
                else tipoCuenta = OpCC.Tag.ToString();
            }
            BD db = new BD();
            db.obtenerConexion();
            string query = "INSERT INTO FUGAZZETA.AbonoFacturas values (" + nf + ", " + tipoPago + ", " + banco + ", '" + tipoCuenta + "', " + nroCuenta + ")";
            db.ejecutar(query);
        }

        private void registrarConsumibles(int nf)
        {
            BD db = new BD();
            db.obtenerConexion();
            for (int i = 0; i < carrito.CantidadConsumibles(); i++)
            {
                int idCon = carrito.getID(GridCarrito.Rows[i].Cells[1].Value.ToString());
                int cantidad = Int16.Parse(GridCarrito.Rows[i].Cells[2].Value.ToString());
                double monto = carrito.getPrecio(GridCarrito.Rows[i].Cells[1].Value.ToString());
                string query = "INSERT INTO FUGAZZETA.Items_Consumible values (" + nf + ", " + idCon + ", " + cantidad + ", "+ monto + ")";
                db.ejecutar(query);
            }
            db.cerrar();
        }
    }
}
