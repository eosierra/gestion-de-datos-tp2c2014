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
        public string usuarioActual;

        public MenuPrincipal()
        {
            InitializeComponent();
            while (usuarioActual == null)
            {
                abrirLogin();
            }
        }

        private void abrirLogin()
        {
            usuarioActual = null;
            Login.FrmLogin elLogin = new Login.FrmLogin();
            elLogin.ShowDialog();
            usuarioActual = elLogin.userActual;
            LabelSesion.Text = "Sesión iniciada como " + usuarioActual;
        }

        #region Abrir Menues
        
        private void abrir(Form form)
        {
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            string textoActual = form.Text;
            form.Text = "FRBA Hoteles - " + textoActual;
            form.Show();
            
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

        private void modificarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Rol.BuscarRol(null));
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
            abrir(new Generar_Modificar_Reserva.GenerarReserva(this));
        }

        private void modificarHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Hotel.ModificarHotel());
        }

        private void cancelarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir(new Cancelar_Reserva.CancelarReserva(this));
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir(new Registrar_Estadia.CheckIn(this));
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir(new Registrar_Estadia.CheckOut(this));
        }

        private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir(new Listado_Estadistico.Estadistica());
        }

        #endregion

        ITraeBusqueda interfaz;


        //esto habrá que sacarlo después

    }
}
