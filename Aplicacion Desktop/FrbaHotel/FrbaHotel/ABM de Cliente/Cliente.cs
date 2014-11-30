using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

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
            string apn = "";
            BD bd = new BD();
            bd.obtenerConexion();
            SqlDataReader r2d2 = bd.lee("SELECT Apellido,Nombre FROM FUGAZZETA.Clientes WHERE Id_Cliente = " + unId);
            while (r2d2.Read())
                apn = r2d2["Apellido"].ToString() + ", " + r2d2["Nombre"].ToString();
            r2d2.Close();
            bd.cerrar();
            asigna(unId, apn);
        }
    }
}
