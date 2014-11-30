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
            this.TxtEstadia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VerCO = new System.Windows.Forms.Button();
            this.GroupConsumibles = new System.Windows.Forms.GroupBox();
            this.LabelAllinc = new System.Windows.Forms.Label();
            this.GroupHabitacion = new System.Windows.Forms.GroupBox();
            this.TxtDiasReserva = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDiasNoEstadia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDiasEstadia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GridHabitacion = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupAbono = new System.Windows.Forms.GroupBox();
            this.CbTipoPago = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CbBanco = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OpCA = new System.Windows.Forms.RadioButton();
            this.OpCC = new System.Windows.Forms.RadioButton();
            this.TxtNCuenta = new System.Windows.Forms.TextBox();
            this.OpOtro = new System.Windows.Forms.RadioButton();
            this.OpEfectivo = new System.Windows.Forms.RadioButton();
            this.RealizarEgreso = new System.Windows.Forms.Button();
            this.GroupTotal = new System.Windows.Forms.GroupBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblSubConsumibles = new System.Windows.Forms.Label();
            this.LblSubEstadia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsumibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCarrito)).BeginInit();
            this.GroupConsumibles.SuspendLayout();
            this.GroupHabitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHabitacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GroupAbono.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GroupTotal.SuspendLayout();
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
            this.AgregarCarrito.Location = new System.Drawing.Point(6, 192);
            this.AgregarCarrito.Name = "AgregarCarrito";
            this.AgregarCarrito.Size = new System.Drawing.Size(214, 23);
            this.AgregarCarrito.TabIndex = 4;
            this.AgregarCarrito.Text = "AGREGAR AL CARRITO >>";
            this.AgregarCarrito.UseVisualStyleBackColor = true;
            this.AgregarCarrito.Click += new System.EventHandler(this.AgregarCarrito_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.Enabled = false;
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
            // TxtEstadia
            // 
            this.TxtEstadia.Location = new System.Drawing.Point(111, 19);
            this.TxtEstadia.Name = "TxtEstadia";
            this.TxtEstadia.Size = new System.Drawing.Size(100, 20);
            this.TxtEstadia.TabIndex = 1;
            this.TxtEstadia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtReserva_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código de Estadía:";
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
            this.GroupConsumibles.Location = new System.Drawing.Point(6, 19);
            this.GroupConsumibles.Name = "GroupConsumibles";
            this.GroupConsumibles.Size = new System.Drawing.Size(418, 525);
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
            this.LabelAllinc.Visible = false;
            // 
            // GroupHabitacion
            // 
            this.GroupHabitacion.Controls.Add(this.TxtDiasReserva);
            this.GroupHabitacion.Controls.Add(this.label6);
            this.GroupHabitacion.Controls.Add(this.TxtDiasNoEstadia);
            this.GroupHabitacion.Controls.Add(this.label4);
            this.GroupHabitacion.Controls.Add(this.TxtDiasEstadia);
            this.GroupHabitacion.Controls.Add(this.label2);
            this.GroupHabitacion.Controls.Add(this.GridHabitacion);
            this.GroupHabitacion.Location = new System.Drawing.Point(456, 19);
            this.GroupHabitacion.Name = "GroupHabitacion";
            this.GroupHabitacion.Size = new System.Drawing.Size(532, 213);
            this.GroupHabitacion.TabIndex = 5;
            this.GroupHabitacion.TabStop = false;
            this.GroupHabitacion.Text = "Información de la estadía";
            // 
            // TxtDiasReserva
            // 
            this.TxtDiasReserva.AutoSize = true;
            this.TxtDiasReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiasReserva.Location = new System.Drawing.Point(102, 30);
            this.TxtDiasReserva.Name = "TxtDiasReserva";
            this.TxtDiasReserva.Size = new System.Drawing.Size(15, 15);
            this.TxtDiasReserva.TabIndex = 6;
            this.TxtDiasReserva.Text = "C";
            this.TxtDiasReserva.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Días de estadía:";
            // 
            // TxtDiasNoEstadia
            // 
            this.TxtDiasNoEstadia.AutoSize = true;
            this.TxtDiasNoEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiasNoEstadia.Location = new System.Drawing.Point(451, 30);
            this.TxtDiasNoEstadia.Name = "TxtDiasNoEstadia";
            this.TxtDiasNoEstadia.Size = new System.Drawing.Size(15, 15);
            this.TxtDiasNoEstadia.TabIndex = 4;
            this.TxtDiasNoEstadia.Text = "C";
            this.TxtDiasNoEstadia.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Días que no se alojó:";
            // 
            // TxtDiasEstadia
            // 
            this.TxtDiasEstadia.AutoSize = true;
            this.TxtDiasEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiasEstadia.Location = new System.Drawing.Point(265, 30);
            this.TxtDiasEstadia.Name = "TxtDiasEstadia";
            this.TxtDiasEstadia.Size = new System.Drawing.Size(15, 15);
            this.TxtDiasEstadia.TabIndex = 2;
            this.TxtDiasEstadia.Text = "C";
            this.TxtDiasEstadia.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Días de reserva:";
            // 
            // GridHabitacion
            // 
            this.GridHabitacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.GridHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHabitacion.Location = new System.Drawing.Point(49, 58);
            this.GridHabitacion.Name = "GridHabitacion";
            this.GridHabitacion.Size = new System.Drawing.Size(388, 138);
            this.GridHabitacion.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.RealizarEgreso);
            this.groupBox1.Controls.Add(this.GroupTotal);
            this.groupBox1.Controls.Add(this.GroupHabitacion);
            this.groupBox1.Controls.Add(this.GroupConsumibles);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(16, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1005, 550);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GroupAbono);
            this.groupBox2.Controls.Add(this.OpOtro);
            this.groupBox2.Controls.Add(this.OpEfectivo);
            this.groupBox2.Location = new System.Drawing.Point(727, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 260);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forma de pago";
            // 
            // GroupAbono
            // 
            this.GroupAbono.Controls.Add(this.CbTipoPago);
            this.GroupAbono.Controls.Add(this.label10);
            this.GroupAbono.Controls.Add(this.CbBanco);
            this.GroupAbono.Controls.Add(this.label9);
            this.GroupAbono.Controls.Add(this.label8);
            this.GroupAbono.Controls.Add(this.groupBox3);
            this.GroupAbono.Controls.Add(this.TxtNCuenta);
            this.GroupAbono.Enabled = false;
            this.GroupAbono.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupAbono.Location = new System.Drawing.Point(6, 69);
            this.GroupAbono.Name = "GroupAbono";
            this.GroupAbono.Size = new System.Drawing.Size(241, 176);
            this.GroupAbono.TabIndex = 7;
            this.GroupAbono.TabStop = false;
            // 
            // CbTipoPago
            // 
            this.CbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoPago.FormattingEnabled = true;
            this.CbTipoPago.Location = new System.Drawing.Point(50, 15);
            this.CbTipoPago.Name = "CbTipoPago";
            this.CbTipoPago.Size = new System.Drawing.Size(175, 21);
            this.CbTipoPago.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Tipo";
            // 
            // CbBanco
            // 
            this.CbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBanco.FormattingEnabled = true;
            this.CbBanco.Location = new System.Drawing.Point(50, 42);
            this.CbBanco.Name = "CbBanco";
            this.CbBanco.Size = new System.Drawing.Size(175, 21);
            this.CbBanco.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Número de cuenta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Banco";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OpCA);
            this.groupBox3.Controls.Add(this.OpCC);
            this.groupBox3.Location = new System.Drawing.Point(6, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 42);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cuenta";
            // 
            // OpCA
            // 
            this.OpCA.AutoSize = true;
            this.OpCA.Location = new System.Drawing.Point(118, 19);
            this.OpCA.Name = "OpCA";
            this.OpCA.Size = new System.Drawing.Size(95, 17);
            this.OpCA.TabIndex = 3;
            this.OpCA.TabStop = true;
            this.OpCA.Tag = "A";
            this.OpCA.Text = "Caja de Ahorro";
            this.OpCA.UseVisualStyleBackColor = true;
            // 
            // OpCC
            // 
            this.OpCC.AutoSize = true;
            this.OpCC.Location = new System.Drawing.Point(14, 19);
            this.OpCC.Name = "OpCC";
            this.OpCC.Size = new System.Drawing.Size(67, 17);
            this.OpCC.TabIndex = 2;
            this.OpCC.TabStop = true;
            this.OpCC.Tag = "C";
            this.OpCC.Text = "Corriente";
            this.OpCC.UseVisualStyleBackColor = true;
            // 
            // TxtNCuenta
            // 
            this.TxtNCuenta.Location = new System.Drawing.Point(9, 141);
            this.TxtNCuenta.MaxLength = 40;
            this.TxtNCuenta.Name = "TxtNCuenta";
            this.TxtNCuenta.Size = new System.Drawing.Size(216, 20);
            this.TxtNCuenta.TabIndex = 5;
            this.TxtNCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNCuenta_KeyPress);
            // 
            // OpOtro
            // 
            this.OpOtro.AutoSize = true;
            this.OpOtro.Location = new System.Drawing.Point(6, 53);
            this.OpOtro.Name = "OpOtro";
            this.OpOtro.Size = new System.Drawing.Size(116, 17);
            this.OpOtro.TabIndex = 1;
            this.OpOtro.TabStop = true;
            this.OpOtro.Text = "Otra forma de pago";
            this.OpOtro.UseVisualStyleBackColor = true;
            this.OpOtro.CheckedChanged += new System.EventHandler(this.OpOtro_CheckedChanged);
            // 
            // OpEfectivo
            // 
            this.OpEfectivo.AutoSize = true;
            this.OpEfectivo.Location = new System.Drawing.Point(6, 30);
            this.OpEfectivo.Name = "OpEfectivo";
            this.OpEfectivo.Size = new System.Drawing.Size(64, 17);
            this.OpEfectivo.TabIndex = 0;
            this.OpEfectivo.TabStop = true;
            this.OpEfectivo.Text = "Efectivo";
            this.OpEfectivo.UseVisualStyleBackColor = true;
            // 
            // RealizarEgreso
            // 
            this.RealizarEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealizarEgreso.Location = new System.Drawing.Point(456, 504);
            this.RealizarEgreso.Name = "RealizarEgreso";
            this.RealizarEgreso.Size = new System.Drawing.Size(532, 40);
            this.RealizarEgreso.TabIndex = 7;
            this.RealizarEgreso.Text = "FINALIZAR ESTADÍA";
            this.RealizarEgreso.UseVisualStyleBackColor = true;
            this.RealizarEgreso.Click += new System.EventHandler(this.RealizarEgreso_Click);
            // 
            // GroupTotal
            // 
            this.GroupTotal.Controls.Add(this.LblTotal);
            this.GroupTotal.Controls.Add(this.LblSubConsumibles);
            this.GroupTotal.Controls.Add(this.LblSubEstadia);
            this.GroupTotal.Controls.Add(this.label7);
            this.GroupTotal.Controls.Add(this.label5);
            this.GroupTotal.Controls.Add(this.label3);
            this.GroupTotal.Location = new System.Drawing.Point(456, 238);
            this.GroupTotal.Name = "GroupTotal";
            this.GroupTotal.Size = new System.Drawing.Size(265, 260);
            this.GroupTotal.TabIndex = 6;
            this.GroupTotal.TabStop = false;
            this.GroupTotal.Text = "Total";
            this.GroupTotal.Visible = false;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(172, 87);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(24, 25);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "0";
            // 
            // LblSubConsumibles
            // 
            this.LblSubConsumibles.AutoSize = true;
            this.LblSubConsumibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubConsumibles.Location = new System.Drawing.Point(172, 45);
            this.LblSubConsumibles.Name = "LblSubConsumibles";
            this.LblSubConsumibles.Size = new System.Drawing.Size(16, 18);
            this.LblSubConsumibles.TabIndex = 4;
            this.LblSubConsumibles.Text = "0";
            // 
            // LblSubEstadia
            // 
            this.LblSubEstadia.AutoSize = true;
            this.LblSubEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubEstadia.Location = new System.Drawing.Point(172, 16);
            this.LblSubEstadia.Name = "LblSubEstadia";
            this.LblSubEstadia.Size = new System.Drawing.Size(16, 18);
            this.LblSubEstadia.TabIndex = 3;
            this.LblSubEstadia.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total: $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Subtotal consumibles: $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subtotal estadía: $";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VerCO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEstadia);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridConsumibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCarrito)).EndInit();
            this.GroupConsumibles.ResumeLayout(false);
            this.GroupConsumibles.PerformLayout();
            this.GroupHabitacion.ResumeLayout(false);
            this.GroupHabitacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHabitacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GroupAbono.ResumeLayout(false);
            this.GroupAbono.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GroupTotal.ResumeLayout(false);
            this.GroupTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEstadia;
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
        private System.Windows.Forms.Label TxtDiasEstadia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TxtDiasReserva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TxtDiasNoEstadia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RealizarEgreso;
        private System.Windows.Forms.GroupBox GroupTotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblSubConsumibles;
        private System.Windows.Forms.Label LblSubEstadia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbBanco;
        private System.Windows.Forms.RadioButton OpOtro;
        private System.Windows.Forms.RadioButton OpEfectivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNCuenta;
        private System.Windows.Forms.RadioButton OpCA;
        private System.Windows.Forms.RadioButton OpCC;
        private System.Windows.Forms.GroupBox GroupAbono;
        private System.Windows.Forms.ComboBox CbTipoPago;
        private System.Windows.Forms.Label label10;
    }
}