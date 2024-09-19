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
    public partial class frmPersonaABM : Form
    {
        int tipoPersona;
        public frmPersonaABM()
        {
            InitializeComponent();
        }

        public void tipoABM(int tipo)
        {
            tipoPersona = tipo;
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnABM_Click(object sender, EventArgs e)
        {
            PersonaControlador CTL = new PersonaControlador();
            Persona buffer = new Persona(txtApellido.Text, txtNombre.Text, CTL.devolverListaTipos(tipoPersona), pickerFechaNac.Value.Date);
            string rta = CTL.AddPersona(buffer);
            MessageBox.Show(rta);
            if (cbNuevoUsuario.Checked == true)
            {
                UsuariosAlta nuevoUsuario = new UsuariosAlta();
                nuevoUsuario.Show();
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
