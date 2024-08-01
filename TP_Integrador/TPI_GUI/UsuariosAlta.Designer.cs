namespace TPI_GUI
{
    partial class UsuariosAlta
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbUserUsername = new TextBox();
            tbUserPassword = new TextBox();
            btnCrearUser = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            tbUserNombre = new TextBox();
            tbUserApellido = new TextBox();
            tbUserDNI = new TextBox();
            tbUserFecNac = new TextBox();
            tbUserDomicilio = new TextBox();
            tbUserTelefono = new TextBox();
            tbUserEmail = new TextBox();
            label11 = new Label();
            tbUserPasswordConfirm = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(397, 25);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(523, 83);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre de usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(577, 125);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // tbUserUsername
            // 
            tbUserUsername.Location = new Point(707, 80);
            tbUserUsername.Margin = new Padding(3, 4, 3, 4);
            tbUserUsername.Name = "tbUserUsername";
            tbUserUsername.Size = new Size(177, 27);
            tbUserUsername.TabIndex = 3;
            // 
            // tbUserPassword
            // 
            tbUserPassword.Location = new Point(707, 122);
            tbUserPassword.Margin = new Padding(3, 4, 3, 4);
            tbUserPassword.Name = "tbUserPassword";
            tbUserPassword.PasswordChar = '*';
            tbUserPassword.Size = new Size(177, 27);
            tbUserPassword.TabIndex = 4;
            // 
            // btnCrearUser
            // 
            btnCrearUser.Location = new Point(734, 310);
            btnCrearUser.Margin = new Padding(3, 4, 3, 4);
            btnCrearUser.Name = "btnCrearUser";
            btnCrearUser.Size = new Size(150, 31);
            btnCrearUser.TabIndex = 5;
            btnCrearUser.Text = "Crear usuario";
            btnCrearUser.UseVisualStyleBackColor = true;
            btnCrearUser.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 83);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 6;
            label4.Text = "Nombre";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 125);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 7;
            label5.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(151, 165);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 8;
            label6.Text = "DNI";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(112, 241);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 9;
            label7.Text = "Domicilio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(119, 278);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 10;
            label8.Text = "Telefono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(140, 317);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 11;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 201);
            label10.Name = "label10";
            label10.Size = new Size(149, 20);
            label10.TabIndex = 12;
            label10.Text = "Fecha de Nacimiento";
            // 
            // tbUserNombre
            // 
            tbUserNombre.Location = new Point(227, 80);
            tbUserNombre.Name = "tbUserNombre";
            tbUserNombre.Size = new Size(217, 27);
            tbUserNombre.TabIndex = 13;
            // 
            // tbUserApellido
            // 
            tbUserApellido.Location = new Point(227, 122);
            tbUserApellido.Name = "tbUserApellido";
            tbUserApellido.Size = new Size(217, 27);
            tbUserApellido.TabIndex = 14;
            // 
            // tbUserDNI
            // 
            tbUserDNI.Location = new Point(227, 162);
            tbUserDNI.Name = "tbUserDNI";
            tbUserDNI.Size = new Size(217, 27);
            tbUserDNI.TabIndex = 15;
            // 
            // tbUserFecNac
            // 
            tbUserFecNac.Location = new Point(227, 198);
            tbUserFecNac.Name = "tbUserFecNac";
            tbUserFecNac.Size = new Size(217, 27);
            tbUserFecNac.TabIndex = 16;
            // 
            // tbUserDomicilio
            // 
            tbUserDomicilio.Location = new Point(227, 238);
            tbUserDomicilio.Name = "tbUserDomicilio";
            tbUserDomicilio.Size = new Size(217, 27);
            tbUserDomicilio.TabIndex = 17;
            // 
            // tbUserTelefono
            // 
            tbUserTelefono.Location = new Point(227, 275);
            tbUserTelefono.Name = "tbUserTelefono";
            tbUserTelefono.Size = new Size(217, 27);
            tbUserTelefono.TabIndex = 18;
            // 
            // tbUserEmail
            // 
            tbUserEmail.Location = new Point(227, 314);
            tbUserEmail.Name = "tbUserEmail";
            tbUserEmail.Size = new Size(217, 27);
            tbUserEmail.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(507, 165);
            label11.Name = "label11";
            label11.Size = new Size(153, 20);
            label11.TabIndex = 20;
            label11.Text = "Confirmar Contraseña";
            label11.Click += label11_Click;
            // 
            // tbUserPasswordConfirm
            // 
            tbUserPasswordConfirm.Location = new Point(707, 162);
            tbUserPasswordConfirm.Margin = new Padding(3, 4, 3, 4);
            tbUserPasswordConfirm.Name = "tbUserPasswordConfirm";
            tbUserPasswordConfirm.PasswordChar = '*';
            tbUserPasswordConfirm.Size = new Size(177, 27);
            tbUserPasswordConfirm.TabIndex = 21;
            // 
            // UsuariosAlta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 377);
            Controls.Add(tbUserPasswordConfirm);
            Controls.Add(label11);
            Controls.Add(tbUserEmail);
            Controls.Add(tbUserTelefono);
            Controls.Add(tbUserDomicilio);
            Controls.Add(tbUserFecNac);
            Controls.Add(tbUserDNI);
            Controls.Add(tbUserApellido);
            Controls.Add(tbUserNombre);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCrearUser);
            Controls.Add(tbUserPassword);
            Controls.Add(tbUserUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UsuariosAlta";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbUserUsername;
        private TextBox tbUserPassword;
        private Button btnCrearUser;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox tbUserNombre;
        private TextBox tbUserApellido;
        private TextBox tbUserDNI;
        private TextBox tbUserFecNac;
        private TextBox tbUserDomicilio;
        private TextBox tbUserTelefono;
        private TextBox tbUserEmail;
        private Label label11;
        private TextBox tbUserPasswordConfirm;
    }
}