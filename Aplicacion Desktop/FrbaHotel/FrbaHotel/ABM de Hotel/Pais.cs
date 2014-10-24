using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ABM_de_Hotel
{
    class Pais: Agregable
    {

        public Pais(string unId, string desc)
        {
            asigna(unId, desc);
        }
    }
}
