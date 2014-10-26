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

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class ModificarHotel : Form, ITraeBusqueda
    {
        //Hotel hotelin;
        bool habilitado;

        public ModificarHotel()
        {
            InitializeComponent();
        }

        private void ModificarHotel_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            FechaPick.MaxDate = Program.hoy();
            
            BD bd = new BD();
            string query = "SELECT * FROM FUGAZZETA.Paises ORDER BY Nombre";
            SqlDataReader dr = bd.lee(query);
            while (dr.Read())
            {
                ComboPais.Items.Add(new Pais(dr[0].ToString(), dr[1].ToString()));
            }
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            DialogResult habilita = new ABM_de_Hotel.BuscarHotel(this).ShowDialog();
            if (habilita == DialogResult.OK)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
            }
        }

        public void agregar(string id, string descripcion)
        {
            ListRegimenes.Items.Clear();
            BD bd = new BD();
            bd.obtenerConexion();
            int elId = Convert.ToInt32(id);
            string query = "SELECT * FROM FUGAZZETA.Hoteles WHERE Id_Hotel = " + elId;
            SqlDataReader dr = bd.lee(query);

            while (dr.Read())
            {
                TxtId.Text = dr["Id_Hotel"].ToString();
                TxtNombre.Text = dr["Nombre"].ToString();
                TxtMail.Text = dr["Mail"].ToString();
                TxtTelefono.Text = dr["Telefono"].ToString();
                TxtCalle.Text = dr["Calle"].ToString();
                TxtNumero.Text = dr["Nro_Calle"].ToString();
                TxtCiudad.Text = dr["Ciudad"].ToString();
                TxtRecarga.Text = dr["Recarga"].ToString();
                ComboCE.Text = dr["CantEstrella"].ToString();

                string elItem = "";
                for (int i = 0; i < ComboPais.Items.Count; i++)
                {
                    
                    if ((ComboPais.Items[i] as Pais).id.ToString() == dr["Pais"].ToString())
                    {
                        elItem = ComboPais.Items[i].ToString();
                    }
                }
                ComboPais.Text = elItem;
                                
                string fecha = dr["Fec_creacion"].ToString();
                if (fecha != "") { FechaPick.Value = convertirFecha(fecha); }

                habilitado = Convert.ToBoolean(dr["Habilitado"].ToString());
             }
            dr.Close();
            completarDatosDeEstado();

            query = "SELECT H.Id_Hotel,H.Id_Regimen, R.Descripcion FROM FUGAZZETA.[Regimenes x Hotel] H, FUGAZZETA.Regimenes R where H.Id_Regimen = R.Id_Regimen AND Id_Hotel = " + TxtId.Text;
            dr = bd.lee(query);
            while (dr.Read())
            {
                ListRegimenes.Items.Add(new Regimen(dr[1].ToString(), dr[2].ToString()));
            }
            bd.cerrar();

        }

        private void completarDatosDeEstado()
        {
            if (habilitado)
            {
                LblHabilitado.Text = "Habilitado";
                LblDesde.Visible = false;
                TxtDesde.Visible = false;
                LblHasta.Visible = false;
                LblMotivo.Visible = false;
                TxtHasta.Visible = false;
                TxtMotivo.Visible = false;
            }
            else
            {
                LblHabilitado.Text = "Deshabilitado";
                LblDesde.Visible = true;
                LblHasta.Visible = true;
                LblMotivo.Visible = true;
                TxtDesde.Visible = true;
                TxtHasta.Visible = true;
                TxtMotivo.Visible = true;
                BD bd = new BD();
                bd.obtenerConexion();
                string query = "SELECT TOP 1 * FROM FUGAZZETA.HistorialBajasHotel WHERE Id_Hotel = " + TxtId.Text + "ORDER BY Fecha_Inicio DESC";
                SqlDataReader dr = bd.lee(query);
                while (dr.Read())
                {
                    TxtDesde.Text = (dr["Fecha_Inicio"].ToString()).Substring(0,10);
                    TxtHasta.Text = (dr["Fecha_Fin"].ToString()).Substring(0,10);
                    TxtMotivo.Text = dr["Motivo"].ToString();
                }
                dr.Close();
            }
        }

        private DateTime convertirFecha(string fecha)
        {
            return Convert.ToDateTime(fecha);
        }

        private void ActualizarDatos_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Son todos los datos correctos?", "Confirmar actualización de hotel", MessageBoxButtons.YesNo);

            if (confirma == DialogResult.Yes)
            {
                actualizarHotel();
            }
        }
 
        private void actualizarHotel()
        {
            int elId = Convert.ToInt32(TxtId.Text);
            int nc = Convert.ToInt32(TxtNumero.Text);
            Pais elPais = ComboPais.Items[ComboPais.SelectedIndex] as Pais;
            int cantE = Convert.ToInt16(ComboCE.Text);
            Hotel hotelin = new Hotel(
                elId, TxtNombre.Text, TxtMail.Text, TxtTelefono.Text, TxtCalle.Text,
                nc, TxtCiudad.Text, elPais, cantE, FechaPick.Value, habilitado);

            hotelin.actualizar();
            MessageBox.Show("Actualización realizada con éxito");
            this.Close();
        }

        private void CambiarEstado_Click(object sender, EventArgs e)
        {
            if (habilitado)
            {
                DialogResult bajo = new BajaHotel(TxtId.Text).ShowDialog();
                if (bajo == DialogResult.OK)
                {
                    habilitado = false;
                    completarDatosDeEstado();
                    groupBox2.Enabled = false;
                }
            }
            else
            {
                DialogResult confirma = MessageBox.Show("Está seguro de volver a habilitar el hotel? No podrá deshacer el cambio.", "Habilitar hotel", MessageBoxButtons.YesNo);
                if (confirma == DialogResult.Yes)
                {
                    BD bd = new BD();
                    string query = "UPDATE FUGAZZETA.HistorialBajasHotel SET Fecha_Fin = '" + new DatePrograma(Program.hoy()).ToString() + "' WHERE Id_Hotel = " + TxtId.Text + " AND Fecha_Inicio = '" + TxtDesde.Text + "'";
                    bd.ejecutar(query);
                    habilitado = true;
                    completarDatosDeEstado();
                    groupBox2.Enabled = false;
                    MessageBox.Show("Se ha habilitado el hotel con éxito");
                }
            }
        }
    }
}
