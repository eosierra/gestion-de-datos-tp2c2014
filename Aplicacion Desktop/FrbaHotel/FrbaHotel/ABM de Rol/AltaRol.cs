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

        private void CmdQuitar_Click(object sender, EventArgs e)
        {
            ListFunciones.Items.Remove(ListFunciones.SelectedItem);
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            new BuscarFuncionalidad(this).ShowDialog();
        }

        public void agregar(string id, string desc)
        {
            
        }

        #region ITraeBusqueda

        void ITraeBusqueda.agregar(string id, string descripcion)
        {
            ListFunciones.Items.Add(descripcion);
        }

        #endregion
    }
}
