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
       
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void CmdIngresar_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "FUGAZZETA.ValidarLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;
            cmd.Parameters.AddWithValue("USER2",TxtUser.Text);
            cmd.Parameters.AddWithValue("PASS2",TxtPass.Text);
            
            try
            {
                Int32 reader = cmd.ExecuteNonQuery();
                bd.cerrar();
            } catch (SqlException ex)
            {
                LblError.Text = ex.Number.ToString();
            }
            MessageBox.Show("Login correcto");

        }

    }
}
