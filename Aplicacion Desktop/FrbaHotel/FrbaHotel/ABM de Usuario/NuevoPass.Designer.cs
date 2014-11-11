namespace FrbaHotel.ABM_de_Usuario
{
    partial class NuevoPass
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
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPass2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPass1 = new System.Windows.Forms.TextBox();
            this.Cambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Vuelva a escribir la contraseña:";
            // 
            // TxtPass2
            // 
            this.TxtPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass2.Location = new System.Drawing.Point(173, 43);
            this.TxtPass2.Name = "TxtPass2";
            this.TxtPass2.PasswordChar = '*';
            this.TxtPass2.Size = new System.Drawing.Size(129, 20);
            this.TxtPass2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña:";
            // 
            // TxtPass1
            // 
            this.TxtPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass1.Location = new System.Drawing.Point(173, 17);
            this.TxtPass1.Name = "TxtPass1";
            this.TxtPass1.PasswordChar = '*';
            this.TxtPass1.Size = new System.Drawing.Size(129, 20);
            this.TxtPass1.TabIndex = 9;
            // 
            // Cambiar
            // 
            this.Cambiar.Location = new System.Drawing.Point(85, 72);
            this.Cambiar.Name = "Cambiar";
            this.Cambiar.Size = new System.Drawing.Size(147, 30);
            this.Cambiar.TabIndex = 12;
            this.Cambiar.Text = "CAMBIAR";
            this.Cambiar.UseVisualStyleBackColor = true;
            this.Cambiar.Click += new System.EventHandler(this.Cambiar_Click);
            // 
            // NuevoPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 106);
            this.ControlBox = false;
            this.Controls.Add(this.Cambiar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtPass2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPass1);
            this.Name = "NuevoPass";
            this.ShowIcon = false;
            this.Text = "NUEVA CONTRASEÑA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtPass2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPass1;
        private System.Windows.Forms.Button Cambiar;
    }
}