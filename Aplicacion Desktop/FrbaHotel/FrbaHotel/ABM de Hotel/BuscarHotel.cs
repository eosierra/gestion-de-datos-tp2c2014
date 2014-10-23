using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class BuscarHotel : Buscador, ITraeBusqueda
    {
        public BuscarHotel(ITraeBusqueda owner)
        {
            InitializeComponent();
            crearBuscador(owner, "*", "Hoteles");
            setearGrid(GridHoteles);
        }

        private void BuscarHotel_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            cargarGrilla(GridHoteles, todos);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            string id = celdaElegida(GridHoteles, 0);
            string desc = celdaElegida(GridHoteles, 1);
            dondeVuelve.agregar(id, desc);
        }

        #region filtros
        private void TxtCiudad_TextChanged(object sender, EventArgs e)
        {
            addFiltroTextBox(TxtCiudad, "Ciudad", GridHoteles);
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            addFiltroTextBox(TxtNombre, "Nombre", GridHoteles);
        }

        private void ComboCE_SelectedIndexChanged(object sender, EventArgs e)
        {
            addFiltroComboBox(ComboCE, "CantEstrella", GridHoteles);
        }
        
        private void ElegirPais_Click(object sender, EventArgs e)
        {
            new BuscarPais(this).ShowDialog();
        }

        public void agregar(string id, string descripcion)
        {
            Pais paisElegido = new Pais(id, descripcion);
            TxtPais.Text = paisElegido.nombre;
            addFiltroNumero(paisElegido.id, "Pais", GridHoteles);
        }

        #endregion
    }
}
