using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Registrar_Estadia
{
    class Banco: Agregable
    {
        public Banco(int id2, string name)
        {
            asigna(id2.ToString(), name);
        }

    }
}
