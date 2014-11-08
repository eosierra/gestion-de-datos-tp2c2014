using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            #region Carga y bloqueo de menues
            menues.Add(RolesMenu);
            menues.Add(UsuariosMenu);
            menues.Add(ClientesMenu);
            menues.Add(HotelesMenu);
            menues.Add(ReservasMenu);

            bloquearMenues();
            #endregion

        }

        private void abrirLogin()
        {
            usuarioActual = null;
            Login.FrmLogin elLogin = new Login.FrmLogin();
            elLogin.Text = elLogin.Text.ToUpper();
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
            abrir(new ABM_de_Cliente.BuscarCliente(this));
        }

        #endregion

        #region ITraeBusqueda

        public void agregar(string id, string descripcion)
        {
        }

        #endregion

        private void bloquearMenues()
        {
            foreach (ToolStripMenuItem m in menues)
            {
                m.Visible = true;
                foreach (ToolStripDropDownItem item in m.DropDownItems)
                    item.Visible = false;
            }
        }

        private void desbloquearMenues()
        {
            BD bd = new BD();
            bd.obtenerConexion();
            SqlDataReader dr = bd.lee("EXEC FUGAZZETA.VerFuncionalidadesEnHotel '" + usuarioActual + "', " + hotelActual);
            while (dr.Read())
            {
                foreach (ToolStripMenuItem m in menues)
                {
                    foreach (ToolStripDropDownItem item in m.DropDownItems)
                        if (item.Tag.ToString() == dr[1].ToString()) item.Visible = true;
                }
            }
            dr.Close();
            foreach (ToolStripMenuItem m in menues)
            {
                int count = 0;
                for (int i = 0; i < m.DropDownItems.Count; i++)
                    if (m.DropDownItems[i].Visible) count++;
                if (count == 0) m.Visible = false;
            }              
        }
    }
}
