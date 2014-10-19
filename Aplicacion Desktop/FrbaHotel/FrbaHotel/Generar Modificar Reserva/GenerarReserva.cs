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
    public partial class GenerarReserva : Form, ITraeBusqueda
    {
        public GenerarReserva()
        {
            InitializeComponent();
            DesdePick.MinDate = Program.hoy();
            HastaPick.MinDate = Program.hoy();
        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {
            group1.Enabled = true;
            group2.Enabled = false;
            group3.Enabled = false;
            PasoAtras.Enabled = false;
        }

        #region Validar Reservas
        private bool reservaValida()
        {
            return (DesdePick.Value < HastaPick.Value);
        }

        private void revalidarReserva(object sender, EventArgs e)
        {
            if (!reservaValida())
            {
                DateTime desde = DesdePick.Value;
                HastaPick.MinDate = new DateTime(desde.Year, desde.Month, desde.Day + 1);
            }
        }
        #endregion

        private void PasoAtras_Click(object sender, EventArgs e)
        {
            if (group2.Enabled)
            {
                group2.Enabled = false;
                group1.Enabled = true;
                PasoAtras.Enabled = false;
            }
            if (group3.Enabled) { group3.Enabled = false; group2.Enabled = true; }
        }

        private void CancelarTodo_Click(object sender, EventArgs e)
        {
            /*
             * CANCELAR TODO
             */
            this.Close();
        }

        private void siguiente(GroupBox grupo)
        {
            if (grupo == group1)
            {
                group1.Enabled = false;
                group2.Enabled = true;
                PasoAtras.Enabled = true;
            }
            if (grupo == group2)
            {
                group1.Enabled = false;
                group2.Enabled = false;
                group3.Enabled = true;
                PasoAtras.Enabled = true;
            }
        }

        private void NuevoCliente_Click(object sender, EventArgs e)
        {
            /*
             * AGREGA CLIENTE NUEVO
             */
            siguiente(group1);
        }

        private void BuscarCliente_Click(object sender, EventArgs e)
        {
            new ABM_de_Cliente.BuscarCliente(this).ShowDialog();
            /*
             * BUSCA AL CLIENTE
             */
            siguiente(group2);
        }

        private void Reservar_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Son todos los datos correctos?", "Nueva reserva", MessageBoxButtons.OKCancel);
            if (confirma == DialogResult.OK)
            {
                /*
                 * VALIDA LA RESERVA Y LA GENERA EN TODO CASO
                 */
                MessageBox.Show("La reserva se ha realizado con éxito. Su código de reserva es: ...... Conserve este código al momento de realizar el ingreso y el egreso del hotel.","Nueva Reserva");
                this.Close();
            }


        }

        #region ITraeBusqueda Members

        void ITraeBusqueda.agregar(string id, string descripcion)
        {

        }

        #endregion
    }
}
