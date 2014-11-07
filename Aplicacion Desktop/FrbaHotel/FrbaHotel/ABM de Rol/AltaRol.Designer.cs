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
            this.CheckActivo = new System.Windows.Forms.CheckBox();
            this.LimpiarTodo = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.TxtRol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmdAgregar = new System.Windows.Forms.Button();
            this.CmdQuitar = new System.Windows.Forms.Button();
            this.ListFunciones = new System.Windows.Forms.ListBox();
            this.Id_Rol = new System.Windows.Forms.Label();
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
            this.label3.Location = new System.Drawing.Point(31, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado:";
            // 
            // CheckActivo
            // 
            this.CheckActivo.AutoSize = true;
            this.CheckActivo.Location = new System.Drawing.Point(80, 298);
            this.CheckActivo.Name = "CheckActivo";
            this.CheckActivo.Size = new System.Drawing.Size(56, 17);
            this.CheckActivo.TabIndex = 3;
            this.CheckActivo.Text = "Activo";
            this.CheckActivo.UseVisualStyleBackColor = true;
            // 
            // LimpiarTodo
            // 
            this.LimpiarTodo.Location = new System.Drawing.Point(155, 329);
            this.LimpiarTodo.Name = "LimpiarTodo";
            this.LimpiarTodo.Size = new System.Drawing.Size(109, 24);
            this.LimpiarTodo.TabIndex = 5;
            this.LimpiarTodo.Text = "Limpiar pantalla";
            this.LimpiarTodo.UseVisualStyleBackColor = true;
            this.LimpiarTodo.Click += new System.EventHandler(this.LimpiarTodo_Click);
            // 
            // Guardar
            // 
            this.Guardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Guardar.Location = new System.Drawing.Point(26, 329);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(109, 24);
            this.Guardar.TabIndex = 6;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // TxtRol
            // 
            this.TxtRol.Location = new System.Drawing.Point(113, 38);
            this.TxtRol.Name = "TxtRol";
            this.TxtRol.Size = new System.Drawing.Size(151, 20);
            this.TxtRol.TabIndex = 7;
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
            this.CmdAgregar.Location = new System.Drawing.Point(203, 140);
            this.CmdAgregar.Name = "CmdAgregar";
            this.CmdAgregar.Size = new System.Drawing.Size(61, 24);
            this.CmdAgregar.TabIndex = 9;
            this.CmdAgregar.Text = "Agregar";
            this.CmdAgregar.UseVisualStyleBackColor = true;
            this.CmdAgregar.Click += new System.EventHandler(this.CmdAgregar_Click);
            // 
            // CmdQuitar
            // 
            this.CmdQuitar.Location = new System.Drawing.Point(203, 170);
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
            this.ListFunciones.Size = new System.Drawing.Size(139, 173);
            this.ListFunciones.TabIndex = 11;
            // 
            // Id_Rol
            // 
            this.Id_Rol.AutoSize = true;
            this.Id_Rol.Location = new System.Drawing.Point(21, 9);
            this.Id_Rol.Name = "Id_Rol";
            this.Id_Rol.Size = new System.Drawing.Size(38, 13);
            this.Id_Rol.TabIndex = 12;
            this.Id_Rol.Text = "Id_Rol";
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 371);
            this.Controls.Add(this.Id_Rol);
            this.Controls.Add(this.ListFunciones);
            this.Controls.Add(this.CmdQuitar);
            this.Controls.Add(this.CmdAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtRol);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.LimpiarTodo);
            this.Controls.Add(this.CheckActivo);
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
        private System.Windows.Forms.CheckBox CheckActivo;
        private System.Windows.Forms.Button LimpiarTodo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox TxtRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CmdAgregar;
        private System.Windows.Forms.Button CmdQuitar;
        private System.Windows.Forms.ListBox ListFunciones;
        private System.Windows.Forms.Label Id_Rol;
    }
}