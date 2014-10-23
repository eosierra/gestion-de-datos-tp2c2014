namespace FrbaHotel.ABM_de_Hotel
{
    partial class BuscarPais
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
            this.GridPaises = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Seleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridPaises)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridPaises
            // 
            this.GridPaises.AllowUserToAddRows = false;
            this.GridPaises.AllowUserToDeleteRows = false;
            this.GridPaises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPaises.Location = new System.Drawing.Point(12, 73);
            this.GridPaises.Name = "GridPaises";
            this.GridPaises.ReadOnly = true;
            this.GridPaises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPaises.Size = new System.Drawing.Size(233, 353);
            this.GridPaises.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 65);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de selección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(9, 32);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(218, 20);
            this.TxtNombre.TabIndex = 6;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // Seleccionar
            // 
            this.Seleccionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Seleccionar.Location = new System.Drawing.Point(69, 432);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(108, 34);
            this.Seleccionar.TabIndex = 17;
            this.Seleccionar.Text = "SELECCIONAR";
            this.Seleccionar.UseVisualStyleBackColor = true;
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // BuscarPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 478);
            this.Controls.Add(this.Seleccionar);
            this.Controls.Add(this.GridPaises);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BuscarPais";
            this.Text = "Buscar Pais";
            this.Load += new System.EventHandler(this.BuscarPais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPaises)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridPaises;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button Seleccionar;
    }
}