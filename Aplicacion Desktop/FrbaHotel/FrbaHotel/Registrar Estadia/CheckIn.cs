using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaHotel.ABM_de_Cliente;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class CheckIn : Form, ITraeBusqueda
    {
        MenuPrincipal menu;
        string idCliente;
        string idHotel;
                
        public CheckIn(MenuPrincipal parent)
        {
            menu = parent;
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
                MessageBox.Show("No se pueden ver los datos. " + ex.Message,this.Text, MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    string comando = "SELECT * FROM FUGAZZETA.[ReservasModificables] WHERE Id_Reserva = " + TxtCodigo.Text + " AND Id_Hotel = " + menu.hotelActual;
                    SqlDataReader dr = bd.lee(comando);
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            string fechaKey = dr["Fecha_Inicio"].ToString().Substring(0, 10);
                            if (fechaKey != Program.hoy().ToShortDateString())
                            {
                                dr.Close();
                                throw new Exception("No se puede ingresar con ese código de reserva. Corresponde al día " + fechaKey + ".");
                            }
                            TxtId.Text = dr[0].ToString();
                            idCliente = dr[1].ToString();
                            idHotel = dr[2].ToString();
                            TxtHotel.Text = dr[2].ToString();
                            TxtFecReserva.Text = ifNull(dr["Fecha_Reserva"].ToString()).Substring(0, 10);
                            TxtFecInicio.Text = fechaKey;
                            TxtFecFin.Text = dr["Fecha_Fin_Reserva"].ToString().Substring(0, 10);
                            
                            SqlDataReader r2d2;
                            r2d2 = bd.lee("SELECT Descripcion FROM FUGAZZETA.Regimenes WHERE Id_Regimen = " + dr["Id_Regimen"].ToString());
                            while (r2d2.Read())
                                TxtRegimen.Text = r2d2[0].ToString();
                            r2d2.Close();
                        }
                    }
                    else
                    {
                        dr.Close();
                        throw new Exception("Esto puede ser por varios motivos: La reserva no existe, pertenece a otro hotel, se ha cancelado o ya realizó el ingreso.");
                    }
                    dr.Close();
                }
                catch (SqlException sqlEx)
                {
                    throw new Exception("Error " + sqlEx.Number  + " de SQL: " + sqlEx.Message);
                }

            }
        }

        private string ifNull(string p)
        {
            if (p == "") return ".................";
            else return p;
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
                    TxtPais.Text = reader[13].ToString();
                    TxtNac.Text = reader["Fecha_Nac"].ToString().Substring(0,10);
                    TxtMail.Text = reader[6].ToString();
                    TxtTelefono.Text = reader[7].ToString();
                    TxtDomicilio.Text = reader[8].ToString() + " " + reader[9].ToString() + " " + reader[10].ToString() + " " + reader[11].ToString();
                    TxtCiudad.Text = reader[12].ToString();
                    
                    SqlDataReader r2d2;
                    r2d2 = bd.lee("SELECT Descripcion FROM FUGAZZETA.TiposDoc WHERE Id_TipoDoc = " + reader[3].ToString());
                    while (r2d2.Read())
                        TxtDoc.Text = r2d2[0].ToString() + " " + reader[4].ToString();
                    r2d2 = bd.lee("SELECT Nombre FROM FUGAZZETA.Paises WHERE Id_Pais =" + reader["Nacionalidad"].ToString());
                    while (r2d2.Read())
                        TxtPais.Text = r2d2[0].ToString();
                    r2d2.Close();
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
            new ABM_de_Cliente.BuscarCliente(this, 'S').ShowDialog();
        }

        public void agregar(string id, string descripcion)
        {
            ListPersonas.Items.Add(new Cliente(id, descripcion));
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                VerDatos_Click(sender, e);

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void RealizarIngreso_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("¿Son todos los datos correctos? La reserva no podrá modificarse tras el ingreso.", "Confirmar Check in", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    BD bd = new BD();
                    bd.obtenerConexion();
                    bd.ejecutar("EXEC FUGAZZETA.RealizarIngreso " + TxtId.Text + ", '" + menu.usuarioActual + "', '" + Program.hoy() + "'");
                    for (int i = 0; i < ListPersonas.Items.Count; i++)
                    {
                        Cliente cliente = ListPersonas.Items[i] as Cliente;
                        bd.ejecutar("INSERT INTO FUGAZZETA.[Acompañantes] values ("+TxtId.Text + ", " + cliente.id + ")");
                    }
                    MessageBox.Show("Ingreso realizado con éxito.", "FRBA Hoteles");
                    this.Close();
                }
                catch (SqlException sql)
                {
                    confirmar = DialogResult.Cancel;
                    MessageBox.Show("No se pudo realizar la operación. Error " + sql.Number + ": " + sql.Message);
                }
            }

        }

    }
}
