using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            Calendario.MaxDate = Program.hoy();
            
        }

        private void AgregarRol_Click(object sender, EventArgs e)
        {
          
            //listBox1.Items.Add(   );
        }

        private void QuitarRol_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void validarContraseñas(object sender, EventArgs e)
        {
            if (TxtPass1.Text != TxtPass2.Text)
            {
                LblError1.Text = "Las contraseñas no coinciden";
            }
            else
            {
                LblError1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void validarUser()
        {
            //busca al user
            MessageBox.Show("El nombre de usuario está disponible");
            LblError1.Text = "El usuario no está disponible";
        }

        private void LinkValida_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            validarUser();
        }

     }
}
