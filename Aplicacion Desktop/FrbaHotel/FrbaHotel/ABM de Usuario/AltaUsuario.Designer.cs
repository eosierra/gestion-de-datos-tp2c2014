namespace FrbaHotel.ABM_de_Usuario
{
    partial class AltaUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPass1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GrupoDatos = new System.Windows.Forms.GroupBox();
            this.Calendario = new System.Windows.Forms.DateTimePicker();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LinkValida = new System.Windows.Forms.LinkLabel();
            this.CmdQuitarRol = new System.Windows.Forms.Button();
            this.CmdAgregarRol = new System.Windows.Forms.Button();
            this.ListaRoles = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPass2 = new System.Windows.Forms.TextBox();
            this.LblError1 = new System.Windows.Forms.Label();
            this.GrupoDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(79, 27);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(129, 20);
            this.TxtUser.TabIndex = 1;
            // 
            // TxtPass1
            // 
            this.TxtPass1.Location = new System.Drawing.Point(79, 56);
            this.TxtPass1.Name = "TxtPass1";
            this.TxtPass1.Size = new System.Drawing.Size(129, 20);
            this.TxtPass1.TabIndex = 3;
            this.TxtPass1.TextChanged += new System.EventHandler(this.validarContraseñas);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Roles asignados:";
            // 
            // GrupoDatos
            // 
            this.GrupoDatos.Controls.Add(this.Calendario);
            this.GrupoDatos.Controls.Add(this.textBox12);
            this.GrupoDatos.Controls.Add(this.label13);
            this.GrupoDatos.Controls.Add(this.textBox11);
            this.GrupoDatos.Controls.Add(this.label12);
            this.GrupoDatos.Controls.Add(this.textBox8);
            this.GrupoDatos.Controls.Add(this.button1);
            this.GrupoDatos.Controls.Add(this.label10);
            this.GrupoDatos.Controls.Add(this.label9);
            this.GrupoDatos.Controls.Add(this.textBox7);
            this.GrupoDatos.Controls.Add(this.label8);
            this.GrupoDatos.Controls.Add(this.textBox6);
            this.GrupoDatos.Controls.Add(this.label7);
            this.GrupoDatos.Controls.Add(this.textBox5);
            this.GrupoDatos.Controls.Add(this.label6);
            this.GrupoDatos.Controls.Add(this.comboBox2);
            this.GrupoDatos.Controls.Add(this.textBox3);
            this.GrupoDatos.Controls.Add(this.label4);
            this.GrupoDatos.Controls.Add(this.textBox4);
            this.GrupoDatos.Controls.Add(this.label5);
            this.GrupoDatos.Location = new System.Drawing.Point(29, 281);
            this.GrupoDatos.Name = "GrupoDatos";
            this.GrupoDatos.Size = new System.Drawing.Size(373, 257);
            this.GrupoDatos.TabIndex = 6;
            this.GrupoDatos.TabStop = false;
            this.GrupoDatos.Text = "Datos identificatorios";
            // 
            // Calendario
            // 
            this.Calendario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Calendario.Location = new System.Drawing.Point(129, 193);
            this.Calendario.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.Calendario.Name = "Calendario";
            this.Calendario.Size = new System.Drawing.Size(227, 20);
            this.Calendario.TabIndex = 16;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(79, 53);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(277, 20);
            this.textBox12.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Apellido:";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(305, 161);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(51, 20);
            this.textBox11.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(262, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Altura:";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(158, 223);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(117, 20);
            this.textBox8.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Hotel donde se desempeña:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Fecha de nacimiento:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(79, 161);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(177, 20);
            this.textBox7.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dirección:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(79, 135);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(277, 20);
            this.textBox6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Teléfono:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(79, 107);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(277, 20);
            this.textBox5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(147, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(66, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(219, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo y N° de Documento:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(277, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 584);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpiar pantalla";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(284, 584);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 29);
            this.button3.TabIndex = 8;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LinkValida);
            this.groupBox2.Controls.Add(this.CmdQuitarRol);
            this.groupBox2.Controls.Add(this.CmdAgregarRol);
            this.groupBox2.Controls.Add(this.ListaRoles);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TxtPass2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtUser);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtPass1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(29, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos generales";
            // 
            // LinkValida
            // 
            this.LinkValida.AutoSize = true;
            this.LinkValida.Location = new System.Drawing.Point(215, 30);
            this.LinkValida.Name = "LinkValida";
            this.LinkValida.Size = new System.Drawing.Size(39, 13);
            this.LinkValida.TabIndex = 11;
            this.LinkValida.TabStop = true;
            this.LinkValida.Text = "Validar";
            this.LinkValida.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkValida_LinkClicked);
            // 
            // CmdQuitarRol
            // 
            this.CmdQuitarRol.Location = new System.Drawing.Point(115, 153);
            this.CmdQuitarRol.Name = "CmdQuitarRol";
            this.CmdQuitarRol.Size = new System.Drawing.Size(53, 24);
            this.CmdQuitarRol.TabIndex = 10;
            this.CmdQuitarRol.Text = "Quitar";
            this.CmdQuitarRol.UseVisualStyleBackColor = true;
            // 
            // CmdAgregarRol
            // 
            this.CmdAgregarRol.Location = new System.Drawing.Point(115, 122);
            this.CmdAgregarRol.Name = "CmdAgregarRol";
            this.CmdAgregarRol.Size = new System.Drawing.Size(53, 25);
            this.CmdAgregarRol.TabIndex = 9;
            this.CmdAgregarRol.Text = "Agregar";
            this.CmdAgregarRol.UseVisualStyleBackColor = true;
            this.CmdAgregarRol.Click += new System.EventHandler(this.AgregarRol_Click_1);
            // 
            // ListaRoles
            // 
            this.ListaRoles.FormattingEnabled = true;
            this.ListaRoles.Location = new System.Drawing.Point(16, 122);
            this.ListaRoles.Name = "ListaRoles";
            this.ListaRoles.Size = new System.Drawing.Size(85, 108);
            this.ListaRoles.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Vuelva a escribir la contraseña:";
            // 
            // TxtPass2
            // 
            this.TxtPass2.Location = new System.Drawing.Point(174, 81);
            this.TxtPass2.Name = "TxtPass2";
            this.TxtPass2.Size = new System.Drawing.Size(129, 20);
            this.TxtPass2.TabIndex = 7;
            this.TxtPass2.TextChanged += new System.EventHandler(this.validarContraseñas);
            // 
            // LblError1
            // 
            this.LblError1.AutoSize = true;
            this.LblError1.ForeColor = System.Drawing.Color.Red;
            this.LblError1.Location = new System.Drawing.Point(32, 258);
            this.LblError1.Name = "LblError1";
            this.LblError1.Size = new System.Drawing.Size(29, 13);
            this.LblError1.TabIndex = 10;
            this.LblError1.Text = "Error";
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 636);
            this.Controls.Add(this.LblError1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GrupoDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo usuario";
            this.Load += new System.EventHandler(this.AltaUsuario_Load);
            this.GrupoDatos.ResumeLayout(false);
            this.GrupoDatos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPass1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GrupoDatos;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtPass2;
        private System.Windows.Forms.ListBox ListaRoles;
        private System.Windows.Forms.Button CmdQuitarRol;
        private System.Windows.Forms.Button CmdAgregarRol;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker Calendario;
        private System.Windows.Forms.Label LblError1;
        private System.Windows.Forms.LinkLabel LinkValida;
    }
}