using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ABM_de_Hotel
{
    class Hotel: Agregable
    {
        #region Propiedades
        public string mail;
        public string telefono;
        public string calle;
        public int nroCalle;
        public string ciudad;
        public Pais pais;
        public int cantEstrellas;
        public DateTime fechaCreacion;
        public bool habilitado;
        #endregion

        #region New Hotel
        public Hotel(
            int unId, string unName, string unMail, string unTel, string unaCalle,
            int nCalle, string unaCiudad, Pais unPais, int cE, DateTime fecCre,bool hab)
        {
            asigna(unId.ToString(), unName);
            mail = unMail;
            telefono = unTel;
            calle = unaCalle;
            nroCalle = nCalle;
            ciudad = unaCiudad;
            pais = unPais;
            cantEstrellas = cE;
            fechaCreacion = fecCre;
            habilitado = hab;
        }


        public Hotel(string unId, string unName)
        {
            asigna(unId, unName);
        }
        #endregion


        internal void actualizar()
        {
            BD bd = new BD();
            bd.obtenerConexion();
            string comando =
                "UPDATE FUGAZZETA.Hoteles SET Nombre = " + ifNull(nombre) +
                ", Mail = " + ifNull(mail) +
                ", Telefono = " + ifNull(telefono) +
                ", Calle = " + ifNull(calle) +
                ", Nro_Calle = " + ifNull(nroCalle) +
                ", Ciudad = " + ifNull(ciudad) +
                ", Pais = " + pais.id +
                ", CantEstrella = " + cantEstrellas +
                ", Fec_Creacion = '" + fechaCreacion.ToString() +
                "', Habilitado = " + Convert.ToSByte(habilitado) +
                " WHERE Id_Hotel = " + id;
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

        internal string ifNull(int numero)
        {
            string str = numero.ToString();
            if (str == "")
            {
                return "NULL";
            }
            else
            {
                return str;
            }

        }

        public override string ToString()
        {
            return id + ") " + nombre;
        }
    }
}
