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
            bd.obtenerConexion();
            string comando = "SELECT Username,Contraseña FROM FUGAZZETA.[UsuariosHabilitados] WHERE Username='" + TxtUser.Text + "'";
            SqlDataReader tabla = bd.lee(comando);
            try
            {
                if (tabla.HasRows)
                {
                    tabla.Read();
                        string pass = tabla[1].ToString();
                        if (Hashing.SHA256Encrypt(TxtPass.Text) == pass)
                        {
                            userActual = TxtUser.Text;
                            LblError.Text = "";
                            bd.ejecutar("EXEC FUGAZZETA.LoginCorrecto '" + TxtUser.Text + "'");
                            tabla.Close();
                            LoginOK login = new LoginOK(this, menu);
                            login.StartPosition = FormStartPosition.CenterScreen;
                            if (login.ShowDialog() == DialogResult.OK)
                                IrAMenuPrincipal(userActual);
                        }
                        else
                        {
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
                    tabla.Close();
                }
                else throw new Exception("Usuario no encontrado o inhabilitado por el administrador.");
            }
            catch (Exception ex)
            {
                LblError.Visible = true;
                LblError.Text = ex.Message;
            }
            bd.cerrar();
            tabla.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IrAMenuPrincipal("guest");
            menu.hotelActual = 1;
            menu.rolActual = 4;
        }

        public void IrAMenuPrincipal(string elUser)
        {
            this.DialogResult = DialogResult.OK;
            userActual = elUser;
            this.Close();
        }

        private void Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) CmdIngresar_Click(sender, e);
        }

        
       }
} 
