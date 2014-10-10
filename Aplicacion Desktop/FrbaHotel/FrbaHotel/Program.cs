using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FrbaHotel.Login;
using System.Data.SqlClient;

namespace FrbaHotel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //SqlConnection conn = Conexion.conectar();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ABM_de_Usuario.AltaUsuario());
        }
    }
}
