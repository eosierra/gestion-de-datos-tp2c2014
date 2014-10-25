using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FrbaHotel.ABM_de_Regimen
{
    class Regimen: Agregable
    {
        public Regimen(string id, string descripcion)
        {
            asigna(id, descripcion);
        }
    }
}
