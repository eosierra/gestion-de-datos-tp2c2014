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
            this.GridResults = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbListado = new System.Windows.Forms.ComboBox();
            this.CbPeriodo = new System.Windows.Forms.ComboBox();
            this.VerDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CargandoText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridResults
            // 
            this.GridResults.AllowUserToAddRows = false;
            this.GridResults.AllowUserToDeleteRows = false;
            this.GridResults.AllowUserToResizeColumns = false;
            this.GridResults.AllowUserToResizeRows = false;
            this.GridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.GridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResults.Location = new System.Drawing.Point(12, 142);
            this.GridResults.MultiSelect = false;
            this.GridResults.Name = "GridResults";
            this.GridResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridResults.Size = new System.Drawing.Size(603, 183);
            this.GridResults.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.VerDatos);
            this.groupBox1.Controls.Add(this.CbListado);
            this.groupBox1.Controls.Add(this.CbPeriodo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros de búsqueda";
            // 
            // CbListado
            // 
            this.CbListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbListado.FormattingEnabled = true;
            this.CbListado.Items.AddRange(new object[] {
            "1) Hoteles con mayor cantidad de reservas canceladas",
            "2) Hoteles con mayor cantidad de consumibles facturados",
            "3) Hoteles con mayor cantidad de días fuera de servicio",
            "4) Habitaciones con mayor cantidad de días y veces que fueron ocupadas",
            "5) Clientes con mayor cantidad de puntos"});
            this.CbListado.Location = new System.Drawing.Point(72, 28);
            this.CbListado.Name = "CbListado";
            this.CbListado.Size = new System.Drawing.Size(385, 21);
            this.CbListado.TabIndex = 2;
            // 
            // CbPeriodo
            // 
            this.CbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPeriodo.FormattingEnabled = true;
            this.CbPeriodo.Location = new System.Drawing.Point(72, 55);
            this.CbPeriodo.Name = "CbPeriodo";
            this.CbPeriodo.Size = new System.Drawing.Size(252, 21);
            this.CbPeriodo.TabIndex = 1;
            // 
            // VerDatos
            // 
            this.VerDatos.Location = new System.Drawing.Point(463, 28);
            this.VerDatos.Name = "VerDatos";
            this.VerDatos.Size = new System.Drawing.Size(123, 48);
            this.VerDatos.TabIndex = 3;
            this.VerDatos.Text = "VER INFORME";
            this.VerDatos.UseVisualStyleBackColor = true;
            this.VerDatos.Click += new System.EventHandler(this.VerDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Período:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Listado:";
            // 
            // CargandoText
            // 
            this.CargandoText.AutoSize = true;
            this.CargandoText.Location = new System.Drawing.Point(12, 123);
            this.CargandoText.Name = "CargandoText";
            this.CargandoText.Size = new System.Drawing.Size(113, 13);
            this.CargandoText.TabIndex = 2;
            this.CargandoText.Text = "Cargando resultados...";
            this.CargandoText.Visible = false;
            // 
            // Estadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 337);
            this.Controls.Add(this.CargandoText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridResults);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Estadistica";
            this.Text = "Estadísticas";
            ((System.ComponentModel.ISupportInitialize)(this.GridResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbPeriodo;
        private System.Windows.Forms.ComboBox CbListado;
        private System.Windows.Forms.Button VerDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CargandoText;
    }
}