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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipal());
        }

        internal static DateTime ahora()
        {
            //Año, mes, dia, hora, minuto, segundo
            return new DateTime(2014, 11, 16, 12, 00, 00);
        }

        internal static DateTime hoy()
        {
            return ahora().Date;
        }

    }
}
