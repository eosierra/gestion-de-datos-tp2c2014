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
                rellenarConsulta();
                cargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar el resultado. " + ex.Message, this.Text, MessageBoxButtons.OK);
            }
        }

        private void validarParametros()
        {
            if (CbListado.SelectedIndex == -1) throw new Exception("No seleccionó ningún listado.");
            if (CbPeriodo.SelectedIndex == -1) throw new Exception("No seleccionó ningún período.");
        }

        private void rellenarConsulta()
        {
            consulta = "SELECT TOP 5 ";
            int listado = Int16.Parse(CbListado.SelectedItem.ToString().Substring(0, 1));
            string periodo = "'" + (CbPeriodo.SelectedItem as Periodo).inicio() + "' and '" + (CbPeriodo.SelectedItem as Periodo).fin() + "'";
            switch (listado)
            {
                case 1:
                    consulta += @"Id_Hotel as Hotel,COUNT(*) as [Cantidad de Reservas Canceladas] FROM FUGAZZETA.Reservas
                                WHERE Id_EstadoReserva in (3,4,5) AND Fecha_Inicio between " + periodo + @"
                                GROUP BY Id_Hotel order by [Cantidad de Reservas Canceladas] desc";
                    break;
                case 2:
                    consulta += @"F.Id_Hotel as Hotel, SUM(I.Cantidad) as [Consumibles vendidos] FROM FUGAZZETA.Facturas F,FUGAZZETA.Items_Consumible I
                                WHERE F.NroFactura = I.NroFactura
                                AND Fecha between " + periodo + @"
                                GROUP BY F.Id_Hotel order by [Consumibles vendidos] desc";
                    break;
                case 3:
                    consulta += @"Id_Hotel as Hotel, SUM(DATEDIFF(D,Fecha_Inicio,Fecha_Fin)) as [Días sin Servicio] FROM FUGAZZETA.HistorialBajasHotel
                                WHERE Fecha_Inicio between " + periodo + " AND Fecha_Fin between " + periodo + " GROUP BY Id_Hotel";
                    break;
                case 4:
                    consulta += @"Id_Hotel as Hotel,Num_Habitacion as [Habitación], SUM(CantNochesOcupada) as [Total noches ocupada],
                                COUNT(*) as [Veces ocupada] FROM FUGAZZETA.HistorialHabitaciones
                                WHERE FechaOcupacion between " + periodo + @" 
                                group by Id_Hotel,Num_Habitacion ORDER BY 3 DESC,4 DESC";
                    break;
                case 5:
                    consulta += @"F.Id_Cliente as ID, C.Apellido, C.Nombre, SUM(FUGAZZETA.PuntosFactura(F.NroFactura)) as [Puntos]
                                FROM FUGAZZETA.Facturas F, FUGAZZETA.Clientes C
                                WHERE Fecha between " + periodo + @"
                                AND F.Id_Cliente = C.Id_Cliente
                                group by F.Id_Cliente, C.Apellido, C.Nombre ORDER BY Puntos DESC";
                    break;
            }
        }

        private void cargarGrilla()
        {
            GridResults.DataSource = "";
            this.Cursor = Cursors.WaitCursor;
            BD bd = new BD();
            bd.obtenerConexion();
            GridResults.DataSource = bd.ejecutar(consulta);
            this.Cursor = Cursors.Default;
        }
    }
}
