namespace FrbaHotel.ABM_de_Rol
{
    partial class AltaRol
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmdAgregar = new System.Windows.Forms.Button();
            this.CmdQuitar = new System.Windows.Forms.Button();
            this.ListFunciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(78, 395);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Limpiar pantalla";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Funcionalidades disponibles:";
            // 
            // CmdAgregar
            // 
            this.CmdAgregar.Location = new System.Drawing.Point(227, 140);
            this.CmdAgregar.Name = "CmdAgregar";
            this.CmdAgregar.Size = new System.Drawing.Size(61, 24);
            this.CmdAgregar.TabIndex = 9;
            this.CmdAgregar.Text = "Agregar";
            this.CmdAgregar.UseVisualStyleBackColor = true;
            this.CmdAgregar.Click += new System.EventHandler(this.CmdAgregar_Click);
            // 
            // CmdQuitar
            // 
            this.CmdQuitar.Location = new System.Drawing.Point(227, 170);
            this.CmdQuitar.Name = "CmdQuitar";
            this.CmdQuitar.Size = new System.Drawing.Size(61, 24);
            this.CmdQuitar.TabIndex = 10;
            this.CmdQuitar.Text = "Quitar";
            this.CmdQuitar.UseVisualStyleBackColor = true;
            this.CmdQuitar.Click += new System.EventHandler(this.CmdQuitar_Click);
            // 
            // ListFunciones
            // 
            this.ListFunciones.FormattingEnabled = true;
            this.ListFunciones.Location = new System.Drawing.Point(24, 114);
            this.ListFunciones.Name = "ListFunciones";
            this.ListFunciones.Size = new System.Drawing.Size(197, 264);
            this.ListFunciones.TabIndex = 11;
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 462);
            this.Controls.Add(this.ListFunciones);
            this.Controls.Add(this.CmdQuitar);
            this.Controls.Add(this.CmdAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AltaRol";
            this.Text = "Nuevo rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CmdAgregar;
        private System.Windows.Forms.Button CmdQuitar;
        private System.Windows.Forms.ListBox ListFunciones;
    }
}