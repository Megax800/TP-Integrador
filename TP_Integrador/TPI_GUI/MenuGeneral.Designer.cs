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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuariosTSM });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(862, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuariosTSM
            // 
            usuariosTSM.DropDownItems.AddRange(new ToolStripItem[] { UserAltaTSMI, modificarToolStripMenuItem, bajaToolStripMenuItem, consultaTSMI });
            usuariosTSM.Name = "usuariosTSM";
            usuariosTSM.Size = new Size(79, 24);
            usuariosTSM.Text = "Usuarios";
            usuariosTSM.Click += usuariosTSM_Click;
            // 
            // UserAltaTSMI
            // 
            UserAltaTSMI.Name = "UserAltaTSMI";
            UserAltaTSMI.Size = new Size(224, 26);
            UserAltaTSMI.Text = "Alta";
            UserAltaTSMI.Click += UserAltaTSMI_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(224, 26);
            modificarToolStripMenuItem.Text = "Modificar";
            // 
            // bajaToolStripMenuItem
            // 
            bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            bajaToolStripMenuItem.Size = new Size(224, 26);
            bajaToolStripMenuItem.Text = "Baja";
            // 
            // consultaTSMI
            // 
            consultaTSMI.Name = "consultaTSMI";
            consultaTSMI.Size = new Size(224, 26);
            consultaTSMI.Text = "Consulta";
            consultaTSMI.Click += consultaTSMI_Click;
            // 
            // MenuGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 443);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuGeneral";
            Text = "Menu General";
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
    }
}