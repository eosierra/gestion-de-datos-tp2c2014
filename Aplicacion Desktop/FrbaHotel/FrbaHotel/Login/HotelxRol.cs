using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.ABM_de_Hotel;
using FrbaHotel.ABM_de_Rol;
using System.Data.SqlClient;

namespace FrbaHotel.Login
{
    class HotelxRol: Agregable
    {
        public Hotel hotel;
        public Rol rol;

        public HotelxRol(string idHotel, string idRol)
        {
            BD bd = new BD();
            bd.obtenerConexion();
            string query = "SELECT H.Nombre, R.Nombre FROM FUGAZZETA.Roles R, FUGAZZETA.Hoteles H WHERE H.Id_Hotel = " + idHotel + " AND R.Id_Rol = " + idRol;
            SqlDataReader dr = bd.lee(query);
            while (dr.Read())
            {
                hotel = new Hotel(idHotel, dr[0].ToString());
                rol = new Rol(idRol, dr[1].ToString());
            }
        }

        public override string ToString()
        {
            return hotel.id + " - " + hotel.nombre + " / " + rol.nombre;
        }
    }
}
