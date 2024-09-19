namespace TPI_GUI
{
    partial class frmUsuarioConsulta
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
            btnBuscar = new Button();
            cmbCategoria = new ComboBox();
            label1 = new Label();
            txtValor = new TextBox();
            lblValor = new Label();
            lblCriteria = new Label();
            btnAplicar = new Button();
            label2 = new Label();
            rdAlumno = new RadioButton();
            rdProfesor = new RadioButton();
            rdAdmin = new RadioButton();
            dgvUsuarios = new DataGridView();
            apellido = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            legajo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(694, 416);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button1_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Apellido", "Nombre", "Correo Electronico", "Nombre de Usuario", "Legajo" });
            cmbCategoria.Location = new Point(170, 27);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 2;
            cmbCategoria.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 3;
            label1.Text = "Seleccione Categoria:";
            label1.Click += label1_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(133, 75);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(319, 27);
            txtValor.TabIndex = 4;
            txtValor.Visible = false;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(13, 78);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(114, 20);
            lblValor.TabIndex = 5;
            lblValor.Text = "Ingrese el Valor:";
            lblValor.Visible = false;
            // 
            // lblCriteria
            // 
            lblCriteria.AutoEllipsis = true;
            lblCriteria.AutoSize = true;
            lblCriteria.BackColor = SystemColors.ActiveCaption;
            lblCriteria.Location = new Point(12, 151);
            lblCriteria.MaximumSize = new Size(784, 0);
            lblCriteria.Name = "lblCriteria";
            lblCriteria.Size = new Size(155, 20);
            lblCriteria.TabIndex = 6;
            lblCriteria.Text = "Criterio de busqueda: ";
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(358, 108);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(94, 29);
            btnAplicar.TabIndex = 7;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Visible = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label2.Location = new Point(557, 27);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 8;
            label2.Text = "Tipo de Usuario";
            // 
            // rdAlumno
            // 
            rdAlumno.AutoSize = true;
            rdAlumno.Location = new Point(479, 64);
            rdAlumno.Name = "rdAlumno";
            rdAlumno.Size = new Size(82, 24);
            rdAlumno.TabIndex = 9;
            rdAlumno.TabStop = true;
            rdAlumno.Text = "Alumno";
            rdAlumno.UseVisualStyleBackColor = true;
            rdAlumno.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdProfesor
            // 
            rdProfesor.AutoSize = true;
            rdProfesor.Location = new Point(567, 64);
            rdProfesor.Name = "rdProfesor";
            rdProfesor.Size = new Size(85, 24);
            rdProfesor.TabIndex = 10;
            rdProfesor.TabStop = true;
            rdProfesor.Text = "Profesor";
            rdProfesor.UseVisualStyleBackColor = true;
            rdProfesor.CheckedChanged += rdProfesor_CheckedChanged;
            // 
            // rdAdmin
            // 
            rdAdmin.AutoSize = true;
            rdAdmin.Location = new Point(658, 64);
            rdAdmin.Name = "rdAdmin";
            rdAdmin.Size = new Size(95, 24);
            rdAdmin.TabIndex = 11;
            rdAdmin.TabStop = true;
            rdAdmin.Text = "SysAdmin";
            rdAdmin.UseVisualStyleBackColor = true;
            rdAdmin.CheckedChanged += rdAdmin_CheckedChanged;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { apellido, nombre, email, username, legajo });
            dgvUsuarios.Location = new Point(13, 221);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(775, 188);
            dgvUsuarios.TabIndex = 12;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.MinimumWidth = 6;
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            apellido.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 125;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 125;
            // 
            // username
            // 
            username.HeaderText = "NombreUsuario";
            username.MinimumWidth = 6;
            username.Name = "username";
            username.ReadOnly = true;
            username.Width = 125;
            // 
            // legajo
            // 
            legajo.HeaderText = "Legajo";
            legajo.MinimumWidth = 6;
            legajo.Name = "legajo";
            legajo.ReadOnly = true;
            legajo.Width = 125;
            // 
            // frmUsuarioConsulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvUsuarios);
            Controls.Add(rdAdmin);
            Controls.Add(rdProfesor);
            Controls.Add(rdAlumno);
            Controls.Add(label2);
            Controls.Add(btnAplicar);
            Controls.Add(lblCriteria);
            Controls.Add(lblValor);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Controls.Add(cmbCategoria);
            Controls.Add(btnBuscar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmUsuarioConsulta";
            Text = "Form1";
            Load += frmUsuarioConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBuscar;
        private ComboBox cmbCategoria;
        private Label label1;
        private TextBox txtValor;
        private Label lblValor;
        private Label lblCriteria;
        private Button btnAplicar;
        private Label label2;
        private RadioButton rdAlumno;
        private RadioButton rdProfesor;
        private RadioButton rdAdmin;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn legajo;
    }
}