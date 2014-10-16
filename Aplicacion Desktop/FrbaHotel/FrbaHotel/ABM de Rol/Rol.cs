using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ABM_de_Rol
{
    class Rol
    {
        int id;
        string nombre;

        public Rol(string id2, string nombre2)
        {
            id = Convert.ToInt32(id2);
            nombre = nombre2;
        }
    }
}
