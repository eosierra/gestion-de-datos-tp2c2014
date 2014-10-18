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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Mostrar = new System.Windows.Forms.Button();
            this.QuitarHab = new System.Windows.Forms.Button();
            this.AgregarHab = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ListHabitaciones = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HastaPick = new System.Windows.Forms.DateTimePicker();
            this.DesdePick = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ElegirRegimen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtHotel = new System.Windows.Forms.TextBox();
            this.ElegirHotel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ActualizarDatos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QuitarHab);
            this.groupBox1.Controls.Add(this.AgregarHab);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ListHabitaciones);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.HastaPick);
            this.groupBox1.Controls.Add(this.DesdePick);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.ElegirRegimen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtHotel);
            this.groupBox1.Controls.Add(this.ElegirHotel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(16, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la reserva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÓDIGO DE RESERVA:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(287, 32);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(110, 20);
            this.Mostrar.TabIndex = 3;
            this.Mostrar.Text = "MOSTRAR DATOS";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // QuitarHab
            // 
            this.QuitarHab.Location = new System.Drawing.Point(108, 229);
            this.QuitarHab.Name = "QuitarHab";
            this.QuitarHab.Size = new System.Drawing.Size(73, 24);
            this.QuitarHab.TabIndex = 27;
            this.QuitarHab.Text = "Quitar";
            this.QuitarHab.UseVisualStyleBackColor = true;
            // 
            // AgregarHab
            // 
            this.AgregarHab.Location = new System.Drawing.Point(108, 199);
            this.AgregarHab.Name = "AgregarHab";
            this.AgregarHab.Size = new System.Drawing.Size(73, 24);
            this.AgregarHab.TabIndex = 26;
            this.AgregarHab.Text = "Agregar";
            this.AgregarHab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Habitaciones a reservar:";
            // 
            // ListHabitaciones
            // 
            this.ListHabitaciones.FormattingEnabled = true;
            this.ListHabitaciones.Location = new System.Drawing.Point(16, 180);
            this.ListHabitaciones.Name = "ListHabitaciones";
            this.ListHabitaciones.Size = new System.Drawing.Size(72, 95);
            this.ListHabitaciones.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Desde:";
            // 
            // HastaPick
            // 
            this.HastaPick.Location = new System.Drawing.Point(66, 83);
            this.HastaPick.Name = "HastaPick";
            this.HastaPick.Size = new System.Drawing.Size(213, 20);
            this.HastaPick.TabIndex = 21;
            // 
            // DesdePick
            // 
            this.DesdePick.Location = new System.Drawing.Point(66, 57);
            this.DesdePick.Name = "DesdePick";
            this.DesdePick.Size = new System.Drawing.Size(213, 20);
            this.DesdePick.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 19;
            // 
            // ElegirRegimen
            // 
            this.ElegirRegimen.Location = new System.Drawing.Point(206, 114);
            this.ElegirRegimen.Name = "ElegirRegimen";
            this.ElegirRegimen.Size = new System.Drawing.Size(73, 24);
            this.ElegirRegimen.TabIndex = 18;
            this.ElegirRegimen.Text = "Seleccionar";
            this.ElegirRegimen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Regimen:";
            // 
            // TxtHotel
            // 
            this.TxtHotel.Location = new System.Drawing.Point(66, 26);
            this.TxtHotel.Name = "TxtHotel";
            this.TxtHotel.ReadOnly = true;
            this.TxtHotel.Size = new System.Drawing.Size(134, 20);
            this.TxtHotel.TabIndex = 16;
            // 
            // ElegirHotel
            // 
            this.ElegirHotel.Location = new System.Drawing.Point(206, 23);
            this.ElegirHotel.Name = "ElegirHotel";
            this.ElegirHotel.Size = new System.Drawing.Size(73, 24);
            this.ElegirHotel.TabIndex = 15;
            this.ElegirHotel.Text = "Seleccionar";
            this.ElegirHotel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hotel:";
            // 
            // ActualizarDatos
            // 
            this.ActualizarDatos.Location = new System.Drawing.Point(220, 376);
            this.ActualizarDatos.Name = "ActualizarDatos";
            this.ActualizarDatos.Size = new System.Drawing.Size(208, 40);
            this.ActualizarDatos.TabIndex = 4;
            this.ActualizarDatos.Text = "ACTUALIZAR DATOS DE LA RESERVA";
            this.ActualizarDatos.UseVisualStyleBackColor = true;
            // 
            // ModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 447);
            this.Controls.Add(this.ActualizarDatos);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarReserva";
            this.Text = "Modificar Reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.Button QuitarHab;
        private System.Windows.Forms.Button AgregarHab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ListHabitaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker HastaPick;
        private System.Windows.Forms.DateTimePicker DesdePick;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ElegirRegimen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtHotel;
        private System.Windows.Forms.Button ElegirHotel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ActualizarDatos;
    }
}