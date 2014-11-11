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
    public partial class AltaHabitacion : Buscador
    {
        string tuId;
        int tuHotel;

     public AltaHabitacion(char fun,string id,int hotel){
        InitializeComponent();
        cargarTipos();
        funcion = fun;
        tuHotel=hotel;
        tuId=id;
        cargar();
        CmbTipo.Enabled = false;
     }

     
        public AltaHabitacion(int hotel)
        {
            InitializeComponent();
            cargarTipos();
            tuHotel = hotel;
        }

        private void cargarTipos()
        {
            BD bd = new BD();
            bd.obtenerConexion();
            string query = "SELECT * FROM FUGAZZETA.TiposHabitacion ORDER BY Id_TipoHab";
            SqlDataReader dr = bd.lee(query);
            while (dr.Read())
            {
                TipoHabitacion tipo = new TipoHabitacion(dr[0].ToString(), dr[1].ToString());
                CmbTipo.Items.Add(tipo);
            }
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
                    for (int i = 1; i < CmbTipo.Items.Count; i++)
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


        private void button1_Click(object sender, EventArgs e)
        {
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
                try
                {
                    char frente='N';
                    if (Exterior.Checked==true){frente='S';}
                    if (Interior.Checked == true) { frente = 'N'; }

                    TipoHabitacion elTipo = CmbTipo.Items[CmbTipo.SelectedIndex] as TipoHabitacion;
                    
                    string query = 
                        "INSERT INTO FUGAZZETA.Habitaciones values ("
                        +tuHotel+","
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
                catch (Exception ex)
                {
                    bd.cerrar();
                    MessageBox.Show("Error: No se pudo ingresar la habitacion. " + ex.Message);
                }
            }
            }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        }
    }

