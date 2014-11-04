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
            this.LblPrecio = new System.Windows.Forms.Label();
            this.GridConsumibles = new System.Windows.Forms.DataGridView();
            this.TxtConsumible = new System.Windows.Forms.TextBox();
            this.AgregarCarrito = new System.Windows.Forms.Button();
            this.Cantidad = new System.Windows.Forms.NumericUpDown();
            this.GridCarrito = new System.Windows.Forms.DataGridView();
            this.ColumnaEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TxtReserva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VerCO = new System.Windows.Forms.Button();
            this.GroupConsumibles = new System.Windows.Forms.GroupBox();
            this.LabelAllinc = new System.Windows.Forms.Label();
            this.GroupHabitacion = new System.Windows.Forms.GroupBox();
            this.GridHabitacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsumibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCarrito)).BeginInit();
            this.GroupConsumibles.SuspendLayout();
            this.GroupHabitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(169, 171);
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
            this.GridConsumibles.Size = new System.Drawing.Size(214, 140);
            this.GridConsumibles.TabIndex = 6;
            this.GridConsumibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridConsumibles_CellContentClick);
            this.GridConsumibles.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridConsumibles_RowHeaderMouseClick);
            this.GridConsumibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridConsumibles_CellContentClick);
            // 
            // TxtConsumible
            // 
            this.TxtConsumible.Location = new System.Drawing.Point(6, 164);
            this.TxtConsumible.Name = "TxtConsumible";
            this.TxtConsumible.ReadOnly = true;
            this.TxtConsumible.Size = new System.Drawing.Size(96, 20);
            this.TxtConsumible.TabIndex = 5;
            // 
            // AgregarCarrito
            // 
            this.AgregarCarrito.Enabled = false;
            this.AgregarCarrito.Location = new System.Drawing.Point(6, 190);
            this.AgregarCarrito.Name = "AgregarCarrito";
            this.AgregarCarrito.Size = new System.Drawing.Size(209, 23);
            this.AgregarCarrito.TabIndex = 4;
            this.AgregarCarrito.Text = "AGREGAR AL CARRITO >>";
            this.AgregarCarrito.UseVisualStyleBackColor = true;
            this.AgregarCarrito.Click += new System.EventHandler(this.AgregarCarrito_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(108, 166);
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
            this.GridCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaEliminar});
            this.GridCarrito.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.GridCarrito.Location = new System.Drawing.Point(6, 229);
            this.GridCarrito.Name = "GridCarrito";
            this.GridCarrito.ReadOnly = true;
            this.GridCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCarrito.Size = new System.Drawing.Size(317, 281);
            this.GridCarrito.TabIndex = 0;
            this.GridCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCarrito_CellContentClick);
            // 
            // ColumnaEliminar
            // 
            this.ColumnaEliminar.HeaderText = "Eliminar";
            this.ColumnaEliminar.Name = "ColumnaEliminar";
            this.ColumnaEliminar.ReadOnly = true;
            this.ColumnaEliminar.Text = "Quitar";
            this.ColumnaEliminar.UseColumnTextForButtonValue = true;
            this.ColumnaEliminar.Width = 49;
            // 
            // TxtReserva
            // 
            this.TxtReserva.Location = new System.Drawing.Point(111, 19);
            this.TxtReserva.Name = "TxtReserva";
            this.TxtReserva.Size = new System.Drawing.Size(100, 20);
            this.TxtReserva.TabIndex = 1;
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
            // GroupConsumibles
            // 
            this.GroupConsumibles.Controls.Add(this.LabelAllinc);
            this.GroupConsumibles.Controls.Add(this.LblPrecio);
            this.GroupConsumibles.Controls.Add(this.GridConsumibles);
            this.GroupConsumibles.Controls.Add(this.TxtConsumible);
            this.GroupConsumibles.Controls.Add(this.AgregarCarrito);
            this.GroupConsumibles.Controls.Add(this.GridCarrito);
            this.GroupConsumibles.Controls.Add(this.Cantidad);
            this.GroupConsumibles.Enabled = false;
            this.GroupConsumibles.Location = new System.Drawing.Point(16, 46);
            this.GroupConsumibles.Name = "GroupConsumibles";
            this.GroupConsumibles.Size = new System.Drawing.Size(418, 532);
            this.GroupConsumibles.TabIndex = 4;
            this.GroupConsumibles.TabStop = false;
            this.GroupConsumibles.Text = "Registro de consumibles";
            // 
            // LabelAllinc
            // 
            this.LabelAllinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LabelAllinc.Location = new System.Drawing.Point(247, 164);
            this.LabelAllinc.Name = "LabelAllinc";
            this.LabelAllinc.Size = new System.Drawing.Size(151, 62);
            this.LabelAllinc.TabIndex = 8;
            this.LabelAllinc.Text = "Atención: el régimen es All Inclusive, por lo tanto todas las consumiciones de la" +
                " estadía son GRATIS.";
            // 
            // GroupHabitacion
            // 
            this.GroupHabitacion.Controls.Add(this.GridHabitacion);
            this.GroupHabitacion.Enabled = false;
            this.GroupHabitacion.Location = new System.Drawing.Point(478, 46);
            this.GroupHabitacion.Name = "GroupHabitacion";
            this.GroupHabitacion.Size = new System.Drawing.Size(508, 213);
            this.GroupHabitacion.TabIndex = 5;
            this.GroupHabitacion.TabStop = false;
            this.GroupHabitacion.Text = "Información de la estadía";
            // 
            // GridHabitacion
            // 
            this.GridHabitacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.GridHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHabitacion.Location = new System.Drawing.Point(6, 36);
            this.GridHabitacion.Name = "GridHabitacion";
            this.GridHabitacion.Size = new System.Drawing.Size(460, 150);
            this.GridHabitacion.TabIndex = 0;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 590);
            this.Controls.Add(this.GroupHabitacion);
            this.Controls.Add(this.GroupConsumibles);
            this.Controls.Add(this.VerCO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtReserva);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridConsumibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCarrito)).EndInit();
            this.GroupConsumibles.ResumeLayout(false);
            this.GroupConsumibles.PerformLayout();
            this.GroupHabitacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VerCO;
        private System.Windows.Forms.DataGridView GridCarrito;
        private System.Windows.Forms.Button AgregarCarrito;
        private System.Windows.Forms.NumericUpDown Cantidad;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.DataGridView GridConsumibles;
        private System.Windows.Forms.TextBox TxtConsumible;
        private System.Windows.Forms.GroupBox GroupConsumibles;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnaEliminar;
        private System.Windows.Forms.GroupBox GroupHabitacion;
        private System.Windows.Forms.DataGridView GridHabitacion;
        private System.Windows.Forms.Label LabelAllinc;
    }
}