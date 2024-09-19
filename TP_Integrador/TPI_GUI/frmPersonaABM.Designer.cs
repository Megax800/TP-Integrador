namespace TPI_GUI
{
    partial class frmPersonaABM
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblFechaNac = new Label();
            cmbPlan = new ComboBox();
            lblPlan = new Label();
            cbNuevoUsuario = new CheckBox();
            btnABM = new Button();
            pickerFechaNac = new DateTimePicker();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(136, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 42);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(25, 85);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(136, 83);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(25, 127);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(136, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(192, 27);
            txtEmail.TabIndex = 4;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(25, 171);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 7;
            lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(136, 169);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(192, 27);
            txtDireccion.TabIndex = 6;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(25, 213);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Telefono";
            lblTelefono.Click += lblTelefono_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(136, 211);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 8;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(25, 256);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(86, 20);
            lblFechaNac.TabIndex = 11;
            lblFechaNac.Text = "Nacimiento";
            // 
            // cmbPlan
            // 
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Items.AddRange(new object[] { "Informatica", "Mecanica", "Quimica", "Derecho" });
            cmbPlan.Location = new Point(468, 44);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(151, 28);
            cmbPlan.TabIndex = 12;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(398, 47);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(37, 20);
            lblPlan.TabIndex = 13;
            lblPlan.Text = "Plan";
            // 
            // cbNuevoUsuario
            // 
            cbNuevoUsuario.AutoSize = true;
            cbNuevoUsuario.Location = new Point(648, 48);
            cbNuevoUsuario.Name = "cbNuevoUsuario";
            cbNuevoUsuario.Size = new Size(120, 24);
            cbNuevoUsuario.TabIndex = 18;
            cbNuevoUsuario.Text = "Crear Usuario";
            cbNuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnABM
            // 
            btnABM.Location = new Point(583, 389);
            btnABM.Name = "btnABM";
            btnABM.Size = new Size(94, 29);
            btnABM.TabIndex = 19;
            btnABM.Text = "Aceptar";
            btnABM.UseVisualStyleBackColor = true;
            btnABM.Click += btnABM_Click;
            // 
            // pickerFechaNac
            // 
            pickerFechaNac.Location = new Point(136, 251);
            pickerFechaNac.Name = "pickerFechaNac";
            pickerFechaNac.Size = new Size(250, 27);
            pickerFechaNac.TabIndex = 20;
            // 
            // frmPersonaABM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pickerFechaNac);
            Controls.Add(btnABM);
            Controls.Add(cbNuevoUsuario);
            Controls.Add(lblPlan);
            Controls.Add(cmbPlan);
            Controls.Add(lblFechaNac);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(txtDireccion);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "frmPersonaABM";
            Text = "frmPersonaABM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblFechaNac;
        private ComboBox cmbPlan;
        private Label lblPlan;
        private CheckBox cbNuevoUsuario;
        private Button btnABM;
        private DateTimePicker pickerFechaNac;
    }
}