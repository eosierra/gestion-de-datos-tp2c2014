using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Cancelar_Reserva;

namespace FrbaHotel.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // SOLO PARA TESTEAR QUE ANDA BIEN EL FRM CANCELAR RESERVA
            FrmCancelarReserva formu = new FrmCancelarReserva();
            formu.Show();
        }

    }
}
