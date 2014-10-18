using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class ModificarReserva : Form
    {
        public ModificarReserva()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            /*
             * SI LO ENCUENTRA...
             */
            groupBox1.Enabled = true;
        }
    }
}
