using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace FrbaHotel.Listado_Estadistico
{
    
    class Periodo
    {
        DateTime fechaInicio;
        DateTime fechaFin;

        public Periodo(int mesInicio, int mesFin, int año)
        {
            fechaInicio = new DateTime(año, mesInicio, 1);
            fechaFin = new DateTime(año, mesFin, DateTime.DaysInMonth(año, mesFin)); 
        }

        public override string ToString()
        {
            string mesInicio = fechaInicio.ToString("MMMMMMMMM", CultureInfo.CurrentCulture).ToUpper();
            string mesFin = fechaFin.ToString("MMMMMMMMM", CultureInfo.CurrentCulture).ToUpper();
            return mesInicio + " " + fechaInicio.Year.ToString() + " -- " + mesFin + " " + fechaFin.Year.ToString();
        }

        public string inicio()
        {
            return fechaInicio.ToShortDateString();
        }

        public string fin()
        {
            return fechaFin.ToShortDateString();
        }
    }
}
