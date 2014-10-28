namespace FrbaHotel.Registrar_Estadia
{
    partial class CheckIn
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
            this.VerDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QuitarPersona = new System.Windows.Forms.Button();
            this.AgregarPersona = new System.Windows.Forms.Button();
            this.ListPersonas = new System.Windows.Forms.ListBox();
            this.label30 = new System.Windows.Forms.Label();
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
            this.TxtFecFin = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtFecInicio = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtFecReserva = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtRegimen = new System.Windows.Forms.Label();
            this.TxtHotel = new System.Windows.Forms.Label();
            this.ListHabitaciones = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.RealizarIngreso = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // VerDatos
            // 
            this.VerDatos.Location = new System.Drawing.Point(226, 13);
            this.VerDatos.Name = "VerDatos";
            this.VerDatos.Size = new System.Drawing.Size(110, 20);
            this.VerDatos.TabIndex = 11;
            this.VerDatos.Text = "VER DATOS";
            this.VerDatos.UseVisualStyleBackColor = true;
            this.VerDatos.Click += new System.EventHandler(this.VerDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código de la reserva:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TxtFecFin);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.TxtFecInicio);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TxtFecReserva);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtRegimen);
            this.groupBox1.Controls.Add(this.TxtHotel);
            this.groupBox1.Controls.Add(this.ListHabitaciones);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 381);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del hotel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.QuitarPersona);
            this.groupBox2.Controls.Add(this.AgregarPersona);
            this.groupBox2.Controls.Add(this.ListPersonas);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.TxtDomicilio);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.TxtCiudad);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.TxtPais);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.TxtTelefono);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.TxtMail);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TxtNombre);
            this.groupBox2.Controls.Add(this.TxtNac);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.TxtDoc);
            this.groupBox2.Location = new System.Drawing.Point(214, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 344);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del cliente";
            // 
            // QuitarPersona
            // 
            this.QuitarPersona.Location = new System.Drawing.Point(368, 309);
            this.QuitarPersona.Name = "QuitarPersona";
            this.QuitarPersona.Size = new System.Drawing.Size(76, 19);
            this.QuitarPersona.TabIndex = 75;
            this.QuitarPersona.Text = "QUITAR";
            this.QuitarPersona.UseVisualStyleBackColor = true;
            // 
            // AgregarPersona
            // 
            this.AgregarPersona.Location = new System.Drawing.Point(368, 284);
            this.AgregarPersona.Name = "AgregarPersona";
            this.AgregarPersona.Size = new System.Drawing.Size(76, 19);
            this.AgregarPersona.TabIndex = 74;
            this.AgregarPersona.Text = "AGREGAR";
            this.AgregarPersona.UseVisualStyleBackColor = true;
            // 
            // ListPersonas
            // 
            this.ListPersonas.FormattingEnabled = true;
            this.ListPersonas.Location = new System.Drawing.Point(221, 209);
            this.ListPersonas.Name = "ListPersonas";
            this.ListPersonas.Size = new System.Drawing.Size(140, 121);
            this.ListPersonas.TabIndex = 73;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(216, 190);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(92, 15);
            this.label30.TabIndex = 72;
            this.label30.Text = "Acompañantes:";
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.AutoSize = true;
            this.TxtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDomicilio.Location = new System.Drawing.Point(70, 158);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(127, 15);
            this.TxtDomicilio.TabIndex = 71;
            this.TxtDomicilio.Text = "........................................";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(6, 158);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(62, 15);
            this.label29.TabIndex = 70;
            this.label29.Text = "Domicilio:";
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.AutoSize = true;
            this.TxtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCiudad.Location = new System.Drawing.Point(61, 183);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(61, 15);
            this.TxtCiudad.TabIndex = 69;
            this.TxtCiudad.Text = "..................";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(6, 183);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(49, 15);
            this.label27.TabIndex = 68;
            this.label27.Text = "Ciudad:";
            // 
            // TxtPais
            // 
            this.TxtPais.AutoSize = true;
            this.TxtPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPais.Location = new System.Drawing.Point(347, 59);
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(82, 15);
            this.TxtPais.TabIndex = 67;
            this.TxtPais.Text = ".........................";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(267, 59);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 15);
            this.label25.TabIndex = 66;
            this.label25.Text = "Nacionalidad:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.AutoSize = true;
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(70, 136);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(127, 15);
            this.TxtTelefono.TabIndex = 65;
            this.TxtTelefono.Text = "........................................";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 136);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 15);
            this.label23.TabIndex = 64;
            this.label23.Text = "Teléfono:";
            // 
            // TxtMail
            // 
            this.TxtMail.AutoSize = true;
            this.TxtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMail.Location = new System.Drawing.Point(46, 111);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(124, 15);
            this.TxtMail.TabIndex = 63;
            this.TxtMail.Text = ".......................................";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 15);
            this.label21.TabIndex = 56;
            this.label21.Text = "Nombre y apellido: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 15);
            this.label11.TabIndex = 62;
            this.label11.Text = "Mail:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.AutoSize = true;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(125, 26);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(118, 15);
            this.TxtNombre.TabIndex = 57;
            this.TxtNombre.Text = ".....................................";
            // 
            // TxtNac
            // 
            this.TxtNac.AutoSize = true;
            this.TxtNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNac.Location = new System.Drawing.Point(137, 84);
            this.TxtNac.Name = "TxtNac";
            this.TxtNac.Size = new System.Drawing.Size(76, 15);
            this.TxtNac.TabIndex = 61;
            this.TxtNac.Text = ".......................";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(143, 15);
            this.label19.TabIndex = 58;
            this.label19.Text = "Tipo y N° de Documento:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 15);
            this.label17.TabIndex = 60;
            this.label17.Text = "Fecha de nacimiento:";
            // 
            // TxtDoc
            // 
            this.TxtDoc.AutoSize = true;
            this.TxtDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDoc.Location = new System.Drawing.Point(155, 59);
            this.TxtDoc.Name = "TxtDoc";
            this.TxtDoc.Size = new System.Drawing.Size(73, 15);
            this.TxtDoc.TabIndex = 59;
            this.TxtDoc.Text = "......................";
            // 
            // TxtFecFin
            // 
            this.TxtFecFin.AutoSize = true;
            this.TxtFecFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecFin.Location = new System.Drawing.Point(125, 319);
            this.TxtFecFin.Name = "TxtFecFin";
            this.TxtFecFin.Size = new System.Drawing.Size(49, 15);
            this.TxtFecFin.TabIndex = 54;
            this.TxtFecFin.Text = "..............";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 319);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 15);
            this.label16.TabIndex = 53;
            this.label16.Text = "Fin de la reserva:";
            // 
            // TxtFecInicio
            // 
            this.TxtFecInicio.AutoSize = true;
            this.TxtFecInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecInicio.Location = new System.Drawing.Point(124, 292);
            this.TxtFecInicio.Name = "TxtFecInicio";
            this.TxtFecInicio.Size = new System.Drawing.Size(49, 15);
            this.TxtFecInicio.TabIndex = 52;
            this.TxtFecInicio.Text = "..............";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 15);
            this.label14.TabIndex = 51;
            this.label14.Text = "Fecha de ingreso:";
            // 
            // TxtFecReserva
            // 
            this.TxtFecReserva.AutoSize = true;
            this.TxtFecReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecReserva.Location = new System.Drawing.Point(124, 267);
            this.TxtFecReserva.Name = "TxtFecReserva";
            this.TxtFecReserva.Size = new System.Drawing.Size(40, 15);
            this.TxtFecReserva.TabIndex = 50;
            this.TxtFecReserva.Text = "...........";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 15);
            this.label9.TabIndex = 49;
            this.label9.Text = "Fecha de reserva:";
            // 
            // TxtRegimen
            // 
            this.TxtRegimen.AutoSize = true;
            this.TxtRegimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegimen.Location = new System.Drawing.Point(81, 234);
            this.TxtRegimen.Name = "TxtRegimen";
            this.TxtRegimen.Size = new System.Drawing.Size(49, 15);
            this.TxtRegimen.TabIndex = 48;
            this.TxtRegimen.Text = "..............";
            // 
            // TxtHotel
            // 
            this.TxtHotel.AutoSize = true;
            this.TxtHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHotel.Location = new System.Drawing.Point(58, 57);
            this.TxtHotel.Name = "TxtHotel";
            this.TxtHotel.Size = new System.Drawing.Size(49, 15);
            this.TxtHotel.TabIndex = 47;
            this.TxtHotel.Text = "..............";
            // 
            // ListHabitaciones
            // 
            this.ListHabitaciones.FormattingEnabled = true;
            this.ListHabitaciones.Location = new System.Drawing.Point(17, 103);
            this.ListHabitaciones.Name = "ListHabitaciones";
            this.ListHabitaciones.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ListHabitaciones.Size = new System.Drawing.Size(140, 121);
            this.ListHabitaciones.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 42;
            this.label10.Text = "Régimen:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "Habitaciones reservadas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Hotel:";
            // 
            // TxtId
            // 
            this.TxtId.AutoSize = true;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(48, 28);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(58, 18);
            this.TxtId.TabIndex = 24;
            this.TxtId.Text = "..........";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(140, 12);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(80, 20);
            this.TxtCodigo.TabIndex = 12;
            // 
            // RealizarIngreso
            // 
            this.RealizarIngreso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RealizarIngreso.Enabled = false;
            this.RealizarIngreso.Location = new System.Drawing.Point(0, 429);
            this.RealizarIngreso.Name = "RealizarIngreso";
            this.RealizarIngreso.Size = new System.Drawing.Size(703, 58);
            this.RealizarIngreso.TabIndex = 13;
            this.RealizarIngreso.Text = "REALIZAR INGRESO AL HOTEL";
            this.RealizarIngreso.UseVisualStyleBackColor = true;
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 487);
            this.Controls.Add(this.RealizarIngreso);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.VerDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CheckIn";
            this.Text = "Check In";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VerDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label TxtHotel;
        private System.Windows.Forms.ListBox ListHabitaciones;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TxtFecFin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label TxtFecInicio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label TxtFecReserva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TxtRegimen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label TxtMail;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TxtNombre;
        private System.Windows.Forms.Label TxtNac;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label TxtDoc;
        private System.Windows.Forms.Label TxtDomicilio;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label TxtCiudad;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label TxtPais;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label TxtTelefono;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button QuitarPersona;
        private System.Windows.Forms.Button AgregarPersona;
        private System.Windows.Forms.ListBox ListPersonas;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button RealizarIngreso;
    }
}