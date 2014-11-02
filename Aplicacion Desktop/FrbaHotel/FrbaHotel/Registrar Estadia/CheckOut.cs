using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class CheckOut : Form
    {
        MenuPrincipal parent;

        public CheckOut(MenuPrincipal mp)
        {
            parent = mp;
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {

        }
    }
}
