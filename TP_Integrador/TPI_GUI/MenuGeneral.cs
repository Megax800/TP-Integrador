using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_Controller;

namespace TPI_GUI
{
    public partial class MenuGeneral : Form
    {
        public MenuGeneral()
        {
            InitializeComponent();
        }

        public Usuario user;
        public void habilitar()
        {
            menuStrip1.Visible = true;
            switch (user.TipoUsuario)
            {
                case 2:
                    for(int i = 0; i<4; i++)
                    {
                        menuStrip1.Items[i].Visible = false;
                    }
                    break;
            }
        }

        private void usuariosTSM_Click(object sender, EventArgs e)
        {

        }

        private void consultaTSMI_Click(object sender, EventArgs e)
        {
            MessageBox.Show(user.NombreUsuario);
        }

        private void UserAltaTSMI_Click(object sender, EventArgs e)
        {
            UsuariosAlta usuariosAlta = new UsuariosAlta();
            usuariosAlta.MdiParent = this;
            usuariosAlta.Show();
        }

        private void MenuGeneral_Load(object sender, EventArgs e)
        {
            var login = new frmLogin(this);
            menuStrip1.Visible = false;
            login.MdiParent = this;
            login.Show();

        }

        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
