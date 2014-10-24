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
    public partial class BajaHotel : Form
    {
        public BajaHotel(int id)
        {
            InitializeComponent();
            HastaPick.MinDate = Program.hoy();
        }

        private void BajaHotel_Load(object sender, EventArgs e)
        {

        }
    }
}
