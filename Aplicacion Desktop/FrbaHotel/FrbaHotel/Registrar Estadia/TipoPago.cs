using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Registrar_Estadia
{
    class TipoPago: Agregable
    {
        public TipoPago(string id2, string tipo)
        {
            asigna(id2, tipo);
        }
    }
}
