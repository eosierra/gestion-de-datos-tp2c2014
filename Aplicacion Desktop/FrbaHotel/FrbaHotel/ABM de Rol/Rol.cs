using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ABM_de_Rol
{
    class Rol: Agregable
    {
        public bool estado;
        
        public Rol(string id,string nom,bool activo){   
        asigna(id, nom);
            nombre=nom;
            estado=activo;
        }

        public Rol(string id2, string nombre2)
        {
            asigna(id2, nombre2);
        }

        public void actualizar(){
            BD bd = new BD();
            bd.obtenerConexion();
            string comando =
                "UPDATE FUGAZZETA.Roles SET Nombre =" + ifNull(nombre) +
                ", Estado = " + Convert.ToSByte(estado) +
                " WHERE Id_Rol = " + id;
            bd.ejecutar(comando);
        }
        
        internal string ifNull(string texto)
        {
            if (texto == "")
            {
                return "NULL";
            }
            else
            {
                return ("'" + texto + "'");
            }
        }
    }
}
