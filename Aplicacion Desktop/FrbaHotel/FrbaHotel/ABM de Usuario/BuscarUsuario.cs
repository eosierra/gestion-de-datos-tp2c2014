using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FrbaHotel.ABM_de_Usuario
{
    public partial class BuscarUsuario : Buscador
    {
        string conCondicion;
        MenuPrincipal menu;

        public BuscarUsuario(MenuPrincipal owner)
        {
            InitializeComponent();
            menu = owner;
            conCondicion = " WHERE Username IN (SELECT Username FROM FUGAZZETA.[Usuarios x Hoteles x Rol] WHERE Id_Hotel = " + menu.hotelActual + ")"; 
            crearBuscador((owner as ITraeBusqueda),"Username,Nombre,Apellido,Id_TipoDoc,Nro_Doc,Mail,Telefono,Calle,NroCalle,Fecha_Nac,Habilitado","Usuarios" + conCondicion);
            setearGrid(GridUsuarios);
        }

        private void BuscarUsuario_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            cargarGrilla(GridUsuarios, todos);
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {
            actual = todos;
            addFiltroTextBox(TxtUser, "Username", GridUsuarios);
            cargarGrilla(GridUsuarios, actual);
            
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = celdaElegida(GridUsuarios, 0);
            DialogResult modif = new AltaUsuario('M', username).ShowDialog();
            if (modif == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
