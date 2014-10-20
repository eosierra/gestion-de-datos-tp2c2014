using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class MenuPrincipal : Form
    {
        string usuarioActual;

        public MenuPrincipal()
        {
            InitializeComponent();
            abrirLogin();
        }

        private void abrirLogin()
        {
            Login.FrmLogin elLogin = new Login.FrmLogin();
            elLogin.ShowDialog();
            usuarioActual = elLogin.userActual;
            LabelSesion.Text = "Sesión iniciada como " + usuarioActual;
            completarHotelesSesion();
        }

        #region Abrir Menues
        
        private void abrir(Form form)
        {
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            HotelesSesion.Enabled = false;

        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Usuario.AltaUsuario());
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirLogin();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirLogin();
        }

        private void nuevoRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Rol.AltaRol());
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Usuario.BuscarUsuario(interfaz));
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Usuario.BuscarUsuario(interfaz));
        }

        private void realizarNuevaReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir(new Generar_Modificar_Reserva.GenerarReserva());
        }

        #endregion

        ITraeBusqueda interfaz; //esto habrá que sacarlo después

        private void completarHotelesSesion()
        {
            HotelesSesion.Items.Clear();
            BD bd = new BD();
            bd.obtenerConexion();
            string tabla = "[Usuarios x Hoteles] U, FUGAZZETA.Hoteles H WHERE U.Id_Hotel = H.Id_Hotel AND U.Username like '" + usuarioActual + "'";
            bd.rellenarDesde("H.Calle", tabla, HotelesSesion);
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void modificarHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Hotel.ModificarHotel());
        }

    }
}
