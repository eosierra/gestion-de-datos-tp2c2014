using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class AltaRol : Buscador,ITraeBusqueda
    {
        public AltaRol(char fun,string id,string nom)
        {
            InitializeComponent();
            funcion = fun;
            agregar(id, nom);
        }

        public AltaRol(char fun)
        {
            InitializeComponent();
            funcion = fun;
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
            if (funcion=='A'){

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
            if (funcion=='M'){
                this.Close();
                //TODO Agregar comportamiento de Modificacion acá.... Falta cargarle los datos
            }
        }
        #endregion

        public void agregar(string id, string descripcion)
        {
            if (funcion=='A'){
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
            if (funcion=='M'){
                ListFunciones.Items.Clear();
                BD bd = new BD();
                bd.obtenerConexion();
                int elId = Convert.ToInt32(id);
                string query = "SELECT * FROM FUGAZZETA.Roles WHERE Id_Rol = " + elId;
                SqlDataReader dr = bd.lee(query);

                while (dr.Read())
                {
                    TxtRol.Text = dr["Nombre"].ToString();
                    CheckActivo.Checked = Convert.ToBoolean(dr["Estado"].ToString());
                }
                dr.Close();


                query = "SELECT FR.Id_Rol,FR.Id_Funcionalidad, F.Descripcion FROM FUGAZZETA.[Funcionalidades x Roles] FR, FUGAZZETA.Funcionalidades F where FR.Id_Funcionalidad = F.Id_Funcionalidad AND FR.Id_Rol = " + elId;
                dr = bd.lee(query);
                while (dr.Read())
                {
                    ListFunciones.Items.Add(new Funcionalidad(dr[1].ToString(), dr[2].ToString()));
                }
                bd.cerrar();
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
