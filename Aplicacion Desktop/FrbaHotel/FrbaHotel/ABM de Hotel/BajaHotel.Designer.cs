namespace FrbaHotel.ABM_de_Hotel
{
    partial class BajaHotel
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
            this.TxtId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BajarHotel = new System.Windows.Forms.Button();
            this.HastaPick = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMotivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtId
            // 
            this.TxtId.AutoSize = true;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(47, 21);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(58, 18);
            this.TxtId.TabIndex = 26;
            this.TxtId.Text = "..........";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID:";
            // 
            // BajarHotel
            // 
            this.BajarHotel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BajarHotel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BajarHotel.Location = new System.Drawing.Point(0, 231);
            this.BajarHotel.Name = "BajarHotel";
            this.BajarHotel.Size = new System.Drawing.Size(284, 31);
            this.BajarHotel.TabIndex = 27;
            this.BajarHotel.Text = "DESHABILITAR";
            this.BajarHotel.UseVisualStyleBackColor = true;
            this.BajarHotel.Click += new System.EventHandler(this.BajarHotel_Click);
            // 
            // HastaPick
            // 
            this.HastaPick.Location = new System.Drawing.Point(15, 73);
            this.HastaPick.Name = "HastaPick";
            this.HastaPick.Size = new System.Drawing.Size(200, 20);
            this.HastaPick.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fecha de finalización del cierre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Detalle los motivos del cierre temporal:";
            // 
            // TxtMotivo
            // 
            this.TxtMotivo.Location = new System.Drawing.Point(12, 132);
            this.TxtMotivo.MaxLength = 140;
            this.TxtMotivo.Multiline = true;
            this.TxtMotivo.Name = "TxtMotivo";
            this.TxtMotivo.Size = new System.Drawing.Size(260, 88);
            this.TxtMotivo.TabIndex = 31;
            // 
            // BajaHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.TxtMotivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HastaPick);
            this.Controls.Add(this.BajarHotel);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BajaHotel";
            this.Text = "Baja Hotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BajarHotel;
        private System.Windows.Forms.DateTimePicker HastaPick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMotivo;
    }
}