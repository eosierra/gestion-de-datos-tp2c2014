namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class ModificarReserva
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
            this.GroupReserva = new System.Windows.Forms.GroupBox();
            this.VerHabitaciones = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.GroupHabitaciones = new System.Windows.Forms.GroupBox();
            this.CbRegimen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ListHabitaciones = new System.Windows.Forms.ListBox();
            this.QuitarHab = new System.Windows.Forms.Button();
            this.AddHabitacion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.HotelClick = new System.Windows.Forms.Button();
            this.Hasta = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.Desde = new System.Windows.Forms.DateTimePicker();
            this.TxtHotel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtReserva = new System.Windows.Forms.TextBox();
            this.MostrarDatos = new System.Windows.Forms.Button();
            this.ActualizarDatos = new System.Windows.Forms.Button();
            this.CancelarTodo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Motivo = new System.Windows.Forms.TextBox();
            this.GroupReserva.SuspendLayout();
            this.GroupHabitaciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupReserva
            // 
            this.GroupReserva.Controls.Add(this.groupBox1);
            this.GroupReserva.Controls.Add(this.VerHabitaciones);
            this.GroupReserva.Controls.Add(this.label8);
            this.GroupReserva.Controls.Add(this.GroupHabitaciones);
            this.GroupReserva.Controls.Add(this.label9);
            this.GroupReserva.Controls.Add(this.HotelClick);
            this.GroupReserva.Controls.Add(this.Hasta);
            this.GroupReserva.Controls.Add(this.label10);
            this.GroupReserva.Controls.Add(this.Desde);
            this.GroupReserva.Controls.Add(this.TxtHotel);
            this.GroupReserva.Enabled = false;
            this.GroupReserva.Location = new System.Drawing.Point(9, 37);
            this.GroupReserva.Name = "GroupReserva";
            this.GroupReserva.Size = new System.Drawing.Size(758, 194);
            this.GroupReserva.TabIndex = 0;
            this.GroupReserva.TabStop = false;
            this.GroupReserva.Text = "Datos de la reserva";
            // 
            // VerHabitaciones
            // 
            this.VerHabitaciones.Location = new System.Drawing.Point(254, 129);
            this.VerHabitaciones.Name = "VerHabitaciones";
            this.VerHabitaciones.Size = new System.Drawing.Size(32, 24);
            this.VerHabitaciones.TabIndex = 61;
            this.VerHabitaciones.Text = ">>";
            this.VerHabitaciones.UseVisualStyleBackColor = true;
            this.VerHabitaciones.Click += new System.EventHandler(this.VerHabitaciones_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Hasta:";
            // 
            // GroupHabitaciones
            // 
            this.GroupHabitaciones.Controls.Add(this.CbRegimen);
            this.GroupHabitaciones.Controls.Add(this.label7);
            this.GroupHabitaciones.Controls.Add(this.ListHabitaciones);
            this.GroupHabitaciones.Controls.Add(this.QuitarHab);
            this.GroupHabitaciones.Controls.Add(this.AddHabitacion);
            this.GroupHabitaciones.Enabled = false;
            this.GroupHabitaciones.Location = new System.Drawing.Point(303, 19);
            this.GroupHabitaciones.Name = "GroupHabitaciones";
            this.GroupHabitaciones.Size = new System.Drawing.Size(210, 159);
            this.GroupHabitaciones.TabIndex = 60;
            this.GroupHabitaciones.TabStop = false;
            this.GroupHabitaciones.Text = "Habitaciones a reservar";
            // 
            // CbRegimen
            // 
            this.CbRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRegimen.FormattingEnabled = true;
            this.CbRegimen.Location = new System.Drawing.Point(65, 22);
            this.CbRegimen.Name = "CbRegimen";
            this.CbRegimen.Size = new System.Drawing.Size(128, 21);
            this.CbRegimen.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Regimen:";
            // 
            // ListHabitaciones
            // 
            this.ListHabitaciones.FormattingEnabled = true;
            this.ListHabitaciones.Location = new System.Drawing.Point(26, 63);
            this.ListHabitaciones.Name = "ListHabitaciones";
            this.ListHabitaciones.Size = new System.Drawing.Size(86, 82);
            this.ListHabitaciones.Sorted = true;
            this.ListHabitaciones.TabIndex = 10;
            // 
            // QuitarHab
            // 
            this.QuitarHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitarHab.Location = new System.Drawing.Point(118, 95);
            this.QuitarHab.Name = "QuitarHab";
            this.QuitarHab.Size = new System.Drawing.Size(23, 24);
            this.QuitarHab.TabIndex = 13;
            this.QuitarHab.Text = "-";
            this.QuitarHab.UseVisualStyleBackColor = true;
            this.QuitarHab.Click += new System.EventHandler(this.QuitarHab_Click);
            // 
            // AddHabitacion
            // 
            this.AddHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHabitacion.Location = new System.Drawing.Point(118, 65);
            this.AddHabitacion.Name = "AddHabitacion";
            this.AddHabitacion.Size = new System.Drawing.Size(23, 24);
            this.AddHabitacion.TabIndex = 12;
            this.AddHabitacion.Text = "+";
            this.AddHabitacion.UseVisualStyleBackColor = true;
            this.AddHabitacion.Click += new System.EventHandler(this.AddHabitacion_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Desde:";
            // 
            // HotelClick
            // 
            this.HotelClick.Location = new System.Drawing.Point(213, 33);
            this.HotelClick.Name = "HotelClick";
            this.HotelClick.Size = new System.Drawing.Size(73, 24);
            this.HotelClick.TabIndex = 20;
            this.HotelClick.Text = "Seleccionar";
            this.HotelClick.UseVisualStyleBackColor = true;
            this.HotelClick.Click += new System.EventHandler(this.HotelClick_Click);
            // 
            // Hasta
            // 
            this.Hasta.Location = new System.Drawing.Point(73, 93);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(213, 20);
            this.Hasta.TabIndex = 23;
            this.Hasta.ValueChanged += new System.EventHandler(this.revalidarFecha);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Hotel:";
            // 
            // Desde
            // 
            this.Desde.Location = new System.Drawing.Point(73, 67);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(213, 20);
            this.Desde.TabIndex = 22;
            this.Desde.ValueChanged += new System.EventHandler(this.revalidarFecha);
            // 
            // TxtHotel
            // 
            this.TxtHotel.Location = new System.Drawing.Point(73, 36);
            this.TxtHotel.Name = "TxtHotel";
            this.TxtHotel.ReadOnly = true;
            this.TxtHotel.Size = new System.Drawing.Size(134, 20);
            this.TxtHotel.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÓDIGO DE RESERVA:";
            // 
            // TxtReserva
            // 
            this.TxtReserva.Location = new System.Drawing.Point(138, 11);
            this.TxtReserva.Name = "TxtReserva";
            this.TxtReserva.Size = new System.Drawing.Size(114, 20);
            this.TxtReserva.TabIndex = 2;
            this.TxtReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtReserva_KeyPress);
            // 
            // MostrarDatos
            // 
            this.MostrarDatos.Location = new System.Drawing.Point(269, 11);
            this.MostrarDatos.Name = "MostrarDatos";
            this.MostrarDatos.Size = new System.Drawing.Size(110, 20);
            this.MostrarDatos.TabIndex = 3;
            this.MostrarDatos.Text = "MOSTRAR DATOS";
            this.MostrarDatos.UseVisualStyleBackColor = true;
            this.MostrarDatos.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // ActualizarDatos
            // 
            this.ActualizarDatos.Location = new System.Drawing.Point(12, 237);
            this.ActualizarDatos.Name = "ActualizarDatos";
            this.ActualizarDatos.Size = new System.Drawing.Size(642, 40);
            this.ActualizarDatos.TabIndex = 4;
            this.ActualizarDatos.Text = "ACTUALIZAR DATOS DE LA RESERVA";
            this.ActualizarDatos.UseVisualStyleBackColor = true;
            this.ActualizarDatos.Click += new System.EventHandler(this.ActualizarDatos_Click);
            // 
            // CancelarTodo
            // 
            this.CancelarTodo.Location = new System.Drawing.Point(660, 237);
            this.CancelarTodo.Name = "CancelarTodo";
            this.CancelarTodo.Size = new System.Drawing.Size(107, 40);
            this.CancelarTodo.TabIndex = 5;
            this.CancelarTodo.Text = "CANCELAR MODIFICACION";
            this.CancelarTodo.UseVisualStyleBackColor = true;
            this.CancelarTodo.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Motivo);
            this.groupBox1.Location = new System.Drawing.Point(520, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 158);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motivo de la modificación";
            // 
            // Motivo
            // 
            this.Motivo.Location = new System.Drawing.Point(7, 16);
            this.Motivo.MaxLength = 140;
            this.Motivo.Multiline = true;
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(219, 128);
            this.Motivo.TabIndex = 0;
            // 
            // ModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 287);
            this.Controls.Add(this.CancelarTodo);
            this.Controls.Add(this.ActualizarDatos);
            this.Controls.Add(this.MostrarDatos);
            this.Controls.Add(this.TxtReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupReserva);
            this.Name = "ModificarReserva";
            this.Text = "Modificar Reserva";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarReserva_FormClosing);
            this.GroupReserva.ResumeLayout(false);
            this.GroupReserva.PerformLayout();
            this.GroupHabitaciones.ResumeLayout(false);
            this.GroupHabitaciones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtReserva;
        private System.Windows.Forms.Button MostrarDatos;
        private System.Windows.Forms.Button ActualizarDatos;
        private System.Windows.Forms.GroupBox GroupHabitaciones;
        private System.Windows.Forms.ComboBox CbRegimen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox ListHabitaciones;
        private System.Windows.Forms.Button QuitarHab;
        private System.Windows.Forms.Button AddHabitacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button HotelClick;
        private System.Windows.Forms.DateTimePicker Hasta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker Desde;
        private System.Windows.Forms.TextBox TxtHotel;
        private System.Windows.Forms.Button CancelarTodo;
        private System.Windows.Forms.Button VerHabitaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Motivo;
    }
}