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
    public partial class LoginOK : Form
    {
        private FrmLogin parent;
        private MenuPrincipal menu;

        public LoginOK(FrmLogin login, MenuPrincipal menu)
        {
            InitializeComponent();
        }

        private void LoginOK_Load(object sender, EventArgs e)
        {
            CbHoteles.Items.Clear();
            string query = "SELECT Id_Hotel,Id_Rol FROM FUGAZZETA.[Usuarios x Hoteles x Rol] WHERE Username = '" + parent.userActual + "'";
            BD bd = new BD();
            bd.obtenerConexion();
            SqlDataReader dr = bd.lee(query);
            while (dr.Read()) CbHoteles.Items.Add(new HotelxRol(dr[0].ToString(), dr[1].ToString()));
        }
    }
}
