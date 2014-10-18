using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class ModificarHotel : ITraeBusqueda
    {
        public ModificarHotel()
        {
            InitializeComponent();
        }

        private void ModificarHotel_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            new ABM_de_Hotel.BuscarHotel(this).ShowDialog();
            groupBox1.Enabled = true;
        }

    }
}
