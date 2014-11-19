using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaHotel.ABM_de_Hotel;
using FrbaHotel.ABM_de_Rol;

namespace FrbaHotel
{
    public partial class MenuPrincipal : Form, ITraeBusqueda
    {
        public string usuarioActual;
        public int hotelActual;
        public int rolActual;
        List<ToolStripMenuItem> menues = new List<ToolStripMenuItem>();
        List<ToolStripDropDownItem> items = new List<ToolStripDropDownItem>();

        public MenuPrincipal()
        {
            InitializeComponent();
            #region Carga y bloqueo de menues
            agregarMenu(RolesMenu);
            agregarMenu(UsuariosMenu);
            agregarMenu(ClientesMenu);
            agregarMenu(HabitacionesMenu);
            agregarMenu(HotelesMenu);
            agregarMenu(ReservasMenu);
            
            //bloquearMenues();
            #endregion
            abrirLogin();
            
        }

        private void abrirLogin()
        {
            usuarioActual = null;
            Login.FrmLogin elLogin = new Login.FrmLogin(this);
            elLogin.Text = elLogin.Text.ToUpper();
            DialogResult res = elLogin.ShowDialog();
            if (res == DialogResult.OK)
            {
                usuarioActual = elLogin.userActual;
                LabelSesion.Text = "Sesión iniciada como " + usuarioActual;
                if (usuarioActual != "guest")
                    LabelSesion.Text += ". Hotel: " + hotelActual + ". Rol: " + rolActual;
                bloquearMenues();
            }
            desbloquearMenues();
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
            form.ShowIcon = false;
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
            abrir(new ABM_de_Cliente.BuscarCliente(this,'M'));
        }

        private void AltaHabitacionMenu_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Habitacion.AltaHabitacion(hotelActual));
        }

        private void AltaHotelMenu_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Hotel.ModificarHotel('A',usuarioActual));
        }

        private void EditarHabitacionMenu_Click(object sender, EventArgs e)
        {
            abrir(new ABM_de_Habitacion.BuscarHabitacion(this,hotelActual));
        }
        #endregion

        #region ITraeBusqueda

        public void agregar(string id, string descripcion)
        {
        }

        #endregion

        private void bloquearMenues()
        {
            foreach (ToolStripDropDownItem item in items)
            {
                item.Visible = false;
                item.OwnerItem.Tag = 0;
            }
            foreach (ToolStripMenuItem menu in menues) menu.Visible = true;
        }

        private void desbloquearMenues()
        {
            BD bd = new BD();
            bd.obtenerConexion();
            SqlDataReader dr = bd.lee("EXEC FUGAZZETA.VerFuncionalidadesEnHotel '" + usuarioActual + "', " + hotelActual);
            while (dr.Read())
            {
               foreach (ToolStripDropDownItem item in items)
                {
                    if (item.Tag.ToString() == dr[1].ToString())
                    {
                        item.OwnerItem.Tag = 1;
                        item.Visible = true;
                    }
                }
            }
            dr.Close();
            bd.cerrar();
            foreach (ToolStripMenuItem m in menues)
                if (m.Tag.ToString() == "0") m.Visible = false;
        }

        private void agregarMenu(ToolStripMenuItem menu)
        {
            menu.Tag = 0;
            menues.Add(menu);
            foreach (ToolStripDropDownItem item in menu.DropDownItems) items.Add(item);
        }        
        
    }
}
