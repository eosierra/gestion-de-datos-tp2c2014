namespace FrbaHotel.ABM_de_Hotel
{
    partial class ModificarHotel
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
            this.ActualizarDatos = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboPais = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCalle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FechaPick = new System.Windows.Forms.DateTimePicker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ActualizarDatos
            // 
            this.ActualizarDatos.Location = new System.Drawing.Point(220, 390);
            this.ActualizarDatos.Name = "ActualizarDatos";
            this.ActualizarDatos.Size = new System.Drawing.Size(208, 40);
            this.ActualizarDatos.TabIndex = 9;
            this.ActualizarDatos.Text = "ACTUALIZAR DATOS";
            this.ActualizarDatos.UseVisualStyleBackColor = true;
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(287, 46);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(110, 20);
            this.Mostrar.TabIndex = 8;
            this.Mostrar.Text = "SELECCIONAR";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "HOTEL:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboPais);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtCiudad);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtNumero);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtCalle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtTelefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.FechaPick);
            this.groupBox1.Location = new System.Drawing.Point(16, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 294);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del hotel";
            // 
            // ComboPais
            // 
            this.ComboPais.FormattingEnabled = true;
            this.ComboPais.Location = new System.Drawing.Point(79, 183);
            this.ComboPais.Name = "ComboPais";
            this.ComboPais.Size = new System.Drawing.Size(141, 21);
            this.ComboPais.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "País:";
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Location = new System.Drawing.Point(79, 157);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(114, 20);
            this.TxtCiudad.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Ciudad:";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(226, 133);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(55, 20);
            this.TxtNumero.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "N°";
            // 
            // TxtCalle
            // 
            this.TxtCalle.Location = new System.Drawing.Point(79, 132);
            this.TxtCalle.Name = "TxtCalle";
            this.TxtCalle.Size = new System.Drawing.Size(114, 20);
            this.TxtCalle.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Calle:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(79, 107);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(114, 20);
            this.TxtTelefono.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Teléfono:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(63, 54);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(157, 20);
            this.TxtNombre.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nombre:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(79, 81);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(114, 20);
            this.TxtMail.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mail:";
            // 
            // TxtId
            // 
            this.TxtId.AutoSize = true;
            this.TxtId.Location = new System.Drawing.Point(38, 28);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(37, 13);
            this.TxtId.TabIndex = 24;
            this.TxtId.Text = "..........";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fecha de creación:";
            // 
            // FechaPick
            // 
            this.FechaPick.Location = new System.Drawing.Point(418, 28);
            this.FechaPick.Name = "FechaPick";
            this.FechaPick.Size = new System.Drawing.Size(213, 20);
            this.FechaPick.TabIndex = 21;
            // 
            // ModificarHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 477);
            this.Controls.Add(this.ActualizarDatos);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarHotel";
            this.Text = "Modificar Hotel";
            this.Load += new System.EventHandler(this.ModificarHotel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ActualizarDatos;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FechaPick;
        private System.Windows.Forms.Label TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtCalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboPais;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource bindingSource1;

    }
}