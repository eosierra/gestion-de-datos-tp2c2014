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
    public partial class AltaRol : Form
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
    }
}
