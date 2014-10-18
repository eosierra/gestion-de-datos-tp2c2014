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
        public MenuPrincipal()
        {
            InitializeComponent();
            abrirLogin();
        }

        private static void abrirLogin()
        {
            new Login.FrmLogin().ShowDialog();
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

        private void abrir(Form form)
        {
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();

        }

        ITraeBusqueda interfaz;

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
    }
}
