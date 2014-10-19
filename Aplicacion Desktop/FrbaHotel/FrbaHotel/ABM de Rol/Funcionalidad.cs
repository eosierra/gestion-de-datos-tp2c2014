using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ABM_de_Rol
{
    class Funcionalidad
    {
        public int id;
        public string descripcion;

        public Funcionalidad(string elId, string laDesc)
        {
            id = Convert.ToInt32(elId);
            descripcion = laDesc;
        }

        public override string ToString()
        {
            return descripcion;
        }

        public int getId()
        {
            return id;
        }
    }
}
