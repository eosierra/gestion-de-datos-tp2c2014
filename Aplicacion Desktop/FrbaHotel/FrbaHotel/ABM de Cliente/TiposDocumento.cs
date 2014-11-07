using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ABM_de_Cliente
{
    class TipoDoc: Agregable
    {
        public TipoDoc(string id, string descripcion)
        {
            asigna(id, descripcion);
        }
    }
}
