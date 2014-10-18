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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ListHabitaciones = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HastaPick = new System.Windows.Forms.DateTimePicker();
            this.DesdePick = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ElegirRegimen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtHotel = new System.Windows.Forms.TextBox();
            this.ElegirHotel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Reservar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BuscarCliente = new System.Windows.Forms.Button();
            this.NuevoCliente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ListHabitaciones);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.HastaPick);
            this.groupBox1.Controls.Add(this.DesdePick);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.ElegirRegimen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtHotel);
            this.groupBox1.Controls.Add(this.ElegirHotel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(385, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paso 3 - Datos de la estadía";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Habitaciones a reservar:";
            // 
            // ListHabitaciones
            // 
            this.ListHabitaciones.FormattingEnabled = true;
            this.ListHabitaciones.Location = new System.Drawing.Point(9, 182);
            this.ListHabitaciones.Name = "ListHabitaciones";
            this.ListHabitaciones.Size = new System.Drawing.Size(72, 95);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 5;
            // 
            // ElegirRegimen
            // 
            this.ElegirRegimen.Location = new System.Drawing.Point(199, 116);
            this.ElegirRegimen.Name = "ElegirRegimen";
            this.ElegirRegimen.Size = new System.Drawing.Size(73, 24);
            this.ElegirRegimen.TabIndex = 4;
            this.ElegirRegimen.Text = "Seleccionar";
            this.ElegirRegimen.UseVisualStyleBackColor = true;
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
            this.Reservar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Reservar.FlatAppearance.BorderSize = 3;
            this.Reservar.Location = new System.Drawing.Point(0, 409);
            this.Reservar.Name = "Reservar";
            this.Reservar.Size = new System.Drawing.Size(701, 45);
            this.Reservar.TabIndex = 1;
            this.Reservar.Text = "RESERVAR";
            this.Reservar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BuscarCliente);
            this.groupBox2.Controls.Add(this.NuevoCliente);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 60);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paso 1 - Cliente encargado";
            // 
            // BuscarCliente
            // 
            this.BuscarCliente.Location = new System.Drawing.Point(180, 27);
            this.BuscarCliente.Name = "BuscarCliente";
            this.BuscarCliente.Size = new System.Drawing.Size(150, 23);
            this.BuscarCliente.TabIndex = 1;
            this.BuscarCliente.Text = "Cliente ya registrado";
            this.BuscarCliente.UseVisualStyleBackColor = true;
            // 
            // NuevoCliente
            // 
            this.NuevoCliente.Location = new System.Drawing.Point(18, 27);
            this.NuevoCliente.Name = "NuevoCliente";
            this.NuevoCliente.Size = new System.Drawing.Size(156, 23);
            this.NuevoCliente.TabIndex = 0;
            this.NuevoCliente.Text = "Cliente nuevo";
            this.NuevoCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 326);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paso 2 - Datos del cliente";
            // 
            // GenerarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 454);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Reservar);
            this.Name = "GenerarReserva";
            this.Text = "Nueva Reserva";
            this.Load += new System.EventHandler(this.GenerarReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ElegirRegimen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtHotel;
        private System.Windows.Forms.Button ElegirHotel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker HastaPick;
        private System.Windows.Forms.DateTimePicker DesdePick;
        private System.Windows.Forms.Button Reservar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BuscarCliente;
        private System.Windows.Forms.Button NuevoCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ListHabitaciones;
    }
}