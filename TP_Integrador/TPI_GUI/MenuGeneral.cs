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
            menuStrip1.Enabled = true;
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
            menuStrip1.Enabled = false;
            login.MdiParent = this;
            login.Show();
                
        }
    }
}
