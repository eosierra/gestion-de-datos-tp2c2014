using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaHotel.ABM_de_Regimen;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class GenerarReserva : Form, ITraeBusqueda
    {
        int nBuscador;
        int idClienteActual;
        int idHotelActual;
        MenuPrincipal menuP;
        int idReservaGenerada;

        public GenerarReserva(MenuPrincipal menu)
        {
            menuP = menu;
            InitializeComponent();
            DesdePick.MinDate = Program.hoy();
            HastaPick.MinDate = Program.hoy();
        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {
            if (menuP.usuarioActual != "guest")
            {
                ElegirHotel.Enabled = false;
                idHotelActual = menuP.hotelActual;
                TxtHotel.Text = idHotelActual.ToString();
                BD db = new BD();
                db.obtenerConexion();
                completaRegimenes(db);
                db.cerrar();
            }
        }


        private void Reservar_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Son todos los datos correctos?", "Nueva reserva", MessageBoxButtons.OKCancel);
            if (confirma == DialogResult.OK)
            {
                try
                {
                    // El cliente se valida al momento de buscarse o darse de alta.
                    // Los datos de estadia (Hotel, Fechas) se validan en el "ConfirmaDatosEstadia"
                    // Las fechas de reserva se revalidan automaticamente.
                    validarRegimen();
                    validarHabitaciones();
                    generarLaReserva();
                    MessageBox.Show("La reserva se ha realizado con éxito. Su código de reserva es: " + idReservaGenerada + ". Es muy importante que conserve este código al momento de realizar el ingreso y el egreso del hotel.", "Nueva Reserva");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo realizar la reserva. " + ex.Message,"FRBA Hoteles");
                }
            }


        }

        private void generarLaReserva()
        {
            BD bd = new BD();
            bd.obtenerConexion();
            int idRegimen = (ComboRegimen.SelectedItem as ABM_de_Regimen.Regimen).id;
            string usuario = menuP.usuarioActual;
            string query = "EXEC FUGAZZETA.GenerarReserva " + idClienteActual + ", " + idHotelActual + ", '" + Program.ahora().ToString() + "', '" + DesdePick.Value.ToShortDateString() + "', '" + HastaPick.Value.ToShortDateString() + "', " + idRegimen + ", '" + usuario + "'";
            SqlDataReader reader = bd.lee(query);
            while (reader.Read())
            {
                idReservaGenerada = Int32.Parse(reader[0].ToString());
            }
            reader.Close();
            
            for (int i=0; i < ListHabitaciones.Items.Count - 1; i++)
            {
                string numHabitacion = (ListHabitaciones.Items[i] as ABM_de_Habitacion.Habitacion).ToString();
                query = "INSERT INTO FUGAZZETA.[Habitaciones x Reservas] values (" + idReservaGenerada + ", " + idHotelActual + ", " + numHabitacion + ")";
                bd.ejecutar(query);
            }
            bd.cerrar();
        }

        #region Validaciones
        
        #region Validar Reservas
        private bool reservaValida()
        {
            return (DesdePick.Value < HastaPick.Value);
        }

        private void revalidarReserva(object sender, EventArgs e)
        {
            if (!reservaValida())
            {
                DateTime desde = DesdePick.Value;
                HastaPick.MinDate = new DateTime(desde.Year, desde.Month, desde.Day + 1);
            }
        }
        #endregion

        private void validarOtrasHabitaciones()
        {
            for (int i = 0; i < ListHabitaciones.Items.Count; i++)
            {
                if (ListHabitaciones.Items[i].ToString() == ListHabitaciones.Items[i].ToString())
                {
                    string eliminado = ListHabitaciones.Items[i].ToString();
                    ListHabitaciones.Items.RemoveAt(i);
                    MessageBox.Show("La habitación " + eliminado + " ya había sido elegida.");
                }
            }
        }


        private void validarHabitaciones()
        {
            if (ListHabitaciones.Items.Count == 0)
                throw new Exception("No se seleccionó ninguna habitación para reservar.");
            validarOtrasHabitaciones();
        }

        private void validarRegimen()
        {
            if (ComboRegimen.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un regimen para continuar. ", "FRBA Hoteles");
                nBuscador = 4;
                new BuscarRegimen(this,idHotelActual).ShowDialog();
            }
        }

        private void valida(string tabla,string campo, int id, string mensajeException)
        {
            bool estaHabilitado = true;
            BD bd = new BD();
            bd.obtenerConexion();
            string query = "SELECT Habilitado FROM FUGAZZETA." + tabla + " where " + campo + " = " + id;
            SqlDataReader dr = bd.lee(query);
            while (dr.Read())
            {
                estaHabilitado = Convert.ToBoolean(dr[0].ToString());
            }
            dr.Close();
            if (!estaHabilitado)
            {
                throw new Exception(mensajeException);
            }
            bd.cerrar();
        }

        #endregion

        void ITraeBusqueda.agregar(string id, string descripcion)
        {
            BD db = new BD();
            db.obtenerConexion();
            SqlDataReader reader;
            string query;
            switch (nBuscador)
            {
                case 1:
                    bool estaHabilitado = true;
                    query = "SELECT * FROM FUGAZZETA.Clientes WHERE Id_Cliente = " + id;
                    reader = db.lee(query);
                    while (reader.Read())
                    {
                        // Valida al usuario primero. Si no está habilitado, cierra todo.
                        estaHabilitado = Convert.ToBoolean(reader["Habilitado"].ToString());
                        if (!estaHabilitado)
                        {
                            reader.Close();
                            MessageBox.Show("El cliente no está habilitado por la cadena para realizar la reserva. Consulte con Recepción o Administración para regularizar la situación.");
                            this.Close();
                            break;
                        }
                        //Si está validado, completa los datos.
                        SqlDataReader r2d2;
                        idClienteActual = Int32.Parse(id);
                        TxtNombre.Text = reader[1].ToString() + " " + reader[2].ToString();

                        r2d2 = db.lee("SELECT Descripcion FROM FUGAZZETA.TiposDoc WHERE Id_TipoDoc = " + reader[3].ToString());
                        while (r2d2.Read())
                            TxtDoc.Text = r2d2[0].ToString() + " " + reader[4].ToString();
                        //r2d2.Close();
                        r2d2 = db.lee("SELECT Nombre FROM FUGAZZETA.Paises WHERE Id_Pais =" + reader["Nacionalidad"].ToString());
                        while (r2d2.Read())
                            TxtPais.Text = r2d2[0].ToString();
                        r2d2.Close();
                        
                        TxtNac.Text = reader[5].ToString().Substring(0, 10);
                        TxtMail.Text = reader[6].ToString();
                        TxtTelefono.Text = reader[7].ToString();
                        TxtDomicilio.Text = reader[8].ToString() + " " + reader[9].ToString() + " " + reader[10].ToString() + " " + reader[11].ToString();
                        TxtCiudad.Text = reader[12].ToString();
                    }
                    reader.Close();
                    break;
                case 2:
                    ComboRegimen.Items.Clear();
                    idHotelActual = Int32.Parse(id);
                    string texto = "";
                    if (descripcion.Length == 0) texto = id;
                    else texto = descripcion;
                    TxtHotel.Text = texto;
                    completaRegimenes(db);
                    break;
                case 3:
                    bool sePuede = true;
                    bool sigue = true;
                    for (int i = 0; (i < ListHabitaciones.Items.Count) && sigue; i++)
                    {
                        if (ListHabitaciones.Items[i].ToString() == descripcion)
                        {
                            sigue = false;
                            sePuede = false;
                        }
                    }
                    if (!sePuede)
                    {
                        MessageBox.Show("No se puede agregar. Ya agregó esa habitación");
                    }
                    else
                    {
                        ListHabitaciones.Items.Add(new ABM_de_Habitacion.Habitacion(id, descripcion));
                    }
                    
                    break;
                case 4:
                    ComboRegimen.Text = descripcion;
                    break;
            }
            db.cerrar();
        }

        private void completaRegimenes(BD db)
        {
            string query = "SELECT R.Id_Regimen, R.Descripcion FROM FUGAZZETA.Regimenes R, FUGAZZETA.[Regimenes x Hotel] H WHERE H.Id_Regimen = R.Id_Regimen and H.Id_Hotel = " + idHotelActual;
            SqlDataReader reader = db.lee(query);
            while (reader.Read())
            {
                ComboRegimen.Items.Add(new ABM_de_Regimen.Regimen(reader[0].ToString(), reader[1].ToString()));
            }
            reader.Close();
        }

        #region Botones
        private void BuscarCliente_Click(object sender, EventArgs e)
        {
            nBuscador = 1;
            DialogResult sigue = new ABM_de_Cliente.BuscarCliente(this,'S').ShowDialog();
            if (sigue == DialogResult.OK) group3.Enabled = true;
        }

        private void ElegirHotel_Click(object sender, EventArgs e)
        {
            nBuscador = 2;
            DialogResult nuevoHotel = new ABM_de_Hotel.BuscarHotel(this).ShowDialog();
            if (nuevoHotel == DialogResult.OK)
            {
                ListHabitaciones.Items.Clear();
            }
        }

        private void QuitarHab_Click(object sender, EventArgs e)
        {
            int posicion = ListHabitaciones.SelectedIndex;
            if (posicion > -1)
            {
                ListHabitaciones.Items.RemoveAt(posicion);
            }
        }

        private void AgregarHab_Click(object sender, EventArgs e)
        {
            nBuscador = 3;
            string idRegimen;
            if (ComboRegimen.SelectedIndex == -1)
            {
                idRegimen = "NULL";
            }
            else
            {
                idRegimen = (ComboRegimen.SelectedItem as ABM_de_Regimen.Regimen).id.ToString();
            }

            DialogResult agregado = new BuscarHabitacionLibre(this,idHotelActual, DesdePick.Value.ToShortDateString(), HastaPick.Value.ToShortDateString(),idRegimen).ShowDialog();
            /*if (agregado == DialogResult.OK)
            {
                validarOtrasHabitaciones();
            }*/
        }

        private void CancelarTodo_Click(object sender, EventArgs e)
        {
            DialogResult seguro = MessageBox.Show("Seguro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (seguro== DialogResult.Yes) this.Close();
        }

        private void ConfirmarDatosEstadia_Click(object sender, EventArgs e)
        {
            try
            {
                validarHotel();
                valida("Hoteles", "Id_Hotel", idHotelActual, "Este hotel no está habilitado por la cadena.");
                BD bd = new BD();
                bd.obtenerConexion();
                string query = "EXEC FUGAZZETA.CancelarPorNoShow '" + Program.hoy().ToShortDateString() + "', '" + menuP.usuarioActual + "'";
                bd.ejecutar(query);
                group3.Enabled = false;
                groupHab.Enabled = true;
                ListHabitaciones.Items.Clear();
                validarRegimen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void validarHotel()
        {
            if (TxtHotel.Text=="") throw new Exception("Seleccione un hotel");
        }

        private void PasoAtras_Click(object sender, EventArgs e)
        {
            groupHab.Enabled = false;
            group3.Enabled = true;
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                validarHabitaciones();
                groupHab.Enabled = false;
                groupCliente.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
    }
}
