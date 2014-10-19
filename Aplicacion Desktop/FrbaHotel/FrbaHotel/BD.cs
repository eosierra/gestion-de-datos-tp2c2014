using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaHotel
{
    public class BD
    {
            
        static SqlConnection Conexion = new SqlConnection();
        SqlDataAdapter dataAdapter;

        public SqlConnection obtenerConexion()
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

        public DataTable ejecutar(string selectCommand)
        {
            DataTable tabla = new DataTable();
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, this.connectionString());
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                tabla.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(tabla);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos, error " + ex.Number.ToString());
            }
            return tabla;
        }

        public void insertar(string tablaDestino, string campos, string valores)
        {
            string comando = "INSERT INTO FUGAZZETA." + tablaDestino + "(" + campos + ") values (" + valores + ")";
            this.ejecutar(comando);
        }

        public void insertar(string tablaDestino, string valores)
        {
            string comando = "INSERT INTO FUGAZZETA." + tablaDestino + " values (" + valores + ")";
            this.ejecutar(comando);
        }


        public void cerrar()
        {
            Conexion.Close();
        }

        
     }
}

