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
                MessageBox.Show("No se pudo conectar a la base de datos. Error " + ex.Number.ToString() + ": " + ex.Message);
            }
            return tabla;
        }

        public void insertar(string tablaDestino, string campos, string valores)
        {
            string comando = "INSERT INTO FUGAZZETA." + tablaDestino + " (" + campos + ") values (" + valores + ")";
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

        #region rellenarListasCombos
        public void rellenarDesde(string campo, string tablaOrigen, ListBox lista)
        {
            try
            {
                string comando = "SELECT " + campo + "FROM FUGAZZETA." + tablaOrigen;
                SqlCommand enunciado = new SqlCommand(comando, Conexion);
                SqlDataReader respuesta = enunciado.ExecuteReader();

                while (respuesta.Read())
                {
                    lista.Items.Add(respuesta[campo].ToString());
                }
                respuesta.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Error al completar: " + ex.Message);
            }
        }

        public void rellenarDesde(string campo, string tablaOrigen, ComboBox cb)
        {
            try
            {
                string comando = "SELECT " + campo + " FROM FUGAZZETA." + tablaOrigen;
                SqlCommand enunciado = new SqlCommand(comando, Conexion);
                SqlDataReader respuesta = enunciado.ExecuteReader();

                while (respuesta.Read())
                {
                    cb.Items.Add(respuesta[campo].ToString());
                }
                respuesta.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al completar: " + ex.Message);
            }
        }
        #endregion

        internal SqlConnection getConexion()
        {
            return Conexion;
        }
    }
}

