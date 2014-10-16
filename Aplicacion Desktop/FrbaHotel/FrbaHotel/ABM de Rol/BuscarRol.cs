using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class BuscarRol : Form
    {
        string todoslosRoles = "SELECT Id_Rol,Nombre FROM FUGAZZETA.ROLES";
        BD bd = new BD();
        Form dondeVuelve;

        public BuscarRol(Form owner)
        {
            dondeVuelve = owner;
            InitializeComponent();
        }

        private void BuscarRol_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            cargarGrilla(todoslosRoles);
            
        }

        private void cargarGrilla(string condicion)
        {
            //bd.obtenerConexion();
            GridRoles.DataSource = bd.ejecutar(condicion);
            bd.cerrar();
        }

        private void TxtRol_TextChanged(object sender, EventArgs e)
        {
            if (TxtRol.Text != "")
            {
                string condicionNueva = todoslosRoles + " WHERE Nombre like '%" + TxtRol.Text + "%'";
                cargarGrilla(condicionNueva);
            }
            else { cargarGrilla(todoslosRoles); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = GridRoles.CurrentRow.Cells[0].Value.ToString();
            string name = GridRoles.CurrentRow.Cells[1].Value.ToString();
            Rol rol = new Rol(id, name);
            //dondeVuelve.agregarRol(rol);
            this.Close();
        }
    }
}
