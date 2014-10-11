using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel
{
    class BD
    {
            static SqlConnection Conexion = new SqlConnection();

            public static SqlConnection ObtenerConexion()
            {
                String connString = "Server=localhost\\SQLSERVER2008; " + "Database=GD2C2014;User Id=gd;Password=gd2014";

                if (Conexion.State == ConnectionState.Closed)
                {
                    Conexion.ConnectionString = connString;
                    Conexion.Open();
                }
                return Conexion;
            }

            public String connectionString()
            {
                return "Server=localhost\\SQLSERVER2008; " + "Database=GD2C2014;User Id=gd;Password=gd2014";
            }

     }
}

