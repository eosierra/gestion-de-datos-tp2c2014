using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Cancelar_Reserva
{
    public partial class FrmCancelarReserva : Form
    {
        public FrmCancelarReserva()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodReserva.Text;
            DialogResult confirma = MessageBox.Show("Está seguro de cancelar la reserva " + codigo + "?","Cancelar Reservaaaaaaaa",MessageBoxButtons.OKCancel);
                if (confirma == DialogResult.OK)
            {
                /*
                 * REALIZARA LA CANCELACION....
                 */
                    MessageBox.Show("La reserva se ha cancelado con éxito");
            }

        }

    }
}
