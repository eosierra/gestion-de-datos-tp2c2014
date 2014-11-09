using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ABM_de_Habitacion
{
    class TipoHabitacion : Agregable
    {

        public TipoHabitacion(string unId, string desc)
        {
            asigna(unId, desc);
        }
    }
}
