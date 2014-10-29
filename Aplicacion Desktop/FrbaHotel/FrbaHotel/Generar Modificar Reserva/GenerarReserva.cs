﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class GenerarReserva : Form, ITraeBusqueda
    {
        int nBuscador;

        public GenerarReserva()
        {
            InitializeComponent();
            DesdePick.MinDate = Program.hoy();
            HastaPick.MinDate = Program.hoy();
        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {
            groupCliente.Enabled = true;
            group3.Enabled = false;
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

        private void CancelarTodo_Click(object sender, EventArgs e)
        {
            /*
             * CANCELAR TODO
             */
            this.Close();
        }

        private void BuscarCliente_Click(object sender, EventArgs e)
        {
            nBuscador = 1;
            DialogResult sigue = new ABM_de_Cliente.BuscarCliente(this).ShowDialog();
            if (sigue == DialogResult.OK)
            {
                group3.Enabled = true;
            }
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
            BD db = new BD();
            db.obtenerConexion();
            SqlDataReader reader;
            string query;
            switch (nBuscador)
            {
                case 1:
                    query = "SELECT * FROM FUGAZZETA.Clientes WHERE Id_Cliente = " + id;
                    reader = db.lee(query);
                    while (reader.Read())
                    {
                        TxtNombre.Text = reader[1].ToString() + " " + reader[2].ToString();
                        TxtDoc.Text = reader[3].ToString() + " " + reader[4].ToString();
                        TxtPais.Text = reader[13].ToString();
                        TxtNac.Text = reader[5].ToString().Substring(0, 10);
                        TxtMail.Text = reader[6].ToString();
                        TxtTelefono.Text = reader[7].ToString();
                        TxtDomicilio.Text = reader[8].ToString() + " " + reader[9].ToString() + " " + reader[10].ToString() + " " + reader[11].ToString();
                        TxtCiudad.Text = reader[12].ToString();
                    }
                    reader.Close();
                    break;
            }
        }

        #endregion
    }
}
