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
            cargarPeriodos(2013,2016);
        }

        private void cargarPeriodos(int inicio, int fin)
        {
            for (int año = inicio; año <= fin; año++)
            {
                for (int mes = 1; mes < 13; mes += 3)
                {
                    CbPeriodo.Items.Add(new Periodo(mes, mes + 2, año));
                }
            }
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
