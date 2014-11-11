﻿using System;
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

        public LoginOK(FrmLogin login, MenuPrincipal mp)
        {
            parent = login;
            menu = mp;
            InitializeComponent();
        }

        private void LoginOK_Load(object sender, EventArgs e)
        {
            CbHoteles.Items.Clear();
            string query = "SELECT UHR.Id_Hotel,UHR.Id_Rol FROM FUGAZZETA.Roles R, FUGAZZETA.[Usuarios x Hoteles x Rol] UHR WHERE R.Id_Rol=UHR.Id_Rol AND R.Estado=1 AND UHR.Username = '" + parent.userActual + "'";
            BD bd = new BD();
            bd.obtenerConexion();
            SqlDataReader dr = bd.lee(query);
            while (dr.Read()) CbHoteles.Items.Add(new HotelxRol(dr[0].ToString(), dr[1].ToString()));
            dr.Close();
            bd.cerrar();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (CbHoteles.SelectedIndex != -1)
            {
                HotelxRol elegido = (CbHoteles.SelectedItem as HotelxRol);
                menu.hotelActual = elegido.hotel.id;
                menu.rolActual = elegido.rol.id;
                this.Close();
            }
            else
            {
                MessageBox.Show("No eligió ningún hotel para loguearse.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Retry;
            }
        }
    }
}