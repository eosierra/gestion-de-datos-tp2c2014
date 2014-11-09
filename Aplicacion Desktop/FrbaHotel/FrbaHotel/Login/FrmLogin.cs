using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.Login
{
    public partial class FrmLogin : Form
    {
        public string userActual;
        private MenuPrincipal menu;

        public FrmLogin(MenuPrincipal parent)
        {
            menu = parent;
            InitializeComponent();
        }
       
        private void CmdIngresar_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            SqlConnection conexion = bd.obtenerConexion();
            string comando = "SELECT Username,Contraseña FROM FUGAZZETA.[UsuariosHabilitados] WHERE Username='" + TxtUser.Text + "'";
            DataTableReader tabla = new DataTableReader(bd.ejecutar(comando));
            try
            {
                if (tabla.HasRows)
                {
                    while (tabla.Read())
                    {
                        string pass = tabla[1].ToString();
                        if (TxtPass.Text == pass)
                        {
                            userActual = TxtUser.Text;
                            LblError.Text = "";
                            bd.ejecutar("EXEC FUGAZZETA.LoginCorrecto '" + TxtUser.Text + "'");
                            tabla.Close();
                            DialogResult sigue = new LoginOK(this, menu).ShowDialog();
                            if (sigue == DialogResult.OK) IrAMenuPrincipal(TxtUser.Text);
                        }
                        else
                        {
                            tabla.Close();
                            try
                            {
                                bd.ejecutar("EXEC FUGAZZETA.LoginIncorrecto '" + TxtUser.Text + "'");
                                throw new Exception("Contraseña incorrecta");
                            }
                            catch (SqlException ex)
                            {
                                throw (ex as Exception);
                            }
                        }
                    }
                    tabla.Close();
                }
                else throw new Exception("Usuario no encontrado o inhabilitado por el administrador.");
            }
            catch (Exception ex)
            {
                tabla.Close();
                LblError.Visible = true;
                LblError.Text = ex.Message;
            }
            bd.cerrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IrAMenuPrincipal("guest");
            menu.hotelActual = 1;
            menu.rolActual = 4;
        }

        public void IrAMenuPrincipal(string elUser)
        {
            userActual = elUser;
            this.Close();
        }

        private void Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) CmdIngresar_Click(sender, e);
        }

    }
} 
