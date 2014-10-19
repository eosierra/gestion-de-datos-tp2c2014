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
        public BuscarUsuario(ITraeBusqueda owner)
        {
            InitializeComponent();
            crearBuscador(owner,"Username,Nombre,Apellido,Tipo_Doc,Nro_Doc,Mail,Telefono,Calle,NroCalle,Fecha_Nac","Usuarios");
            setearGrid(GridUsuarios);
        }

        private void BuscarUsuario_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            cargarGrilla(GridUsuarios, todos);
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {
            addFiltroTextBox(TxtUser, "Username", GridUsuarios);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
