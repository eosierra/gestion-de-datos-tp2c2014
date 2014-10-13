using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void GetData(string selectCommand)
        {
           BD baseD = new BD();
           bindingSource1.DataSource = baseD.ejecutar(selectCommand) ;
           dataGridView1.AutoResizeColumns(
           DataGridViewAutoSizeColumnsMode.AllCells);
       }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select Username,Contraseña,Baja from FUGAZZETA.Usuarios");
        }



    }
}
