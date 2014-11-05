using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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

            public void add(Consumible consumible, int cant, int regimen)
            {
                if (consumibles.Exists(c => c.id == consumible.id))
                {
                    DataRow[] founds = tabla.Select("Consumible = '" + consumible.nombre + "'");
                    for (int i = 0; i < founds.LongLength; i++)
                    {
                        int nuevaCant = Int32.Parse(founds[i][1].ToString()) + cant;
                        double nuevoPrecio = precioP(consumible, nuevaCant, regimen);
                        founds[i].SetField(1, nuevaCant);
                        founds[i].SetField(2, nuevoPrecio);
                    }
                }
                else
                {
                    DataRow fila = tabla.NewRow();
                    fila.SetField(0, consumible.nombre);
                    fila.SetField(1, cant);
                    double pr = precioP(consumible, cant, regimen);
                    fila.SetField(2, pr);
                    tabla.Rows.Add(fila);
                    consumibles.Add(consumible);
                }
            }

            public void remove(int index)
            {
                string nom = tabla.Rows[index][0].ToString();
                consumibles.RemoveAll(c => c.ToString() == nom);
                tabla.Rows.RemoveAt(index);
            }

            public void agregarColumna(string name)
            {
                tabla.Columns.Add(name);
            }

            public double total()
            {
                double tot = 0;
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    double precio = Convert.ToDouble(tabla.Rows[i][2].ToString());
                    tot = tot + precio;
                }
                return tot;
            }

        public double precioP(Consumible con, int cant, int regimen)
        {
            if (regimen == 2) return 0;
            else return con.precio * cant;
        }

        }
}
