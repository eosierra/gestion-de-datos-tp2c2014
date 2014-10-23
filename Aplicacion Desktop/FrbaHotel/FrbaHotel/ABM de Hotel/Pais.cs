using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ABM_de_Hotel
{
    class Pais
    {
        public int id;
        public string nombre;

        public Pais(string unId, string desc)
        {
            id = Convert.ToInt32(unId);
            nombre = desc;
        }

        public override string ToString()
        {
            return nombre;
        }

    }
}
