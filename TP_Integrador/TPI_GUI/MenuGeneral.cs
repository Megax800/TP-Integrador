using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_GUI
{
    public partial class MenuGeneral : Form
    {
        public MenuGeneral()
        {
            InitializeComponent();
        }

        private void usuariosTSM_Click(object sender, EventArgs e)
        {

        }

        private void consultaTSMI_Click(object sender, EventArgs e)
        {
            
        }

        private void UserAltaTSMI_Click(object sender, EventArgs e)
        {
            UsuariosAlta usuariosAlta = new UsuariosAlta();
            //usuariosAlta.MdiParent = this;
            usuariosAlta.Show();
        }
    }
}
