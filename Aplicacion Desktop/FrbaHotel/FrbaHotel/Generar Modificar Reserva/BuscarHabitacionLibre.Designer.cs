namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class BuscarHabitacionLibre
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
            this.GridHabitaciones = new System.Windows.Forms.DataGridView();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Seleccionar = new System.Windows.Forms.Button();
            this.LabelAll = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // GridHabitaciones
            // 
            this.GridHabitaciones.AllowUserToAddRows = false;
            this.GridHabitaciones.AllowUserToDeleteRows = false;
            this.GridHabitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHabitaciones.Location = new System.Drawing.Point(12, 12);
            this.GridHabitaciones.Name = "GridHabitaciones";
            this.GridHabitaciones.ReadOnly = true;
            this.GridHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridHabitaciones.Size = new System.Drawing.Size(563, 455);
            this.GridHabitaciones.TabIndex = 16;
            // 
            // Cancelar
            // 
            this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar.Location = new System.Drawing.Point(326, 473);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(108, 34);
            this.Cancelar.TabIndex = 18;
            this.Cancelar.Text = "CANCELAR";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Seleccionar
            // 
            this.Seleccionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Seleccionar.Location = new System.Drawing.Point(145, 473);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(108, 34);
            this.Seleccionar.TabIndex = 17;
            this.Seleccionar.Text = "SELECCIONAR";
            this.Seleccionar.UseVisualStyleBackColor = true;
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // LabelAll
            // 
            this.LabelAll.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelAll.Location = new System.Drawing.Point(55, 42);
            this.LabelAll.Name = "LabelAll";
            this.LabelAll.Size = new System.Drawing.Size(481, 83);
            this.LabelAll.TabIndex = 19;
            this.LabelAll.Text = "NO HAY HABITACIONES DISPONIBLES EN ESTE HOTEL PARA EL PERIODO SELECCIONADO. ELIJA" +
                " OTRA FECHA PARA VER MÁS HABITACIONES.";
            this.LabelAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelAll.Visible = false;
            // 
            // BuscarHabitacionLibre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 521);
            this.Controls.Add(this.LabelAll);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Seleccionar);
            this.Controls.Add(this.GridHabitaciones);
            this.Name = "BuscarHabitacionLibre";
            this.Text = "Buscar Habitacion";
            this.Load += new System.EventHandler(this.BuscarHabitacionLibre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridHabitaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridHabitaciones;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Seleccionar;
        private System.Windows.Forms.Label LabelAll;
    }
}