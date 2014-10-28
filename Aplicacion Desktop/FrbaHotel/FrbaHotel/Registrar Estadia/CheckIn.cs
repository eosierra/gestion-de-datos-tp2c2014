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
    public partial class CheckIn : Form, ITraeBusqueda
    {
        string idCliente;
        string idHotel;
                
        public CheckIn()
        {
            InitializeComponent();
        }

        private void VerDatos_Click(object sender, EventArgs e)
        {
            try
            {
                BD bd = new BD();
                bd.obtenerConexion();
                validarCompletarReserva(bd);
                completarDatos(bd);
                bd.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden ver los datos. " + ex.Message,"Check in");
            }
        }

        private void validarCompletarReserva(BD bd)
        {
            if (TxtCodigo.Text == "")
            {
                throw new Exception("No ha ingresado ninguna reserva.");
            }
            else
            {
                try
                {
                    string comando = "SELECT * FROM FUGAZZETA.[ReservasModificables] WHERE Id_Reserva = " + TxtCodigo.Text;
                    SqlDataReader dr = bd.lee(comando);
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            string fechaKey = dr[4].ToString().Substring(0, 10);
                            if (fechaKey != new DatePrograma(Program.hoy()).ToString())
                            {
                                dr.Close();
                                throw new Exception("No se puede ingresar con ese código de reserva. Corresponde al día " + fechaKey + ".");
                            }
                            TxtId.Text = dr[0].ToString();
                            idCliente = dr[1].ToString();
                            idHotel = dr[2].ToString();
                            TxtHotel.Text = dr[2].ToString();
                            TxtFecReserva.Text = dr[3].ToString().Substring(0, 10);
                            TxtFecInicio.Text = fechaKey;
                            TxtFecFin.Text = dr[6].ToString().Substring(0, 10);
                            TxtRegimen.Text = dr[7].ToString();
                        }
                    }
                    else
                    {
                        dr.Close();
                        throw new Exception("La reserva no existe, ya se ha cancelado o ya realizó el ingreso.");
                    }
                    dr.Close();
                }
                catch (SqlException sqlEx)
                {
                    throw new Exception("Error " + sqlEx.Number  + " de SQL: " + sqlEx.Message);
                }

            }
        }

        private void completarDatos(BD bd)
        {
            try
            {
                SqlDataReader reader;
                //Datos del Hotel
                string query = "SELECT Nombre FROM FUGAZZETA.Hoteles WHERE Id_Hotel = " + idHotel;
                reader = bd.lee(query);
                while (reader.Read())
                {
                    TxtHotel.Text = idHotel + " - " + reader[0].ToString();
                }
                reader.Close();

                //Datos de las habitaciones
                query = "SELECT Num_Habitacion FROM FUGAZZETA.[Habitaciones x Reservas] WHERE Id_Reserva = " + TxtCodigo.Text;
                reader = bd.lee(query);
                while (reader.Read())
                {
                    ListHabitaciones.Items.Add (reader[0].ToString());
                }
                reader.Close();


                //Datos del cliente
                query = "SELECT * FROM FUGAZZETA.Clientes WHERE Id_Cliente = " + idCliente;
                reader = bd.lee(query);
                while (reader.Read())
                {
                    TxtNombre.Text = reader[1].ToString() + " " + reader[2].ToString();
                    TxtDoc.Text = reader[3].ToString() + " " + reader[4].ToString();
                    TxtPais.Text = reader[13].ToString();
                    TxtNac.Text = reader[5].ToString().Substring(0, 10);
                    TxtMail.Text = reader[6].ToString();
                    TxtTelefono.Text = reader[7].ToString();
                    TxtDomicilio.Text = reader[8].ToString() + " " + reader[9].ToString() + " " + reader[10].ToString() + " " + reader[11].ToString();
                    TxtCiudad.Text = reader[12].ToString();
                }
                reader.Close();
                groupBox1.Enabled = true;
                RealizarIngreso.Enabled = true;
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Error " + sqlEx.Number + " de SQL: " + sqlEx.Message);
            }
        }

        private void QuitarPersona_Click(object sender, EventArgs e)
        {
            ListPersonas.Items.Remove(ListPersonas.SelectedIndex);
        }

        private void AgregarPersona_Click(object sender, EventArgs e)
        {
            new ABM_de_Cliente.BuscarCliente(this).ShowDialog();
        }

        public void agregar(string id, string descripcion)
        {
            MessageBox.Show("EXITO");
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                VerDatos_Click(sender, e);
            }
        }
    }
}
