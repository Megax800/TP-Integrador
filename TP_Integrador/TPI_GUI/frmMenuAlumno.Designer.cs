namespace TPI_GUI
{
    partial class frmMenuAlumno
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
            menuStrip1 = new MenuStrip();
            alumnoToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            realizarUnaInscripcionToolStripMenuItem = new ToolStripMenuItem();
            modificarDatosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { alumnoToolStripMenuItem, cursosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // alumnoToolStripMenuItem
            // 
            alumnoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modificarDatosToolStripMenuItem });
            alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            alumnoToolStripMenuItem.Size = new Size(62, 20);
            alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { realizarUnaInscripcionToolStripMenuItem });
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(55, 20);
            cursosToolStripMenuItem.Text = "Cursos";
            // 
            // realizarUnaInscripcionToolStripMenuItem
            // 
            realizarUnaInscripcionToolStripMenuItem.Name = "realizarUnaInscripcionToolStripMenuItem";
            realizarUnaInscripcionToolStripMenuItem.Size = new Size(198, 22);
            realizarUnaInscripcionToolStripMenuItem.Text = "Realizar una inscripcion";
            // 
            // modificarDatosToolStripMenuItem
            // 
            modificarDatosToolStripMenuItem.Name = "modificarDatosToolStripMenuItem";
            modificarDatosToolStripMenuItem.Size = new Size(180, 22);
            modificarDatosToolStripMenuItem.Text = "Modificar Datos";
            // 
            // frmMenuAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenuAlumno";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem alumnoToolStripMenuItem;
        private ToolStripMenuItem modificarDatosToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private ToolStripMenuItem realizarUnaInscripcionToolStripMenuItem;
    }
}