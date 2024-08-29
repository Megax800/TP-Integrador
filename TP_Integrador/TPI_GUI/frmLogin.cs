using System.Configuration.Internal;
using TPI_Controller;

namespace TPI_GUI
{
    public partial class frmLogin : Form
    {
        private readonly MenuGeneral parentForm;
        public frmLogin(MenuGeneral form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioControlador CTL = new UsuarioControlador();
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
                    parentForm.user = CTL.GetUsuario(txtNombre.Text);
                    parentForm.habilitar();
                    this.Dispose();  
                    break;
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }
    }
}
