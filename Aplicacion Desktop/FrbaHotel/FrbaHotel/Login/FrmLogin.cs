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
        public FrmLogin()
        {
            InitializeComponent();
        }
       
        private void CmdIngresar_Click(object sender, EventArgs e)
        {
            //viejoLogin();
            BD bd = new BD();
            SqlConnection conexion = bd.obtenerConexion();
            string comando = "SELECT Username,Contraseña FROM FUGAZZETA.Usuarios WHERE Username='" + TxtUser.Text + "'";
            DataTableReader tabla = new DataTableReader(bd.ejecutar(comando));
            try
            {
                if (tabla.HasRows)
                {
                    tabla.Read();
                    string pass = tabla.GetValue(1).ToString();
                    if (TxtPass.Text == pass)
                    {
                        LblError.Text = "";
                        MessageBox.Show("LOGIN CORRECTO");
                        //bd.cerrar();
                    }
                    else
                    {
                        throw new Exception("Contraseña incorrecta");
                    }
                }
                else
                {
                    throw new Exception("Usuario no encontrado");
                }
            }
            catch (Exception ex)
            {
                LblError.Visible = true;
                LblError.Text = ex.Message;
            }
            bd.cerrar();
        }

        private void viejoLogin()
        {
            BD bd = new BD();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "FUGAZZETA.ValidarLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;
            cmd.Parameters.AddWithValue("USER2", TxtUser.Text);
            cmd.Parameters.AddWithValue("PASS2", TxtPass.Text);

            try
            {
                Int32 reader = cmd.ExecuteNonQuery();
                bd.cerrar();
            }
            catch (SqlException ex)
            {
                LblError.Text = ex.Number.ToString();
            }
            MessageBox.Show("Login correcto");
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //de prueba
            new ABM_de_Rol.BuscarRol(this).Show();
        }

    }
}
