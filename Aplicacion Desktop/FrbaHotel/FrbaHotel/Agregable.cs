using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel
{
    public abstract class Agregable
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public override string ToString()
        {
            return nombre;
        }

        public void asigna(string unId, string descripcion)
        {
            id = Convert.ToInt32(unId);
            nombre = descripcion;
        }
    }
}
