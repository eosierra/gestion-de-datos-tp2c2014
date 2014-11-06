using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Listado_Estadistico
{
    public partial class Estadistica : Form
    {
        string consulta;

        public Estadistica()
        {
            InitializeComponent();
            CbPeriodo.Items.Add(new Periodo(1, 3, 2013));
            CbPeriodo.Items.Add(new Periodo(4, 6, 2013));
        }

        private void VerDatos_Click(object sender, EventArgs e)
        {
            try
            {
                validarParametros();
                //rellenarConsulta();
                //cargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar el resultado. " + ex.Message);
            }
        }

        private void validarParametros()
        {
            if (CbPeriodo.SelectedIndex == -1) throw new Exception("No seleccionó ningún período.");
            if (CbListado.SelectedIndex == -1) throw new Exception("No seleccionó ningún listado.");
        }
    }
}
