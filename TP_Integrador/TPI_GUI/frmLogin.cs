using System.Configuration.Internal;
using TPI_Controller;

namespace TPI_GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Controlador CTL = new Controlador();
            switch (CTL.ValidaUser(txtNombre.Text, txtContraseña.Text))
            {
                case 0:
                    MessageBox.Show("Nombre de Usuario Incorrecto, Ingreselo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Contrase�a Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    MessageBox.Show("Login Correcto", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void btnViewPass_Click(object sender, EventArgs e)
        {
            Controlador CTL = new Controlador();
            MessageBox.Show(CTL.GetUsuario(txtNombre.Text).Clave);
        }
    }
}
