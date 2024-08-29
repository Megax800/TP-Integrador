namespace TPI_GUI
{
    partial class MenuGeneral
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
            usuariosTSM = new ToolStripMenuItem();
            UserAltaTSMI = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            bajaToolStripMenuItem = new ToolStripMenuItem();
            consultaTSMI = new ToolStripMenuItem();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            nuevoAlumnoToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem1 = new ToolStripMenuItem();
            bajaToolStripMenuItem1 = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            profesoresToolStripMenuItem = new ToolStripMenuItem();
            altaToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem2 = new ToolStripMenuItem();
            bajaToolStripMenuItem2 = new ToolStripMenuItem();
            consultaToolStripMenuItem1 = new ToolStripMenuItem();
            superUsuarioToolStripMenuItem = new ToolStripMenuItem();
            altaToolStripMenuItem1 = new ToolStripMenuItem();
            bajaToolStripMenuItem3 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuariosTSM, alumnosToolStripMenuItem, profesoresToolStripMenuItem, superUsuarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(754, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuariosTSM
            // 
            usuariosTSM.DropDownItems.AddRange(new ToolStripItem[] { UserAltaTSMI, modificarToolStripMenuItem, bajaToolStripMenuItem, consultaTSMI });
            usuariosTSM.Name = "usuariosTSM";
            usuariosTSM.Size = new Size(64, 20);
            usuariosTSM.Text = "Usuarios";
            usuariosTSM.Click += usuariosTSM_Click;
            // 
            // UserAltaTSMI
            // 
            UserAltaTSMI.Name = "UserAltaTSMI";
            UserAltaTSMI.Size = new Size(180, 22);
            UserAltaTSMI.Text = "Alta";
            UserAltaTSMI.Click += UserAltaTSMI_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(180, 22);
            modificarToolStripMenuItem.Text = "Modificar";
            // 
            // bajaToolStripMenuItem
            // 
            bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            bajaToolStripMenuItem.Size = new Size(180, 22);
            bajaToolStripMenuItem.Text = "Baja";
            // 
            // consultaTSMI
            // 
            consultaTSMI.Name = "consultaTSMI";
            consultaTSMI.Size = new Size(180, 22);
            consultaTSMI.Text = "Consulta";
            consultaTSMI.Click += consultaTSMI_Click;
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoAlumnoToolStripMenuItem, modificarToolStripMenuItem1, bajaToolStripMenuItem1, consultaToolStripMenuItem });
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(67, 20);
            alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // nuevoAlumnoToolStripMenuItem
            // 
            nuevoAlumnoToolStripMenuItem.Name = "nuevoAlumnoToolStripMenuItem";
            nuevoAlumnoToolStripMenuItem.Size = new Size(125, 22);
            nuevoAlumnoToolStripMenuItem.Text = "Alta";
            nuevoAlumnoToolStripMenuItem.Click += nuevoAlumnoToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem1
            // 
            modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            modificarToolStripMenuItem1.Size = new Size(125, 22);
            modificarToolStripMenuItem1.Text = "Modificar";
            // 
            // bajaToolStripMenuItem1
            // 
            bajaToolStripMenuItem1.Name = "bajaToolStripMenuItem1";
            bajaToolStripMenuItem1.Size = new Size(125, 22);
            bajaToolStripMenuItem1.Text = "Baja";
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(125, 22);
            consultaToolStripMenuItem.Text = "Consulta";
            // 
            // profesoresToolStripMenuItem
            // 
            profesoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaToolStripMenuItem, modificarToolStripMenuItem2, bajaToolStripMenuItem2, consultaToolStripMenuItem1 });
            profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            profesoresToolStripMenuItem.Size = new Size(74, 20);
            profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(180, 22);
            altaToolStripMenuItem.Text = "Alta";
            // 
            // modificarToolStripMenuItem2
            // 
            modificarToolStripMenuItem2.Name = "modificarToolStripMenuItem2";
            modificarToolStripMenuItem2.Size = new Size(180, 22);
            modificarToolStripMenuItem2.Text = "Modificar";
            // 
            // bajaToolStripMenuItem2
            // 
            bajaToolStripMenuItem2.Name = "bajaToolStripMenuItem2";
            bajaToolStripMenuItem2.Size = new Size(180, 22);
            bajaToolStripMenuItem2.Text = "Baja";
            // 
            // consultaToolStripMenuItem1
            // 
            consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            consultaToolStripMenuItem1.Size = new Size(180, 22);
            consultaToolStripMenuItem1.Text = "Consulta";
            // 
            // superUsuarioToolStripMenuItem
            // 
            superUsuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaToolStripMenuItem1, bajaToolStripMenuItem3 });
            superUsuarioToolStripMenuItem.Name = "superUsuarioToolStripMenuItem";
            superUsuarioToolStripMenuItem.Size = new Size(89, 20);
            superUsuarioToolStripMenuItem.Text = "SuperUsuario";
            // 
            // altaToolStripMenuItem1
            // 
            altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            altaToolStripMenuItem1.Size = new Size(180, 22);
            altaToolStripMenuItem1.Text = "Alta";
            // 
            // bajaToolStripMenuItem3
            // 
            bajaToolStripMenuItem3.Name = "bajaToolStripMenuItem3";
            bajaToolStripMenuItem3.Size = new Size(180, 22);
            bajaToolStripMenuItem3.Text = "Baja";
            // 
            // MenuGeneral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 332);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuGeneral";
            Text = "Menu General";
            Load += MenuGeneral_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuariosTSM;
        private ToolStripMenuItem UserAltaTSMI;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem bajaToolStripMenuItem;
        private ToolStripMenuItem consultaTSMI;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem nuevoAlumnoToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem1;
        private ToolStripMenuItem bajaToolStripMenuItem1;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem profesoresToolStripMenuItem;
        private ToolStripMenuItem altaToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem2;
        private ToolStripMenuItem bajaToolStripMenuItem2;
        private ToolStripMenuItem consultaToolStripMenuItem1;
        private ToolStripMenuItem superUsuarioToolStripMenuItem;
        private ToolStripMenuItem altaToolStripMenuItem1;
        private ToolStripMenuItem bajaToolStripMenuItem3;
    }
}