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
            UserAltaTSMI.Size = new Size(125, 22);
            UserAltaTSMI.Text = "Alta";
            UserAltaTSMI.Click += UserAltaTSMI_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(125, 22);
            modificarToolStripMenuItem.Text = "Modificar";
            // 
            // bajaToolStripMenuItem
            // 
            bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            bajaToolStripMenuItem.Size = new Size(125, 22);
            bajaToolStripMenuItem.Text = "Baja";
            // 
            // consultaTSMI
            // 
            consultaTSMI.Name = "consultaTSMI";
            consultaTSMI.Size = new Size(125, 22);
            consultaTSMI.Text = "Consulta";
            consultaTSMI.Click += consultaTSMI_Click;
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
    }
}