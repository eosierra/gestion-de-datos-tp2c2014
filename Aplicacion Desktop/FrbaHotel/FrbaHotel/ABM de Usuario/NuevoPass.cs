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
    public partial class NuevoPass : Form
    {
        string user;

        public NuevoPass(string usuario)
        {
            InitializeComponent();
            user = usuario;
        }

        private void Cambiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtPass1.Text != TxtPass2.Text) throw new Exception("Las contraseñas no coinciden.");
                if (TxtPass1.Text == "") throw new Exception("No ha colocado ninguna contraseña.");
                BD bd = new BD();
                bd.obtenerConexion();
                string nuevoPass = Hashing.SHA256Encrypt(TxtPass1.Text);
                bd.ejecutar("UPDATE FUGAZZETA.Usuarios SET Contraseña = '" + nuevoPass + "' WHERE Username = '" + user + "'");
                bd.cerrar();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
