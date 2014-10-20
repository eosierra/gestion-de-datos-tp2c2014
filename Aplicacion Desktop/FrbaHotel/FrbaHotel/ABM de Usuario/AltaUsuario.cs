using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ABM_de_Rol;
using System.Data.SqlClient;

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class AltaUsuario : Form, ITraeBusqueda
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            Calendario.MaxDate = Program.hoy();

        }
        #region Botones
        private void AgregarRol_Click_1(object sender, EventArgs e)
        {
            new BuscarRol(this).ShowDialog();
        }

        private void QuitarRol_Click(object sender, EventArgs e)
        {
            ListaRoles.Items.Remove(ListaRoles.SelectedItem);
        }

        private void LinkValida_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            validarUser();
        }

        private void LimpiarPantalla_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Está seguro de borrar todos los datos?", "Nuevo Usuario", MessageBoxButtons.OKCancel);
            if (confirma == DialogResult.OK)
            {
                TxtUser.Text = "";
                TxtPass1.Text = "";
                TxtPass2.Text = "";
                ListaRoles.Items.Clear();
                LblError1.Text = "";



            }
        }

        #endregion

        private void validarContraseñas(object sender, EventArgs e)
        {
            if (TxtPass1.Text != TxtPass2.Text)
            {
                LblError1.Text = "Las contraseñas no coinciden";
            }
            else
            {
                LblError1.Text = "";
            }
        }

        private void validarUser()
        {
            if (TxtUser.Text != "")
            {
                BD bd = new BD();
                SqlConnection conexion = bd.obtenerConexion();
                string comando = "SELECT Username,Contraseña FROM FUGAZZETA.Usuarios WHERE Username='" + TxtUser.Text + "'";
                DataTableReader tabla = new DataTableReader(bd.ejecutar(comando));
                if (!tabla.HasRows)
                {
                    MessageBox.Show("El nombre de usuario está disponible");
                }
                else { LblError1.Text = "El usuario ya existe"; }
            }
            else
            {
                LblError1.Text = "El usuario debe tener al menos un caracter";
            }
        }

        public void agregar(string id, string descripcion)
        {
            ListaRoles.Items.Add(new Funcionalidad(id,descripcion));
        }

    }
}
