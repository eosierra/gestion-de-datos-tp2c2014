namespace FrbaHotel.Login
{
    partial class LoginOK
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
            this.CbHoteles = new System.Windows.Forms.ComboBox();
            this.Entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CbHoteles
            // 
            this.CbHoteles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbHoteles.FormattingEnabled = true;
            this.CbHoteles.Location = new System.Drawing.Point(23, 30);
            this.CbHoteles.Name = "CbHoteles";
            this.CbHoteles.Size = new System.Drawing.Size(150, 21);
            this.CbHoteles.TabIndex = 0;
            // 
            // Entrar
            // 
            this.Entrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Entrar.Location = new System.Drawing.Point(199, 30);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 23);
            this.Entrar.TabIndex = 1;
            this.Entrar.Text = "ENTRAR";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // LoginOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 76);
            this.ControlBox = false;
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.CbHoteles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginOK";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.LoginOK_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbHoteles;
        private System.Windows.Forms.Button Entrar;
    }
}