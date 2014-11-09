namespace FrbaHotel
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.LabelSesion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SesionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarSesionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RolesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaRolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarRolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaUsuarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarUsuarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarClienteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HotelesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarHotelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ReservasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaReservaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarReservaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BajaReservaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckInMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckOutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EstadisticasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HabitacionesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaHabitacionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelSesion
            // 
            this.LabelSesion.AutoSize = true;
            this.LabelSesion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabelSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelSesion.Location = new System.Drawing.Point(0, 24);
            this.LabelSesion.Name = "LabelSesion";
            this.LabelSesion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelSesion.Size = new System.Drawing.Size(118, 17);
            this.LabelSesion.TabIndex = 1;
            this.LabelSesion.Text = "Sesión iniciada";
            this.LabelSesion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SesionMenu,
            this.RolesMenu,
            this.UsuariosMenu,
            this.ClientesMenu,
            this.HabitacionesMenu,
            this.HotelesMenu,
            this.ReservasMenu,
            this.EstadisticasMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SesionMenu
            // 
            this.SesionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CerrarSesionMenu});
            this.SesionMenu.Name = "SesionMenu";
            this.SesionMenu.Size = new System.Drawing.Size(58, 20);
            this.SesionMenu.Tag = "0";
            this.SesionMenu.Text = "&SESIÓN";
            // 
            // CerrarSesionMenu
            // 
            this.CerrarSesionMenu.Name = "CerrarSesionMenu";
            this.CerrarSesionMenu.Size = new System.Drawing.Size(159, 22);
            this.CerrarSesionMenu.Text = "CERRAR SESIÓN";
            this.CerrarSesionMenu.Click += new System.EventHandler(this.cerrarSesiónMenu_Click);
            // 
            // RolesMenu
            // 
            this.RolesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaRolMenu,
            this.ModificarRolMenu});
            this.RolesMenu.Name = "RolesMenu";
            this.RolesMenu.Size = new System.Drawing.Size(53, 20);
            this.RolesMenu.Tag = "1";
            this.RolesMenu.Text = "RO&LES";
            // 
            // AltaRolMenu
            // 
            this.AltaRolMenu.Name = "AltaRolMenu";
            this.AltaRolMenu.Size = new System.Drawing.Size(138, 22);
            this.AltaRolMenu.Tag = "1";
            this.AltaRolMenu.Text = "NUEVO ROL";
            this.AltaRolMenu.Click += new System.EventHandler(this.nuevoRolMenu_Click);
            // 
            // ModificarRolMenu
            // 
            this.ModificarRolMenu.Name = "ModificarRolMenu";
            this.ModificarRolMenu.Size = new System.Drawing.Size(138, 22);
            this.ModificarRolMenu.Tag = "1";
            this.ModificarRolMenu.Text = "EDITAR ROL";
            this.ModificarRolMenu.Click += new System.EventHandler(this.modificarRolMenu_Click);
            // 
            // UsuariosMenu
            // 
            this.UsuariosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaUsuarioMenu,
            this.ModificarUsuarioMenu});
            this.UsuariosMenu.Name = "UsuariosMenu";
            this.UsuariosMenu.Size = new System.Drawing.Size(74, 20);
            this.UsuariosMenu.Tag = "2";
            this.UsuariosMenu.Text = "&USUARIOS";
            // 
            // AltaUsuarioMenu
            // 
            this.AltaUsuarioMenu.Name = "AltaUsuarioMenu";
            this.AltaUsuarioMenu.Size = new System.Drawing.Size(165, 22);
            this.AltaUsuarioMenu.Tag = "2";
            this.AltaUsuarioMenu.Text = "NUEVO USUARIO";
            this.AltaUsuarioMenu.Click += new System.EventHandler(this.nuevoUsuarioMenu_Click);
            // 
            // ModificarUsuarioMenu
            // 
            this.ModificarUsuarioMenu.Name = "ModificarUsuarioMenu";
            this.ModificarUsuarioMenu.Size = new System.Drawing.Size(165, 22);
            this.ModificarUsuarioMenu.Tag = "2";
            this.ModificarUsuarioMenu.Text = "EDITAR USUARIO";
            this.ModificarUsuarioMenu.Click += new System.EventHandler(this.modificarUsuarioMenu_Click);
            // 
            // ClientesMenu
            // 
            this.ClientesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditarClienteMenu});
            this.ClientesMenu.Name = "ClientesMenu";
            this.ClientesMenu.Size = new System.Drawing.Size(70, 20);
            this.ClientesMenu.Tag = "3";
            this.ClientesMenu.Text = "&CLIENTES";
            // 
            // EditarClienteMenu
            // 
            this.EditarClienteMenu.Name = "EditarClienteMenu";
            this.EditarClienteMenu.Size = new System.Drawing.Size(191, 22);
            this.EditarClienteMenu.Tag = "3";
            this.EditarClienteMenu.Text = "EDICIÓN DE CLIENTES";
            this.EditarClienteMenu.Click += new System.EventHandler(this.EditarClienteMenu_Click);
            // 
            // HotelesMenu
            // 
            this.HotelesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModificarHotelMenu});
            this.HotelesMenu.Name = "HotelesMenu";
            this.HotelesMenu.Size = new System.Drawing.Size(68, 20);
            this.HotelesMenu.Tag = "4";
            this.HotelesMenu.Text = "&HOTELES";
            // 
            // ModificarHotelMenu
            // 
            this.ModificarHotelMenu.Name = "ModificarHotelMenu";
            this.ModificarHotelMenu.Size = new System.Drawing.Size(153, 22);
            this.ModificarHotelMenu.Tag = "4";
            this.ModificarHotelMenu.Text = "EDITAR HOTEL";
            this.ModificarHotelMenu.Click += new System.EventHandler(this.modificarHotelMenu_Click);
            // 
            // ReservasMenu
            // 
            this.ReservasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaReservaMenu,
            this.ModificarReservaMenu,
            this.BajaReservaMenu,
            this.CheckInMenu,
            this.CheckOutMenu});
            this.ReservasMenu.Name = "ReservasMenu";
            this.ReservasMenu.Size = new System.Drawing.Size(72, 20);
            this.ReservasMenu.Tag = "8";
            this.ReservasMenu.Text = "&RESERVAS";
            // 
            // AltaReservaMenu
            // 
            this.AltaReservaMenu.Name = "AltaReservaMenu";
            this.AltaReservaMenu.Size = new System.Drawing.Size(184, 22);
            this.AltaReservaMenu.Tag = "7";
            this.AltaReservaMenu.Text = "NUEVA RESERVA";
            this.AltaReservaMenu.Click += new System.EventHandler(this.realizarNuevaReservaMenu_Click);
            // 
            // ModificarReservaMenu
            // 
            this.ModificarReservaMenu.Name = "ModificarReservaMenu";
            this.ModificarReservaMenu.Size = new System.Drawing.Size(184, 22);
            this.ModificarReservaMenu.Tag = "7";
            this.ModificarReservaMenu.Text = "EDITAR RESERVA";
            this.ModificarReservaMenu.Click += new System.EventHandler(this.editarReservaMenu_Click);
            // 
            // BajaReservaMenu
            // 
            this.BajaReservaMenu.Name = "BajaReservaMenu";
            this.BajaReservaMenu.Size = new System.Drawing.Size(184, 22);
            this.BajaReservaMenu.Tag = "8";
            this.BajaReservaMenu.Text = "CANCELAR RESERVA";
            this.BajaReservaMenu.Click += new System.EventHandler(this.cancelarReservaMenu_Click);
            // 
            // CheckInMenu
            // 
            this.CheckInMenu.Name = "CheckInMenu";
            this.CheckInMenu.Size = new System.Drawing.Size(184, 22);
            this.CheckInMenu.Tag = "9";
            this.CheckInMenu.Text = "CHECK IN";
            this.CheckInMenu.Click += new System.EventHandler(this.checkInMenu_Click);
            // 
            // CheckOutMenu
            // 
            this.CheckOutMenu.Name = "CheckOutMenu";
            this.CheckOutMenu.Size = new System.Drawing.Size(184, 22);
            this.CheckOutMenu.Tag = "9";
            this.CheckOutMenu.Text = "CHECK OUT";
            this.CheckOutMenu.Click += new System.EventHandler(this.checkOutMenu_Click);
            // 
            // EstadisticasMenu
            // 
            this.EstadisticasMenu.Name = "EstadisticasMenu";
            this.EstadisticasMenu.Size = new System.Drawing.Size(95, 20);
            this.EstadisticasMenu.Tag = "13";
            this.EstadisticasMenu.Text = "ES&TADÍSTICAS";
            this.EstadisticasMenu.Click += new System.EventHandler(this.estadísticasMenu_Click);
            // 
            // HabitacionesMenu
            // 
            this.HabitacionesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaHabitacionMenu});
            this.HabitacionesMenu.Name = "HabitacionesMenu";
            this.HabitacionesMenu.Size = new System.Drawing.Size(102, 20);
            this.HabitacionesMenu.Tag = "5";
            this.HabitacionesMenu.Text = "HA&BITACIONES";
            // 
            // AltaHabitacionMenu
            // 
            this.AltaHabitacionMenu.Name = "AltaHabitacionMenu";
            this.AltaHabitacionMenu.Size = new System.Drawing.Size(186, 22);
            this.AltaHabitacionMenu.Tag = "5";
            this.AltaHabitacionMenu.Text = "NUEVA HABITACION";
            this.AltaHabitacionMenu.Click += new System.EventHandler(this.nUEVAHABITACIONToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1009, 592);
            this.Controls.Add(this.LabelSesion);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "FRBA HOTELES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSesion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UsuariosMenu;
        private System.Windows.Forms.ToolStripMenuItem SesionMenu;
        private System.Windows.Forms.ToolStripMenuItem CerrarSesionMenu;
        private System.Windows.Forms.ToolStripMenuItem AltaUsuarioMenu;
        private System.Windows.Forms.ToolStripMenuItem ModificarUsuarioMenu;
        private System.Windows.Forms.ToolStripMenuItem RolesMenu;
        private System.Windows.Forms.ToolStripMenuItem AltaRolMenu;
        private System.Windows.Forms.ToolStripMenuItem ReservasMenu;
        private System.Windows.Forms.ToolStripMenuItem AltaReservaMenu;
        private System.Windows.Forms.ToolStripMenuItem HotelesMenu;
        private System.Windows.Forms.ToolStripMenuItem ModificarHotelMenu;
        private System.Windows.Forms.ToolStripMenuItem BajaReservaMenu;
        private System.Windows.Forms.ToolStripMenuItem CheckInMenu;
        private System.Windows.Forms.ToolStripMenuItem ModificarRolMenu;
        private System.Windows.Forms.ToolStripMenuItem CheckOutMenu;
        private System.Windows.Forms.ToolStripMenuItem EstadisticasMenu;
        private System.Windows.Forms.ToolStripMenuItem ModificarReservaMenu;
        private System.Windows.Forms.ToolStripMenuItem ClientesMenu;
        private System.Windows.Forms.ToolStripMenuItem EditarClienteMenu;
        private System.Windows.Forms.ToolStripMenuItem HabitacionesMenu;
        private System.Windows.Forms.ToolStripMenuItem AltaHabitacionMenu;
    }
}