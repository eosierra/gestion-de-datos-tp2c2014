using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ABM_de_Cliente
{
    class Cliente: Agregable
    {

        public Cliente(string unId, string apellido, string nombre)
        {
            string nombreCompleto = apellido + ", " + nombre;
            asigna(unId, nombreCompleto);
        }

        public Cliente(string unId, string nombreApellido)
        {
            asigna(unId, nombreApellido);
        }
    }
}
