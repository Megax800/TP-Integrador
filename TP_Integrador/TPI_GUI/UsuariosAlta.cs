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
    public partial class UsuariosAlta : Form
    {
        public Persona per;
        public Usuario buffer;
        public UsuariosAlta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUserPassword.Text == tbUserPasswordConfirm.Text)
            {
                UsuarioControlador CTL = new UsuarioControlador();
                CTL.AddUsuario(buffer);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void UsuariosAlta_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PersonaControlador CTL = new PersonaControlador();
            try
            {
                per = CTL.GetPersona(Convert.ToInt32(txtLegajo.Text));
                tbUserNombre.Text = per.Nombre;
                tbUserApellido.Text = per.Apellido;
                tbUserFecNac.Text = per.FechaNacimiento.ToShortDateString();
                tbUserEmail.Text = per.Email;

                buffer = new Usuario(per.Apellido ,per.Nombre, per.TipoPersona, per.FechaNacimiento, per.Legajo);
                tbUserUsername.Text = buffer.NombreUsuario;
                tbUserPassword.Text = buffer.Clave;
                tbUserPasswordConfirm.Text = buffer.Clave;
            }catch(Exception ex)
            {
                MessageBox.Show("Un error ha ocurrido: \n" + ex.ToString());
            }
            
        }
    }
}
