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

        public FrmLogin()
        {
            InitializeComponent();
        }
       
        private void CmdIngresar_Click(object sender, EventArgs e)
        {
            //viejoLogin();
            BD bd = new BD();
            SqlConnection conexion = bd.obtenerConexion();
            string comando = "SELECT Username,Contraseña FROM FUGAZZETA.[UsuariosHabilitados] WHERE Username='" + TxtUser.Text + "'";
            DataTableReader tabla = new DataTableReader(bd.ejecutar(comando));
            try
            {
                if (tabla.HasRows)
                {
                    tabla.Read();
                    string pass = tabla[1].ToString();
                    if (TxtPass.Text == pass)
                    {
                        LblError.Text = "";
                        IrAMenuPrincipal(TxtUser.Text);
                        bd.ejecutar("EXEC FUGAZZETA.LoginCorrecto '" + TxtUser.Text + "'");
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
                }
                else
                {
                    throw new Exception("Usuario no encontrado o inhabilitado por el administrador");
                }
            }
            catch (Exception ex)
            {
                LblError.Visible = true;
                LblError.Text = ex.Message;
            }
            bd.cerrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IrAMenuPrincipal("guest");
        }

        private void IrAMenuPrincipal(string elUser)
        {
            userActual = elUser;
            this.Close();
        }

    }
} 
