﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class BuscarRol : Buscador
    {
        
        public BuscarRol(ITraeBusqueda owner)
        {
            InitializeComponent();
            crearBuscador(owner, "Id_Rol,Nombre", "Roles");
            setearGrid(GridRoles);
        }

        private void BuscarRol_Load(object sender, EventArgs e)
        {
            bd.obtenerConexion();
            cargarGrilla(GridRoles, todos);
            
        }

        private void TxtRol_TextChanged(object sender, EventArgs e)
        {
            addFiltroTextBox(TxtRol, "Nombre", GridRoles);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = celdaElegida(GridRoles,0);
            string name = celdaElegida(GridRoles,1);
            Rol rol = new Rol(id, name);
            dondeVuelve.agregar(id, name);
            this.Close();
        }
    }
}
