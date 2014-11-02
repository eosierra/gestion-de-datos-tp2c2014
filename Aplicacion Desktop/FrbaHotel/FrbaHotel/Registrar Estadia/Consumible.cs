using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.Registrar_Estadia
{
    class Consumible : Agregable
    {
        public double precio;

        public Consumible(string unID, string name)
        {
            asigna(unID, name);
            BD bd = new BD();
            bd.obtenerConexion();
            SqlDataReader dr = bd.lee("SELECT Precio FROM FUGAZZETA.Consumibles where Id_Consumible = " + id);
            while (dr.Read())
            {
                precio = Convert.ToDouble(dr[0].ToString());
            }
            dr.Close();
            bd.cerrar();
        }
    }

    class TableCarrito : DataTable
        {
            List<Consumible> consumibles;
            public DataTable tabla;

            public TableCarrito()
            {
                tabla = new DataTable("Carrito");
                tabla.Columns.Add("Consumible");
                tabla.Columns.Add("Cantidad");
                tabla.Columns.Add("Precio");
                consumibles = new List<Consumible>();
            }

            public void add(Consumible consumible, int cant)
            {

                if (tabla.Rows.)
                {
                    tabla.Select("Consumible like '" + consumible.nombre + "'").SetValue(cant,1);
                }
                else
                {
                DataRow fila = tabla.NewRow();
                fila.SetField(0, consumible.nombre);
                fila.SetField(1, cant);
                double pr = consumible.precio * cant;
                fila.SetField(2, pr);

                tabla.Rows.Add(fila);
                consumibles.Add(consumible);
                }
            }

            public void agregarColumna(string name)
            {
                tabla.Columns.Add(name);
            }

        }
}
