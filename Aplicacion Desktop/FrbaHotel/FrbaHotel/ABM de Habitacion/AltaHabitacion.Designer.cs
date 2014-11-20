namespace FrbaHotel.ABM_de_Habitacion
{
    partial class AltaHabitacion
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
            this.Guardar = new System.Windows.Forms.Button();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.Interior = new System.Windows.Forms.RadioButton();
            this.Exterior = new System.Windows.Forms.RadioButton();
            this.TxtPiso = new System.Windows.Forms.TextBox();
            this.TxtNro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkHabilitada = new System.Windows.Forms.CheckBox();
            this.ElegirHotel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtHotel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Guardar.Location = new System.Drawing.Point(43, 288);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(233, 23);
            this.Guardar.TabIndex = 23;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(129, 174);
            this.TxtDesc.Multiline = true;
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(147, 85);
            this.TxtDesc.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Comodidades";
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Location = new System.Drawing.Point(129, 147);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(147, 21);
            this.CmbTipo.TabIndex = 20;
            // 
            // Interior
            // 
            this.Interior.AccessibleName = "N";
            this.Interior.AutoSize = true;
            this.Interior.Location = new System.Drawing.Point(129, 124);
            this.Interior.Name = "Interior";
            this.Interior.Size = new System.Drawing.Size(58, 17);
            this.Interior.TabIndex = 19;
            this.Interior.TabStop = true;
            this.Interior.Text = "Interna";
            this.Interior.UseVisualStyleBackColor = true;
            // 
            // Exterior
            // 
            this.Exterior.AccessibleName = "S";
            this.Exterior.AutoSize = true;
            this.Exterior.Location = new System.Drawing.Point(129, 101);
            this.Exterior.Name = "Exterior";
            this.Exterior.Size = new System.Drawing.Size(96, 17);
            this.Exterior.TabIndex = 18;
            this.Exterior.TabStop = true;
            this.Exterior.Text = "Vista al exterior";
            this.Exterior.UseVisualStyleBackColor = true;
            // 
            // TxtPiso
            // 
            this.TxtPiso.Location = new System.Drawing.Point(129, 73);
            this.TxtPiso.Name = "TxtPiso";
            this.TxtPiso.Size = new System.Drawing.Size(57, 20);
            this.TxtPiso.TabIndex = 17;
            this.TxtPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // TxtNro
            // 
            this.TxtNro.Location = new System.Drawing.Point(129, 47);
            this.TxtNro.Name = "TxtNro";
            this.TxtNro.Size = new System.Drawing.Size(57, 20);
            this.TxtNro.TabIndex = 16;
            this.TxtNro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo de Habitación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ubicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Piso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Número";
            // 
            // ChkHabilitada
            // 
            this.ChkHabilitada.AutoSize = true;
            this.ChkHabilitada.Location = new System.Drawing.Point(129, 265);
            this.ChkHabilitada.Name = "ChkHabilitada";
            this.ChkHabilitada.Size = new System.Drawing.Size(73, 17);
            this.ChkHabilitada.TabIndex = 24;
            this.ChkHabilitada.Text = "Habilitada";
            this.ChkHabilitada.UseVisualStyleBackColor = true;
            // 
            // ElegirHotel
            // 
            this.ElegirHotel.Location = new System.Drawing.Point(206, 12);
            this.ElegirHotel.Name = "ElegirHotel";
            this.ElegirHotel.Size = new System.Drawing.Size(92, 20);
            this.ElegirHotel.TabIndex = 26;
            this.ElegirHotel.Text = "SELECCIONAR";
            this.ElegirHotel.UseVisualStyleBackColor = true;
            this.ElegirHotel.Click += new System.EventHandler(this.ElegirHotel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "HOTEL:";
            // 
            // TxtHotel
            // 
            this.TxtHotel.Location = new System.Drawing.Point(64, 13);
            this.TxtHotel.Name = "TxtHotel";
            this.TxtHotel.ReadOnly = true;
            this.TxtHotel.Size = new System.Drawing.Size(136, 20);
            this.TxtHotel.TabIndex = 27;
            // 
            // AltaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 335);
            this.Controls.Add(this.TxtHotel);
            this.Controls.Add(this.ElegirHotel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ChkHabilitada);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.Interior);
            this.Controls.Add(this.Exterior);
            this.Controls.Add(this.TxtPiso);
            this.Controls.Add(this.TxtNro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaHabitacion";
            this.Text = "Alta Habitacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.RadioButton Interior;
        private System.Windows.Forms.RadioButton Exterior;
        private System.Windows.Forms.TextBox TxtPiso;
        private System.Windows.Forms.TextBox TxtNro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkHabilitada;
        private System.Windows.Forms.Button ElegirHotel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtHotel;
    }
}