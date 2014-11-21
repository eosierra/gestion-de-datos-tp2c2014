using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.Cancelar_Reserva
{
    public partial class CancelarReserva : Form
    {
        MenuPrincipal menu;
        public CancelarReserva(MenuPrincipal parent)
        {
            menu = parent;
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            string codigo = TxtCodigo.Text;
            DialogResult confirma = MessageBox.Show("Está seguro de cancelar la reserva ID:" + codigo + "?",this.Text,MessageBoxButtons.OKCancel);
                if (confirma == DialogResult.OK)
            {
                try
                {
                    BD bd = new BD();
                    bd.obtenerConexion();
                    validarReserva(bd);
                    validarContraseña(bd);
                    cancelar(bd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo realizar la baja. " + ex.Message, "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Retry;
                }
            }

        }

        private void cancelar(BD bd)
        {
            string query = "EXEC FUGAZZETA.CancelarReserva " + TxtCodigo.Text + ", '" + menu.usuarioActual + "', '" + Program.ahora().ToString() + "', '" + TxtMotivo.Text + "'";
            bd.ejecutar(query);
            MessageBox.Show("La reserva se ha cancelado con éxito.");
            this.Close();
        }

        private void validarContraseña(BD bd)
        {
            if (menu.usuarioActual != "guest")
            {
                if (TxtPass.Text == "")
                {
                    throw new Exception("Debe completar una contraseña. ");
                }
                string query = "SELECT Contraseña FROM FUGAZZETA.Usuarios WHERE Username = '" + menu.usuarioActual + "'";
                SqlDataReader dr = bd.lee(query);
                while (dr.Read())
                {
                    if (dr[0].ToString() != Hashing.SHA256Encrypt(TxtPass.Text))
                    {
                        dr.Close();
                        throw new Exception("La contraseña es incorrecta.");
                    }
                }
                dr.Close();
            }
        }

        private void validarReserva(BD bd)
        {
            if (TxtCodigo.Text == "")
            {
                throw new Exception("No ingresó ningún código de reserva.");
            }
            else
            {
                string condicion = "";
                if (menu.usuarioActual != "guest")
                {
                    condicion = " AND Id_Hotel = " + menu.hotelActual;
                }
                string query = "SELECT * FROM FUGAZZETA.ReservasNoCanceladas WHERE Id_Reserva = " + TxtCodigo.Text + condicion;
                SqlDataReader dr = bd.lee(query);
                if (!dr.HasRows)
                {
                    dr.Close();
                    throw new Exception("La reserva que intenta cancelar no existe, pertenece a otro hotel o ya fue cancelada.");
                }
                dr.Close();
            }
        }

        private void CancelarReserva_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = !(menu.usuarioActual == "guest");
        }


        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
