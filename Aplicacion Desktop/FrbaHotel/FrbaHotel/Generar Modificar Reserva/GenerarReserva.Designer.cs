namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class GenerarReserva
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
            this.group3 = new System.Windows.Forms.GroupBox();
            this.ComboRegimen = new System.Windows.Forms.ComboBox();
            this.QuitarHab = new System.Windows.Forms.Button();
            this.AgregarHab = new System.Windows.Forms.Button();
            this.ListHabitaciones = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HastaPick = new System.Windows.Forms.DateTimePicker();
            this.DesdePick = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtHotel = new System.Windows.Forms.TextBox();
            this.ElegirHotel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Reservar = new System.Windows.Forms.Button();
            this.CancelarTodo = new System.Windows.Forms.Button();
            this.groupCliente = new System.Windows.Forms.GroupBox();
            this.TxtDomicilio = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.TxtCiudad = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.TxtPais = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.Label();
            this.TxtNac = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtDoc = new System.Windows.Forms.Label();
            this.BuscarCliente = new System.Windows.Forms.Button();
            this.groupHab = new System.Windows.Forms.GroupBox();
            this.ConfirmarDatosEstadia = new System.Windows.Forms.Button();
            this.PasoAtras = new System.Windows.Forms.Button();
            this.group3.SuspendLayout();
            this.groupCliente.SuspendLayout();
            this.groupHab.SuspendLayout();
            this.SuspendLayout();
            // 
            // group3
            // 
            this.group3.Controls.Add(this.ConfirmarDatosEstadia);
            this.group3.Controls.Add(this.ComboRegimen);
            this.group3.Controls.Add(this.label4);
            this.group3.Controls.Add(this.label3);
            this.group3.Controls.Add(this.HastaPick);
            this.group3.Controls.Add(this.DesdePick);
            this.group3.Controls.Add(this.label2);
            this.group3.Controls.Add(this.TxtHotel);
            this.group3.Controls.Add(this.ElegirHotel);
            this.group3.Controls.Add(this.label1);
            this.group3.Location = new System.Drawing.Point(385, 12);
            this.group3.Name = "group3";
            this.group3.Size = new System.Drawing.Size(304, 166);
            this.group3.TabIndex = 0;
            this.group3.TabStop = false;
            this.group3.Text = "Paso 2 - Datos de la estadía";
            // 
            // ComboRegimen
            // 
            this.ComboRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboRegimen.FormattingEnabled = true;
            this.ComboRegimen.Location = new System.Drawing.Point(65, 119);
            this.ComboRegimen.Name = "ComboRegimen";
            this.ComboRegimen.Size = new System.Drawing.Size(128, 21);
            this.ComboRegimen.TabIndex = 14;
            // 
            // QuitarHab
            // 
            this.QuitarHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitarHab.Location = new System.Drawing.Point(116, 49);
            this.QuitarHab.Name = "QuitarHab";
            this.QuitarHab.Size = new System.Drawing.Size(23, 24);
            this.QuitarHab.TabIndex = 13;
            this.QuitarHab.Text = "-";
            this.QuitarHab.UseVisualStyleBackColor = true;
            this.QuitarHab.Click += new System.EventHandler(this.QuitarHab_Click);
            // 
            // AgregarHab
            // 
            this.AgregarHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarHab.Location = new System.Drawing.Point(116, 19);
            this.AgregarHab.Name = "AgregarHab";
            this.AgregarHab.Size = new System.Drawing.Size(23, 24);
            this.AgregarHab.TabIndex = 12;
            this.AgregarHab.Text = "+";
            this.AgregarHab.UseVisualStyleBackColor = true;
            this.AgregarHab.Click += new System.EventHandler(this.AgregarHab_Click);
            // 
            // ListHabitaciones
            // 
            this.ListHabitaciones.FormattingEnabled = true;
            this.ListHabitaciones.Location = new System.Drawing.Point(24, 17);
            this.ListHabitaciones.Name = "ListHabitaciones";
            this.ListHabitaciones.Size = new System.Drawing.Size(86, 134);
            this.ListHabitaciones.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Desde:";
            // 
            // HastaPick
            // 
            this.HastaPick.Location = new System.Drawing.Point(59, 85);
            this.HastaPick.Name = "HastaPick";
            this.HastaPick.Size = new System.Drawing.Size(213, 20);
            this.HastaPick.TabIndex = 7;
            this.HastaPick.ValueChanged += new System.EventHandler(this.revalidarReserva);
            // 
            // DesdePick
            // 
            this.DesdePick.Location = new System.Drawing.Point(59, 59);
            this.DesdePick.Name = "DesdePick";
            this.DesdePick.Size = new System.Drawing.Size(213, 20);
            this.DesdePick.TabIndex = 6;
            this.DesdePick.ValueChanged += new System.EventHandler(this.revalidarReserva);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Regimen:";
            // 
            // TxtHotel
            // 
            this.TxtHotel.Location = new System.Drawing.Point(59, 28);
            this.TxtHotel.Name = "TxtHotel";
            this.TxtHotel.ReadOnly = true;
            this.TxtHotel.Size = new System.Drawing.Size(134, 20);
            this.TxtHotel.TabIndex = 2;
            // 
            // ElegirHotel
            // 
            this.ElegirHotel.Location = new System.Drawing.Point(199, 25);
            this.ElegirHotel.Name = "ElegirHotel";
            this.ElegirHotel.Size = new System.Drawing.Size(73, 24);
            this.ElegirHotel.TabIndex = 1;
            this.ElegirHotel.Text = "Seleccionar";
            this.ElegirHotel.UseVisualStyleBackColor = true;
            this.ElegirHotel.Click += new System.EventHandler(this.ElegirHotel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel:";
            // 
            // Reservar
            // 
            this.Reservar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Reservar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Reservar.FlatAppearance.BorderSize = 3;
            this.Reservar.Location = new System.Drawing.Point(0, 409);
            this.Reservar.Name = "Reservar";
            this.Reservar.Size = new System.Drawing.Size(701, 45);
            this.Reservar.TabIndex = 1;
            this.Reservar.Text = "RESERVAR";
            this.Reservar.UseVisualStyleBackColor = true;
            this.Reservar.Click += new System.EventHandler(this.Reservar_Click);
            // 
            // CancelarTodo
            // 
            this.CancelarTodo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarTodo.Location = new System.Drawing.Point(604, 292);
            this.CancelarTodo.Name = "CancelarTodo";
            this.CancelarTodo.Size = new System.Drawing.Size(84, 52);
            this.CancelarTodo.TabIndex = 6;
            this.CancelarTodo.Text = "CANCELAR TODO";
            this.CancelarTodo.UseVisualStyleBackColor = true;
            this.CancelarTodo.Click += new System.EventHandler(this.CancelarTodo_Click);
            // 
            // groupCliente
            // 
            this.groupCliente.Controls.Add(this.TxtDomicilio);
            this.groupCliente.Controls.Add(this.label29);
            this.groupCliente.Controls.Add(this.TxtCiudad);
            this.groupCliente.Controls.Add(this.label27);
            this.groupCliente.Controls.Add(this.TxtPais);
            this.groupCliente.Controls.Add(this.label25);
            this.groupCliente.Controls.Add(this.TxtTelefono);
            this.groupCliente.Controls.Add(this.label23);
            this.groupCliente.Controls.Add(this.TxtMail);
            this.groupCliente.Controls.Add(this.label21);
            this.groupCliente.Controls.Add(this.label11);
            this.groupCliente.Controls.Add(this.TxtNombre);
            this.groupCliente.Controls.Add(this.TxtNac);
            this.groupCliente.Controls.Add(this.label19);
            this.groupCliente.Controls.Add(this.label17);
            this.groupCliente.Controls.Add(this.TxtDoc);
            this.groupCliente.Enabled = false;
            this.groupCliente.Location = new System.Drawing.Point(8, 47);
            this.groupCliente.Name = "groupCliente";
            this.groupCliente.Size = new System.Drawing.Size(367, 343);
            this.groupCliente.TabIndex = 56;
            this.groupCliente.TabStop = false;
            this.groupCliente.Text = "Paso 1 - Datos del cliente";
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.AutoSize = true;
            this.TxtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDomicilio.Location = new System.Drawing.Point(73, 190);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(127, 15);
            this.TxtDomicilio.TabIndex = 71;
            this.TxtDomicilio.Text = "........................................";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(9, 190);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(62, 15);
            this.label29.TabIndex = 70;
            this.label29.Text = "Domicilio:";
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.AutoSize = true;
            this.TxtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCiudad.Location = new System.Drawing.Point(64, 215);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(61, 15);
            this.TxtCiudad.TabIndex = 69;
            this.TxtCiudad.Text = "..................";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(9, 215);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(49, 15);
            this.label27.TabIndex = 68;
            this.label27.Text = "Ciudad:";
            // 
            // TxtPais
            // 
            this.TxtPais.AutoSize = true;
            this.TxtPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPais.Location = new System.Drawing.Point(89, 91);
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(82, 15);
            this.TxtPais.TabIndex = 67;
            this.TxtPais.Text = ".........................";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(9, 91);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 15);
            this.label25.TabIndex = 66;
            this.label25.Text = "Nacionalidad:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.AutoSize = true;
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(73, 168);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(127, 15);
            this.TxtTelefono.TabIndex = 65;
            this.TxtTelefono.Text = "........................................";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(9, 168);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 15);
            this.label23.TabIndex = 64;
            this.label23.Text = "Teléfono:";
            // 
            // TxtMail
            // 
            this.TxtMail.AutoSize = true;
            this.TxtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMail.Location = new System.Drawing.Point(49, 143);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(124, 15);
            this.TxtMail.TabIndex = 63;
            this.TxtMail.Text = ".......................................";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(9, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 15);
            this.label21.TabIndex = 56;
            this.label21.Text = "Nombre y apellido: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 15);
            this.label11.TabIndex = 62;
            this.label11.Text = "Mail:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.AutoSize = true;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(128, 34);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(118, 15);
            this.TxtNombre.TabIndex = 57;
            this.TxtNombre.Text = ".....................................";
            // 
            // TxtNac
            // 
            this.TxtNac.AutoSize = true;
            this.TxtNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNac.Location = new System.Drawing.Point(140, 116);
            this.TxtNac.Name = "TxtNac";
            this.TxtNac.Size = new System.Drawing.Size(76, 15);
            this.TxtNac.TabIndex = 61;
            this.TxtNac.Text = ".......................";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(9, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(143, 15);
            this.label19.TabIndex = 58;
            this.label19.Text = "Tipo y N° de Documento:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(9, 116);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 15);
            this.label17.TabIndex = 60;
            this.label17.Text = "Fecha de nacimiento:";
            // 
            // TxtDoc
            // 
            this.TxtDoc.AutoSize = true;
            this.TxtDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDoc.Location = new System.Drawing.Point(158, 67);
            this.TxtDoc.Name = "TxtDoc";
            this.TxtDoc.Size = new System.Drawing.Size(73, 15);
            this.TxtDoc.TabIndex = 59;
            this.TxtDoc.Text = "......................";
            // 
            // BuscarCliente
            // 
            this.BuscarCliente.Location = new System.Drawing.Point(12, 12);
            this.BuscarCliente.Name = "BuscarCliente";
            this.BuscarCliente.Size = new System.Drawing.Size(85, 29);
            this.BuscarCliente.TabIndex = 57;
            this.BuscarCliente.Text = "Buscar Cliente";
            this.BuscarCliente.UseVisualStyleBackColor = true;
            this.BuscarCliente.Click += new System.EventHandler(this.BuscarCliente_Click);
            // 
            // groupHab
            // 
            this.groupHab.Controls.Add(this.PasoAtras);
            this.groupHab.Controls.Add(this.ListHabitaciones);
            this.groupHab.Controls.Add(this.QuitarHab);
            this.groupHab.Controls.Add(this.AgregarHab);
            this.groupHab.Enabled = false;
            this.groupHab.Location = new System.Drawing.Point(388, 184);
            this.groupHab.Name = "groupHab";
            this.groupHab.Size = new System.Drawing.Size(190, 198);
            this.groupHab.TabIndex = 58;
            this.groupHab.TabStop = false;
            this.groupHab.Text = "Paso 3 - Habitaciones a reservar";
            // 
            // ConfirmarDatosEstadia
            // 
            this.ConfirmarDatosEstadia.Location = new System.Drawing.Point(219, 137);
            this.ConfirmarDatosEstadia.Name = "ConfirmarDatosEstadia";
            this.ConfirmarDatosEstadia.Size = new System.Drawing.Size(75, 23);
            this.ConfirmarDatosEstadia.TabIndex = 15;
            this.ConfirmarDatosEstadia.Text = "CONFIRMA";
            this.ConfirmarDatosEstadia.UseVisualStyleBackColor = true;
            this.ConfirmarDatosEstadia.Click += new System.EventHandler(this.ConfirmarDatosEstadia_Click);
            // 
            // PasoAtras
            // 
            this.PasoAtras.Location = new System.Drawing.Point(116, 169);
            this.PasoAtras.Name = "PasoAtras";
            this.PasoAtras.Size = new System.Drawing.Size(68, 23);
            this.PasoAtras.TabIndex = 16;
            this.PasoAtras.Text = "Paso atrás";
            this.PasoAtras.UseVisualStyleBackColor = true;
            this.PasoAtras.Click += new System.EventHandler(this.PasoAtras_Click);
            // 
            // GenerarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 454);
            this.Controls.Add(this.groupHab);
            this.Controls.Add(this.BuscarCliente);
            this.Controls.Add(this.groupCliente);
            this.Controls.Add(this.CancelarTodo);
            this.Controls.Add(this.group3);
            this.Controls.Add(this.Reservar);
            this.Name = "GenerarReserva";
            this.Text = "Nueva Reserva";
            this.Load += new System.EventHandler(this.GenerarReserva_Load);
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.groupCliente.ResumeLayout(false);
            this.groupCliente.PerformLayout();
            this.groupHab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtHotel;
        private System.Windows.Forms.Button ElegirHotel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker HastaPick;
        private System.Windows.Forms.DateTimePicker DesdePick;
        private System.Windows.Forms.Button Reservar;
        private System.Windows.Forms.ListBox ListHabitaciones;
        private System.Windows.Forms.Button QuitarHab;
        private System.Windows.Forms.Button AgregarHab;
        private System.Windows.Forms.Button CancelarTodo;
        private System.Windows.Forms.GroupBox groupCliente;
        private System.Windows.Forms.Label TxtDomicilio;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label TxtCiudad;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label TxtPais;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label TxtTelefono;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label TxtMail;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TxtNombre;
        private System.Windows.Forms.Label TxtNac;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label TxtDoc;
        private System.Windows.Forms.Button BuscarCliente;
        private System.Windows.Forms.ComboBox ComboRegimen;
        private System.Windows.Forms.GroupBox groupHab;
        private System.Windows.Forms.Button ConfirmarDatosEstadia;
        private System.Windows.Forms.Button PasoAtras;
    }
}