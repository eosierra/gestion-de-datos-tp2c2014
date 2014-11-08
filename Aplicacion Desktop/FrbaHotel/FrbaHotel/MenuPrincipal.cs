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
    public partial class MenuPrincipal : Form, ITraeBusqueda
    {
        public string usuarioActual;
        public int hotelActual;
        public int rolActual;
        List<ToolStripMenuItem> menues = new List<ToolStripMenuItem>();

        public MenuPrincipal()
        {
            InitializeComponent();
            while (usuarioActual == null) abrirLogin();
            #region Carga de menues
            menues.Add(RolesMenu);
            menues.Add(UsuariosMenu);
            menues.Add(ClientesMenu);
            menues.Add(HotelesMenu);
            menues.Add(ReservasMenu);
            #endregion

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
            form.Text = ("FRBA Hoteles - " + textoActual).ToUpper();
            form.Show();
            
        }

        private void nuevoUsuarioMenu_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Usuario.AltaUsuario());
        }

        private void cerrarSesiónMenu_Click(object sender, EventArgs e)
        {
            abrirLogin();
        }

        private void nuevoRolMenu_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Rol.AltaRol('A'));
        }

        private void modificarRolMenu_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Rol.BuscarRol(null,'M'));
        }

        private void modificarUsuarioMenu_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Usuario.BuscarUsuario(this));
        }

        private void eliminarUsuarioMenu_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Usuario.BuscarUsuario(this));
        }

        private void realizarNuevaReservaMenu_Click(object sender, EventArgs e)
        {
            abrir(new Generar_Modificar_Reserva.GenerarReserva(this));
        }

        private void editarReservaMenu_Click(object sender, EventArgs e)
        {
            abrir(new Generar_Modificar_Reserva.ModificarReserva(this));
        }

        private void modificarHotelMenu_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Hotel.ModificarHotel());
        }

        private void cancelarReservaMenu_Click(object sender, EventArgs e)
        {
            abrir(new Cancelar_Reserva.CancelarReserva(this));
        }

        private void checkInMenu_Click(object sender, EventArgs e)
        {
            abrir(new Registrar_Estadia.CheckIn(this));
        }

        private void checkOutMenu_Click(object sender, EventArgs e)
        {
            abrir(new Registrar_Estadia.CheckOut(this));
        }

        private void estadísticasMenu_Click(object sender, EventArgs e)
        {
            abrir(new Listado_Estadistico.Estadistica());
        }

        private void EditarClienteMenu_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Cliente.BuscarCliente(this));
        }

        #endregion

        #region ITraeBusqueda

        public void agregar(string id, string descripcion)
        {
        }

        #endregion


    }
}
