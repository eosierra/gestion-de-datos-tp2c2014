using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel
{
    class DatePrograma
    {
        int dia;
        int mes;
        int año;

        public DatePrograma(DateTime fecha)
        {
            dia = fecha.Day;
            mes = fecha.Month;
            año = fecha.Year;
        }

        public override string ToString()
        {
            return (dia + "/" + mes + "/" + año);
        }
    }
}
