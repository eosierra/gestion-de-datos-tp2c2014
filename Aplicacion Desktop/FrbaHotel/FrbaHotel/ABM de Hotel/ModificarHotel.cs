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
    public partial class ModificarHotel : Form, ITraeBusqueda
    {
        public ModificarHotel()
        {
            InitializeComponent();
        }

        private void ModificarHotel_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            FechaPick.MaxDate = Program.hoy();
            
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            new ABM_de_Hotel.BuscarHotel(this).ShowDialog();
            groupBox1.Enabled = true;
        }

        public void agregar(string id, string descripcion)
        {
            BD bd = new BD();
            bd.obtenerConexion();
            int elId = Convert.ToInt32(id);
            DataTable tabla = bd.ejecutar("SELECT * FROM FUGAZZETA.Hoteles WHERE Id_Hotel = " + elId);
            bindingSource1.DataSource = tabla;
            ///NO TENGO MUCHA IDEA COMO SEGUIR
        }

    }
}
