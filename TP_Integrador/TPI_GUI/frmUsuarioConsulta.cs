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
    public partial class frmUsuarioConsulta : Form
    {
        string[] paramBusq = new string[6];
        int tipoUsuario;
        public frmUsuarioConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (paramBusq[0] == "")
            {
                MessageBox.Show("Ingrese el tipo de Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UsuarioControlador CTL = new UsuarioControlador();
                List<Usuario> resultados = CTL.GetUsuariosByType(tipoUsuario);
                dgvUsuarios.Rows.Clear();
                for (int i = 0; i < resultados.Count; i++)
                {
                    dgvUsuarios.Rows.Insert(i, resultados[i].Apellido, resultados[i].Nombre, resultados[i].Email, resultados[i].NombreUsuario, resultados[i].Legajo);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValor.Visible = true;
            txtValor.Visible = true;
            btnAplicar.Visible = true;
            txtValor.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            paramBusq[cmbCategoria.SelectedIndex + 1] = ", " + cmbCategoria.Text + "= " + txtValor.Text;
            actualizarCriteria();
        }

        private void frmUsuarioConsulta_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < paramBusq.Length; i++)
            {
                paramBusq[i] = "";
            }
        }

        private void actualizarCriteria()
        {
            lblCriteria.Text = "Criterio de Busqueda: ";
            for (int i = 0; i < paramBusq.Length; i++)
            {
                if (paramBusq[i] != "")
                {
                    lblCriteria.Text = lblCriteria.Text.Insert(lblCriteria.Text.Length, paramBusq[i]);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            paramBusq[0] = "Tipo de Usuario= Alumno";
            tipoUsuario = 2;
            actualizarCriteria();
        }

        private void rdProfesor_CheckedChanged(object sender, EventArgs e)
        {
            paramBusq[0] = "Tipo de Usuario= Profesor";
            tipoUsuario = 3;
            actualizarCriteria();
        }

        private void rdAdmin_CheckedChanged(object sender, EventArgs e)
        {
            paramBusq[0] = "Tipo de Usuario= SysAdmin";
            tipoUsuario = 1;
            actualizarCriteria();
        }

        private void usuarioBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
