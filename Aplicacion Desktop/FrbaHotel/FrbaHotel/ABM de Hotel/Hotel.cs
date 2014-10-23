using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ABM_de_Hotel
{
    class Hotel
    {
        #region Propiedades
        public int id {get;set;}
        public string nombre { get; set; }
        public string mail;
        public string telefono;
        public string calle;
        public int nroCalle;
        public string ciudad;
        public Pais pais;
        public int cantEstrellas;
        public DateTime fechaCreacion;
        #endregion

        #region New Hotel
        public Hotel(
            int unId, string unName, string unMail, string unTel, string unaCalle,
            int nCalle, string unaCiudad, Pais unPais, int cE, DateTime fecCre)
        {
            id = unId;
            nombre = unName;
            mail = unMail;
            telefono = unTel;
            calle = unaCalle;
            nroCalle = nCalle;
            ciudad = unaCiudad;
            pais = unPais;
            cantEstrellas = cE;
            fechaCreacion = fecCre;
        }


        public Hotel(string unId, string unName)
        {
            id = Convert.ToInt32(unId);
            nombre = unName;
        }
        #endregion

        public override string ToString()
        {
            return nombre;
        }

        internal void actualizar()
        {
            BD bd = new BD();
            bd.obtenerConexion();
            string comando =
                "UPDATE FUGAZZETA.Hoteles SET Nombre = '" + nombre +
                "', Mail = '" + mail +
                "', Telefono = " + telefono +
                ", Calle = '" + calle +
                "', Nro_Calle = " + nroCalle +
                ", Ciudad = '" + ciudad +
                "', Pais = " + pais.id +
                ", CantEstrella = " + cantEstrellas +
                ", Fec_Creacion = '" + fechaCreacion.ToString() +   
                "' WHERE Id_Hotel = " + id;
            bd.ejecutar(comando);
        }
    }
}
