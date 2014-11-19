using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FrbaHotel.Login;
using System.Data.SqlClient;
using System.Configuration;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipal());
        }

        internal static DateTime ahora()
        {
            return Convert.ToDateTime(ConfigurationSettings.AppSettings["FechaSistema"]);
        }

        internal static DateTime hoy()
        {
            return ahora().Date;
        }

    }
}
