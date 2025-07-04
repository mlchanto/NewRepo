using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaExpendedora
{
    public partial class Administrador : Form
    {

        private Sistema sistema;

        public Administrador(Sistema sistemaCompartido)
        {
            InitializeComponent();
            sistema = sistemaCompartido;
        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Inicio ventanaInicio = new Inicio();
            ventanaInicio.Show();
            this.Hide();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text.Trim();
            string Contraseña = txtPass.Text.Trim();

            if (Usuario.ToLower() == "admin" && Contraseña == "1234")
            {

                Productos ventanaProductos = new Productos(sistema);
                ventanaProductos.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Clear();
                txtPass.Clear();

            }
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras ventanaVentas = new Compras(sistema);
            ventanaVentas.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }
    }
}