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
        int idPais = 0;

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

        private void ElegirPais_Click(object sender, EventArgs e)
        {
            new BuscarPais(this).ShowDialog();
        }

        public void agregar(string id, string descripcion)
        {
            Pais paisElegido = new Pais(id, descripcion);
            TxtPais.Text = paisElegido.id.ToString();
            idPais = paisElegido.id;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            ComboCE.SelectedIndex = -1;
            TxtCiudad.Text = "";
            TxtPais.Text = "";
            idPais = 0;
            cargarGrilla(GridHoteles, todos);

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            actual = todos;
            filtroTexto(TxtNombre.Text, "Nombre", GridHoteles);
            addFiltroComboBox(ComboCE, "CantEstrella", GridHoteles);
            addFiltroTextBox(TxtCiudad, "Ciudad", GridHoteles);
            addFiltroPorID(idPais, "Pais", GridHoteles);
            cargarGrilla(GridHoteles, actual);
        }

    }
}
