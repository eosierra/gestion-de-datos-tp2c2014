using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FrbaHotel
{
    class Conexion
    {
        public static SqlConnection conectar()
        {
            SqlConnection conn = new SqlConnection("Data source=SQLSERVER2008; User Id=gd; Password = gd2014");
            conn.Open();
            return conn;
        }
    }
}
