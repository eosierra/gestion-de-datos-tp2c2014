using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

namespace FrbaHotel.ABM_de_Habitacion
{
    class Habitacion: Agregable
    {
        public int hotel;
        public int numero;
        string tipo = null;
        public int precioUnitario;
        char fx;

        public Habitacion(string hotel2, string numero2,string type,string pu,char fun)
        {
            hotel = Int16.Parse(hotel2);
            numero = Int16.Parse(numero2);
            tipo = type;            
            precioUnitario = Int16.Parse(sacarPesos(pu)); 
            fx = fun;
        }

        private string sacarPesos(string pu)
        {
            string data = pu;
            data.Remove(0, 1);
            data.TrimStart('/');
            return data.Substring(1);
        }
        
        public Habitacion(string hotel2, string numero2)
        {
            hotel = Int16.Parse(hotel2);
            numero = Int16.Parse(numero2);
        }

        public override string ToString()
        {
            if (fx == 'G')
                return numero.ToString() + " - " + tipo + ".";
            else
                return numero.ToString();
        }
    }
}
