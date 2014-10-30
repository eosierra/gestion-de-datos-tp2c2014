using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ABM_de_Habitacion
{
    class Habitacion: Agregable
    {
        int hotel;
        int numero;

        public Habitacion(string hotel2, string numero2)
        {
            hotel = Int16.Parse(hotel2);
            numero = Int16.Parse(numero2);
        }

        public override string ToString()
        {
            return numero.ToString();
        }
    }
}
