namespace FrbaHotel.Listado_Estadistico
{
    partial class Estadistica
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboEst = new System.Windows.Forms.ComboBox();
            this.CbPeriodo = new System.Windows.Forms.ComboBox();
            this.VerDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(90, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.VerDatos);
            this.groupBox1.Controls.Add(this.ComboEst);
            this.groupBox1.Controls.Add(this.CbPeriodo);
            this.groupBox1.Location = new System.Drawing.Point(23, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros de búsqueda";
            // 
            // ComboEst
            // 
            this.ComboEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboEst.FormattingEnabled = true;
            this.ComboEst.Items.AddRange(new object[] {
            "1) Hoteles con mayor cantidad de reservas canceladas",
            "2) Hoteles con mayor cantidad de consumibles facturados",
            "3) Hoteles con mayor cantidad de días fuera de servicio",
            "4) Habitaciones con mayor cantidad de días y veces que fueron ocupadas",
            "5) Clientes con mayor cantidad de puntos"});
            this.ComboEst.Location = new System.Drawing.Point(165, 75);
            this.ComboEst.Name = "ComboEst";
            this.ComboEst.Size = new System.Drawing.Size(385, 21);
            this.ComboEst.TabIndex = 2;
            // 
            // CbPeriodo
            // 
            this.CbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPeriodo.FormattingEnabled = true;
            this.CbPeriodo.Location = new System.Drawing.Point(19, 75);
            this.CbPeriodo.Name = "CbPeriodo";
            this.CbPeriodo.Size = new System.Drawing.Size(121, 21);
            this.CbPeriodo.TabIndex = 1;
            // 
            // VerDatos
            // 
            this.VerDatos.Location = new System.Drawing.Point(584, 57);
            this.VerDatos.Name = "VerDatos";
            this.VerDatos.Size = new System.Drawing.Size(123, 39);
            this.VerDatos.TabIndex = 3;
            this.VerDatos.Text = "VER INFORME";
            this.VerDatos.UseVisualStyleBackColor = true;
            this.VerDatos.Click += new System.EventHandler(this.VerDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Período:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Listado:";
            // 
            // Estadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Estadistica";
            this.Text = "Estadísticas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbPeriodo;
        private System.Windows.Forms.ComboBox ComboEst;
        private System.Windows.Forms.Button VerDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}