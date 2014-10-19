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
    public partial class AltaRol : Form,ITraeBusqueda
    {
        public AltaRol()
        {
            InitializeComponent();
        }

        #region Botones
        private void CmdQuitar_Click(object sender, EventArgs e)
        {
            ListFunciones.Items.Remove(ListFunciones.SelectedItem);
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            new BuscarFuncionalidad(this).ShowDialog();

        }

        private void LimpiarTodo_Click(object sender, EventArgs e)
        {
            TxtRol.Text = "";
            ListFunciones.Items.Clear();
            CheckActivo.Checked = false;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                validaRol();
                validaFunciones();
                agregaRol();
                MessageBox.Show("Rol agregado con éxito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        void ITraeBusqueda.agregar(string id, string descripcion)
        {
            bool sePuede = true;
            bool sigue = true;
            for (int i = 0; (i < ListFunciones.Items.Count - 1) && sigue; i++)
            {
                if (ListFunciones.Items[i].ToString() == descripcion)
                {
                    sigue = false;
                    sePuede = false;
                }
            }
            if (!sePuede)
            {
                MessageBox.Show("No se puede agregar. Ya agregó esa funcionalidad");
            } else {
                ListFunciones.Items.Add(new Funcionalidad(id, descripcion));
            }
        }
        
        private void validaFunciones()
        {
            if (ListFunciones.Items.Count == 0)
            {
                throw new Exception("El rol tiene que tener al menos una funcionalidad");
            }
        }

        private void validaRol()
        {
            if (TxtRol.Text == "")
            {
                throw new Exception("El nombre del rol no puede ser vacío");
            }
        }

        private void agregaRol()
        {
            BD bd = new BD();
            bd.obtenerConexion();
            string valores = "'" + TxtRol.Text + "', " + Convert.ToSByte(CheckActivo.Checked);
            bd.insertar("Roles",valores);       
            
            DataTable laTabla = bd.ejecutar("SELECT * FROM FUGAZZETA.Roles where Nombre like '" + TxtRol.Text + "'");
            
            string idRol = laTabla.Rows[0][0].ToString();

            for (int i = 0; i < ListFunciones.Items.Count-1; i++)
            {
                Funcionalidad func = ListFunciones.Items[i] as Funcionalidad;
                bd.insertar("[Funcionalidades x Roles]", func.id + ", " + idRol);
            }

        }

    }
}
