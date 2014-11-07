using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ABM_de_Usuario
{
    class TipoDoc : Agregable
    {
        public TipoDoc(string unId, string desc)
        {
            asigna(unId, desc);
        }
    }
}
