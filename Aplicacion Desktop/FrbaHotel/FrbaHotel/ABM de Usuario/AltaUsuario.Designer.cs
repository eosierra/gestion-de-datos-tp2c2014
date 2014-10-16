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
            this.CmdQuitaHotel = new System.Windows.Forms.Button();
            this.CmdAddHotel = new System.Windows.Forms.Button();
            this.ListHoteles = new System.Windows.Forms.ListBox();
            this.Calendario = new System.Windows.Forms.DateTimePicker();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.NroDirec = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Direc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.NroDoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LinkValida = new System.Windows.Forms.LinkLabel();
            this.CmdQuitarRol = new System.Windows.Forms.Button();
            this.CmdAgregarRol = new System.Windows.Forms.Button();
            this.ListaRoles = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPass2 = new System.Windows.Forms.TextBox();
            this.LblError1 = new System.Windows.Forms.Label();
            this.LblError2 = new System.Windows.Forms.Label();
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
            this.TxtPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass1.Location = new System.Drawing.Point(79, 56);
            this.TxtPass1.Name = "TxtPass1";
            this.TxtPass1.PasswordChar = '*';
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
            this.GrupoDatos.Controls.Add(this.CmdQuitaHotel);
            this.GrupoDatos.Controls.Add(this.CmdAddHotel);
            this.GrupoDatos.Controls.Add(this.ListHoteles);
            this.GrupoDatos.Controls.Add(this.Calendario);
            this.GrupoDatos.Controls.Add(this.Apellido);
            this.GrupoDatos.Controls.Add(this.label13);
            this.GrupoDatos.Controls.Add(this.NroDirec);
            this.GrupoDatos.Controls.Add(this.label12);
            this.GrupoDatos.Controls.Add(this.label10);
            this.GrupoDatos.Controls.Add(this.label9);
            this.GrupoDatos.Controls.Add(this.Direc);
            this.GrupoDatos.Controls.Add(this.label8);
            this.GrupoDatos.Controls.Add(this.Telefono);
            this.GrupoDatos.Controls.Add(this.label7);
            this.GrupoDatos.Controls.Add(this.TxtMail);
            this.GrupoDatos.Controls.Add(this.label6);
            this.GrupoDatos.Controls.Add(this.comboBox2);
            this.GrupoDatos.Controls.Add(this.NroDoc);
            this.GrupoDatos.Controls.Add(this.label4);
            this.GrupoDatos.Controls.Add(this.Nombre);
            this.GrupoDatos.Controls.Add(this.label5);
            this.GrupoDatos.Enabled = false;
            this.GrupoDatos.Location = new System.Drawing.Point(427, 12);
            this.GrupoDatos.Name = "GrupoDatos";
            this.GrupoDatos.Size = new System.Drawing.Size(373, 344);
            this.GrupoDatos.TabIndex = 6;
            this.GrupoDatos.TabStop = false;
            this.GrupoDatos.Text = "Datos identificatorios";
            // 
            // CmdQuitaHotel
            // 
            this.CmdQuitaHotel.Location = new System.Drawing.Point(278, 280);
            this.CmdQuitaHotel.Name = "CmdQuitaHotel";
            this.CmdQuitaHotel.Size = new System.Drawing.Size(53, 24);
            this.CmdQuitaHotel.TabIndex = 27;
            this.CmdQuitaHotel.Text = "Quitar";
            this.CmdQuitaHotel.UseVisualStyleBackColor = true;
            // 
            // CmdAddHotel
            // 
            this.CmdAddHotel.Location = new System.Drawing.Point(278, 249);
            this.CmdAddHotel.Name = "CmdAddHotel";
            this.CmdAddHotel.Size = new System.Drawing.Size(53, 25);
            this.CmdAddHotel.TabIndex = 26;
            this.CmdAddHotel.Text = "Agregar";
            this.CmdAddHotel.UseVisualStyleBackColor = true;
            // 
            // ListHoteles
            // 
            this.ListHoteles.FormattingEnabled = true;
            this.ListHoteles.Location = new System.Drawing.Point(187, 226);
            this.ListHoteles.Name = "ListHoteles";
            this.ListHoteles.Size = new System.Drawing.Size(85, 108);
            this.ListHoteles.TabIndex = 25;
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
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(79, 53);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(277, 20);
            this.Apellido.TabIndex = 6;
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
            // NroDirec
            // 
            this.NroDirec.Location = new System.Drawing.Point(305, 161);
            this.NroDirec.Name = "NroDirec";
            this.NroDirec.Size = new System.Drawing.Size(51, 20);
            this.NroDirec.TabIndex = 15;
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
            // Direc
            // 
            this.Direc.Location = new System.Drawing.Point(79, 161);
            this.Direc.Name = "Direc";
            this.Direc.Size = new System.Drawing.Size(177, 20);
            this.Direc.TabIndex = 14;
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
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(79, 135);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(277, 20);
            this.Telefono.TabIndex = 12;
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
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(79, 107);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(277, 20);
            this.TxtMail.TabIndex = 10;
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
            // NroDoc
            // 
            this.NroDoc.Location = new System.Drawing.Point(219, 80);
            this.NroDoc.Name = "NroDoc";
            this.NroDoc.Size = new System.Drawing.Size(137, 20);
            this.NroDoc.TabIndex = 7;
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
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(79, 28);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(277, 20);
            this.Nombre.TabIndex = 5;
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
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(284, 406);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(118, 29);
            this.Limpiar.TabIndex = 7;
            this.Limpiar.Text = "Limpiar pantalla";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.LimpiarPantalla_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(434, 406);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(118, 29);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.button3_Click);
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
            this.CmdQuitarRol.Click += new System.EventHandler(this.CmdQuitarRol_Click);
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
            this.ListaRoles.SelectedIndexChanged += new System.EventHandler(this.ListaRoles_SelectedIndexChanged);
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
            this.TxtPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass2.Location = new System.Drawing.Point(174, 81);
            this.TxtPass2.Name = "TxtPass2";
            this.TxtPass2.PasswordChar = '*';
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
            this.LblError1.Size = new System.Drawing.Size(49, 13);
            this.LblError1.TabIndex = 10;
            this.LblError1.Text = "..............";
            // 
            // LblError2
            // 
            this.LblError2.AutoSize = true;
            this.LblError2.ForeColor = System.Drawing.Color.Red;
            this.LblError2.Location = new System.Drawing.Point(424, 368);
            this.LblError2.Name = "LblError2";
            this.LblError2.Size = new System.Drawing.Size(49, 13);
            this.LblError2.TabIndex = 11;
            this.LblError2.Text = "..............";
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 447);
            this.Controls.Add(this.LblError2);
            this.Controls.Add(this.LblError1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.GrupoDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.TextBox NroDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Direc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtPass2;
        private System.Windows.Forms.ListBox ListaRoles;
        private System.Windows.Forms.Button CmdQuitarRol;
        private System.Windows.Forms.Button CmdAgregarRol;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox NroDirec;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker Calendario;
        private System.Windows.Forms.Label LblError1;
        private System.Windows.Forms.LinkLabel LinkValida;
        private System.Windows.Forms.Button CmdQuitaHotel;
        private System.Windows.Forms.Button CmdAddHotel;
        private System.Windows.Forms.ListBox ListHoteles;
        private System.Windows.Forms.Label LblError2;
    }
}