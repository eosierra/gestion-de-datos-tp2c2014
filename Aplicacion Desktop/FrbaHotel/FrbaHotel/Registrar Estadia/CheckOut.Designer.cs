namespace FrbaHotel.Registrar_Estadia
{
    partial class CheckOut
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
            this.TabSalida = new System.Windows.Forms.TabControl();
            this.TabConsumibles = new System.Windows.Forms.TabPage();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.GridConsumibles = new System.Windows.Forms.DataGridView();
            this.TxtConsumible = new System.Windows.Forms.TextBox();
            this.AgregarCarrito = new System.Windows.Forms.Button();
            this.Cantidad = new System.Windows.Forms.NumericUpDown();
            this.GridCarrito = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VerCO = new System.Windows.Forms.Button();
            this.TabSalida.SuspendLayout();
            this.TabConsumibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsumibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // TabSalida
            // 
            this.TabSalida.Controls.Add(this.TabConsumibles);
            this.TabSalida.Controls.Add(this.tabPage2);
            this.TabSalida.Enabled = false;
            this.TabSalida.Location = new System.Drawing.Point(12, 45);
            this.TabSalida.Name = "TabSalida";
            this.TabSalida.SelectedIndex = 0;
            this.TabSalida.Size = new System.Drawing.Size(1005, 487);
            this.TabSalida.TabIndex = 0;
            // 
            // TabConsumibles
            // 
            this.TabConsumibles.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TabConsumibles.Controls.Add(this.LblPrecio);
            this.TabConsumibles.Controls.Add(this.GridConsumibles);
            this.TabConsumibles.Controls.Add(this.TxtConsumible);
            this.TabConsumibles.Controls.Add(this.AgregarCarrito);
            this.TabConsumibles.Controls.Add(this.Cantidad);
            this.TabConsumibles.Controls.Add(this.GridCarrito);
            this.TabConsumibles.Location = new System.Drawing.Point(4, 22);
            this.TabConsumibles.Name = "TabConsumibles";
            this.TabConsumibles.Padding = new System.Windows.Forms.Padding(3);
            this.TabConsumibles.Size = new System.Drawing.Size(997, 461);
            this.TabConsumibles.TabIndex = 0;
            this.TabConsumibles.Text = "Registrar Consumibles";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(615, 102);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(46, 13);
            this.LblPrecio.TabIndex = 7;
            this.LblPrecio.Text = "$...........";
            // 
            // GridConsumibles
            // 
            this.GridConsumibles.AllowUserToAddRows = false;
            this.GridConsumibles.AllowUserToDeleteRows = false;
            this.GridConsumibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridConsumibles.Location = new System.Drawing.Point(6, 18);
            this.GridConsumibles.Name = "GridConsumibles";
            this.GridConsumibles.Size = new System.Drawing.Size(407, 377);
            this.GridConsumibles.TabIndex = 6;
            this.GridConsumibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridConsumibles_CellContentClick);
            // 
            // TxtConsumible
            // 
            this.TxtConsumible.Location = new System.Drawing.Point(419, 96);
            this.TxtConsumible.Name = "TxtConsumible";
            this.TxtConsumible.ReadOnly = true;
            this.TxtConsumible.Size = new System.Drawing.Size(129, 20);
            this.TxtConsumible.TabIndex = 5;
            // 
            // AgregarCarrito
            // 
            this.AgregarCarrito.Location = new System.Drawing.Point(419, 122);
            this.AgregarCarrito.Name = "AgregarCarrito";
            this.AgregarCarrito.Size = new System.Drawing.Size(253, 23);
            this.AgregarCarrito.TabIndex = 4;
            this.AgregarCarrito.Text = "AGREGAR AL CARRITO >>";
            this.AgregarCarrito.UseVisualStyleBackColor = true;
            this.AgregarCarrito.Click += new System.EventHandler(this.AgregarCarrito_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(554, 97);
            this.Cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(54, 20);
            this.Cantidad.TabIndex = 3;
            this.Cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Cantidad.ValueChanged += new System.EventHandler(this.Cantidad_ValueChanged);
            // 
            // GridCarrito
            // 
            this.GridCarrito.AllowUserToAddRows = false;
            this.GridCarrito.AllowUserToDeleteRows = false;
            this.GridCarrito.AllowUserToResizeColumns = false;
            this.GridCarrito.AllowUserToResizeRows = false;
            this.GridCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.GridCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCarrito.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.GridCarrito.Location = new System.Drawing.Point(678, 18);
            this.GridCarrito.Name = "GridCarrito";
            this.GridCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCarrito.Size = new System.Drawing.Size(313, 377);
            this.GridCarrito.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver factura";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código de reserva:";
            // 
            // VerCO
            // 
            this.VerCO.Location = new System.Drawing.Point(227, 17);
            this.VerCO.Name = "VerCO";
            this.VerCO.Size = new System.Drawing.Size(144, 23);
            this.VerCO.TabIndex = 3;
            this.VerCO.Text = "COMENZAR CHECK OUT";
            this.VerCO.UseVisualStyleBackColor = true;
            this.VerCO.Click += new System.EventHandler(this.VerCO_Click);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 544);
            this.Controls.Add(this.VerCO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TabSalida);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.TabSalida.ResumeLayout(false);
            this.TabConsumibles.ResumeLayout(false);
            this.TabConsumibles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsumibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabSalida;
        private System.Windows.Forms.TabPage TabConsumibles;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VerCO;
        private System.Windows.Forms.DataGridView GridCarrito;
        private System.Windows.Forms.Button AgregarCarrito;
        private System.Windows.Forms.NumericUpDown Cantidad;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.DataGridView GridConsumibles;
        private System.Windows.Forms.TextBox TxtConsumible;
    }
}