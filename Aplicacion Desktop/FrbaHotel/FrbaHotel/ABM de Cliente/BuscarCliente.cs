using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class BuscarCliente : Buscador
    {
        int n = 100;
        char fx;

        public BuscarCliente(ITraeBusqueda owner, char funcion)
        {
            InitializeComponent();
            BD bd = new BD();
            bd.obtenerConexion();
            dondeVuelve = owner;
            setearGrid(GridClientes);
            crearBuscador(dondeVuelve, "*", "Clientes");
            SqlDataReader reader = bd.lee("SELECT * FROM FUGAZZETA.TiposDoc");
            while (reader.Read())
                ComboDoc.Items.Add(new TipoDoc(reader[0].ToString(), reader[1].ToString()));
            reader.Close();
            bd.cerrar();
            fx = funcion;
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            mostrarCantidadResultados(todos);
            
            if (fx=='S'){
                label1.Visible = false;
                label6.Visible = false;
                TxtApellido.Visible = false;
                TxtNombre.Visible = false;
                LblResultados.Text = "Ingrese un filtro para buscar.";
            }else
                cargarGrilla(GridClientes, top(n, todos));
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDoc.Text = "";
            ComboDoc.SelectedIndex = -1;
            TxtMail.Text = "";
            cargarGrilla(GridClientes, top(n,todos));
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            actual = todos;
            if (ComboDoc.SelectedIndex != -1)
            {
                String docActual = (ComboDoc.SelectedItem as TipoDoc).id.ToString();
                filtroTexto(docActual, "Id_TipoDoc", GridClientes);
            }
            addFiltroTextBox(TxtNombre, "Nombre", GridClientes);
            addFiltroTextBox(TxtApellido, "Apellido", GridClientes);
            addFiltroTextBox(TxtDoc, "Nro_Doc", GridClientes);
            addFiltroTextBox(TxtMail, "Mail", GridClientes);
            mostrarCantidadResultados(actual);
            cargarGrilla(GridClientes, top(n,actual));
        }

        private void mostrarCantidadResultados(string consulta)
        {
            int cant = Int32.Parse(cantidadResultados(consulta));
            if (cant > n)
            {
                LblResultados.Text = "Mostrando primeros " + n + " de " + cant + " resultados.";
            } else
            {
                LblResultados.Text = "Se encontraron " + cant + " resultados.";
            }
        }

        private void AgregarCliente_Click(object sender, EventArgs e)
        {
            DialogResult exito = new AltaCliente().ShowDialog();
            if (exito == DialogResult.OK)
            {
                BD db = new BD();
                SqlDataReader dr = db.lee("SELECT TOP 1 * FROM FUGAZZETA.Clientes ORDER BY Id_Cliente DESC");
                string id = "";
                string apellidonombre = "";
                while (dr.Read())
                {
                    id = dr[0].ToString();
                    apellidonombre = dr[2].ToString() + ", " + dr[1].ToString();
                }
                dr.Close();
                dondeVuelve.agregar(id, apellidonombre);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            string id = celdaElegida(GridClientes, 0);
            
            if (esDuplicado(id))
                MessageBox.Show("Este cliente posee datos inconsistentes/duplicados. Por favor, actualice sus datos correctamente o comuníquese con un administrador.","FRBA HOTELES",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            switch (fx)
            {
                case 'M':
                    DialogResult modif = new AltaCliente(fx, id).ShowDialog();
                    if (modif == DialogResult.OK)
                    this.Close();
                    break;
                case 'S':
                    dondeVuelve.agregar(celdaElegida(GridClientes, 0), celdaElegida(GridClientes, 1));
                    this.Close();
                    break;
            }
         }

        private bool esDuplicado(string id)
        {
            bool duplica=false;
            BD bd = new BD();
            bd.obtenerConexion();
            string query = "SELECT * FROM FUGAZZETA.ClientesDuplicados where Id_Cliente="+id;
            SqlDataReader dr = bd.lee(query);
            while (dr.Read())
                duplica = dr.HasRows;
            dr.Close();
            bd.cerrar();
            return duplica;
        }

    }
}
