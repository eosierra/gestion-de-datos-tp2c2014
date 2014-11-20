using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaHotel.ABM_de_Hotel;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class AltaHabitacion : Buscador, ITraeBusqueda
    {
        string tuId;
        int tuHotel;

        public AltaHabitacion(char fun,string id,int hotel)
        {
            InitializeComponent();
            cargarCombos();
            funcion = fun;
            tuHotel=hotel;
            tuId=id;
            cargar();
            CmbTipo.Enabled = false;
        }

           
        public AltaHabitacion(int hotel)
        {
            InitializeComponent();
            cargarCombos();
            tuHotel = hotel;
        }

        private void cargarCombos()
        {
            CmbTipo.Items.Clear();

            BD bd = new BD();
            bd.obtenerConexion();
            
            string query = "SELECT * FROM FUGAZZETA.TiposHabitacion ORDER BY Id_TipoHab";
            SqlDataReader dr = bd.lee(query);
            while (dr.Read())
            {
                TipoHabitacion tipo = new TipoHabitacion(dr[0].ToString(), dr[1].ToString());
                CmbTipo.Items.Add(tipo);
            }
            dr.Close();

            query = "SELECT Id_Hotel, Nombre FROM FUGAZZETA.Hoteles ORDER BY Id_Hotel";
            dr = bd.lee(query);
            while (dr.Read())
            {
                Hotel hotel = new Hotel(dr[0].ToString(), dr[1].ToString());
                CmbHotel.Items.Add(hotel);
            }
            dr.Close();

        }

        private void cargar()
        {
            if (funcion == 'M')
            {
                BD bd = new BD();
                bd.obtenerConexion();
                int elId = Convert.ToInt32(tuId);
                string query = "SELECT * FROM FUGAZZETA.Habitaciones WHERE Num_Habitacion = " + elId + " and Id_Hotel = " + tuHotel;
                SqlDataReader dr = bd.lee(query);

                while (dr.Read())
                {
                    TxtNro.Text = dr["Num_Habitacion"].ToString();
                    TxtPiso.Text = dr["Piso"].ToString();
                    TxtDesc.Text = dr["Comodidades"].ToString();
                    
                    string frente = dr["Frente"].ToString();
                    if (frente == "S") { Exterior.Checked = true; }
                    if (frente == "N") { Interior.Checked = true; }

                    string elItem = "";
                    for (int i = 0; i < CmbTipo.Items.Count; i++)
                    {

                        if ((CmbTipo.Items[i] as TipoHabitacion).id.ToString() == dr["Id_TipoHab"].ToString())
                        {
                            elItem = CmbTipo.Items[i].ToString();
                        }
                    }
                    CmbTipo.Text = elItem;

                    ChkHabilitada.Checked = Convert.ToBoolean(dr["Habilitado"].ToString());
                }
                dr.Close();
                                               
                bd.cerrar();
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try {
                ValidarTxt(TxtNro, "Número");
                ValidarTxt(TxtPiso, "Piso");
                if (!Interior.Checked && !Exterior.Checked)
                    throw new Exception("No seleccionó la ubicación.");
                if (CmbTipo.SelectedIndex == -1)
                    throw new Exception("No seleccionó el tipo de habitación.");
                if (CmbHotel.SelectedIndex ==-1)
                    throw new Exception("No seleccionó el tipo de hotel.");

            if (funcion == 'M')
            {
                DialogResult confirma = MessageBox.Show("Son todos los datos correctos?", "Confirmar actualización de habitacion", MessageBoxButtons.YesNo);

                if (confirma == DialogResult.Yes)
                {
                    actualizarHabitacion();
                }
            }
            else{
            DialogResult confirma = MessageBox.Show("Son todos los datos correctos? Recuerde que el Tipo de Habitación es definitivo", this.Text, MessageBoxButtons.YesNo);

            if (confirma == DialogResult.Yes)
            {
                BD bd = new BD();
                bd.obtenerConexion();
                    char frente='N';
                    if (Exterior.Checked) frente = 'S';
                    if (Interior.Checked) frente = 'N';

                    TipoHabitacion elTipo = CmbTipo.Items[CmbTipo.SelectedIndex] as TipoHabitacion;
                    Hotel elHotel = CmbHotel.Items[CmbHotel.SelectedIndex] as Hotel;

                    string query = 
                        "INSERT INTO FUGAZZETA.Habitaciones values ("
                        +elHotel.id+","
                        +TxtNro.Text+","
                        +TxtPiso.Text+",'"
                        +frente+"',"
                        +elTipo.id+",'"
                        +TxtDesc.Text+"',"
                        +Convert.ToSByte(ChkHabilitada.Checked) + ")"
                        ;
                    bd.ejecutar(query);
                    bd.cerrar();
                    MessageBox.Show("Habitacion agregada con éxito");
                    this.Close();
                }
                 }
            }
            catch (Exception ex)
                {
                    bd.cerrar();
                    MessageBox.Show("Error: No se pudo ingresar la habitación. " + ex.Message);
                }
        }

        /*private void validarBaja()
        {
            BD bd = new BD();
            bd.obtenerConexion();
            int num = Convert.ToInt32(TxtNro.Text);
            string query = "select R.Id_Reserva, Num_Habitacion from FUGAZZETA.[Habitaciones x Reservas] HR, FUGAZZETA.Reservas R where R.Id_Reserva=HR.Id_Reserva and Num_Habitacion = " + num + " and Fecha_Inicio > cast(2013-01-01 00:00:00.000 as DATE)";
            SqlDataReader dr = bd.lee(query);
            while (dr.Read())
            {
                if (!(dr.HasRows)) throw new Exception("No seleccionó ningun tipo de habitación.");
            }
              
            bd.cerrar();
        }*/

        private void ValidarTxt(TextBox txt, string campo)
        {
            if (txt.Text == "") throw new Exception("No completó el campo: " + campo + ".");
        }

        private void actualizarHabitacion()
        {
            BD bd = new BD();
            bd.obtenerConexion();
            char frente ='N';
            if (Exterior.Checked == true) { frente = 'S'; }
            if (Interior.Checked == true) { frente = 'N'; }
            string comando =
                "UPDATE FUGAZZETA.Habitaciones SET Num_Habitacion =" + TxtNro.Text +
                ", Piso = " + TxtPiso.Text +
                ", Comodidades = '" + TxtDesc.Text +
                "', Frente = '" + frente +
                "', Habilitado = " + Convert.ToSByte(ChkHabilitada.Checked) +
                " WHERE Num_Habitacion = " + tuId + "AND Id_Hotel = " + tuHotel;
            bd.ejecutar(comando);
            
            

            bd.cerrar();
            MessageBox.Show("Actualización realizada con éxito");
           
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ElegirHotel_Click(object sender, EventArgs e)
        {
            new ABM_de_Hotel.BuscarHotel(this).ShowDialog();
        }

        
        private void TxtHotel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

