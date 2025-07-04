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

    public partial class Compras : Form
    {

        private Sistema sistema;
        public Compras(Sistema sistemaCompartido)
        {
            InitializeComponent();
            sistema = sistemaCompartido;
        }


        private void btnComprar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoV.Text.Trim();
            string efectivoTexto = txtEfectivoV.Text.Trim();

            LabResultado.Text = "";

            if (!sistema.ExisteCodigo(codigo))
            {
                LabResultado.Text = "Código inválido.";
                txtCodigoV.Clear();
                txtEfectivoV.Clear();
                return;
            }



            if (!decimal.TryParse(efectivoTexto, out decimal efectivo) || efectivo <= 0)
            {
                LabResultado.Text = "Monto inválido.";
                txtCodigoV.Clear();
                txtEfectivoV.Clear();
                return;
            }

            var pila = sistema.ObtenerPila(codigo);

            if (pila == null || pila.Count == 0)
            {
                LabResultado.Text = "Producto agotado.";
                txtCodigoV.Clear();
                txtEfectivoV.Clear();
                return;
            }


            var producto = pila.Peek();

            if (efectivo < producto.Precio)
            {
                LabResultado.Text = $"Efectivo insuficiente. Precio: ₡{producto.Precio}";
                txtCodigoV.Clear();
                txtEfectivoV.Clear();
                return;
            }

            pila.Pop();

            string nombreLabel = $"lab{codigo}";     
            var controles = this.Controls.Find(nombreLabel, true); 
            if (controles.Length > 0 && controles[0] is Label label)
            {
                label.Text = pila.Count.ToString("00");
            }

            decimal vuelto = efectivo - producto.Precio;
            LabResultado.Text = $"Compra exitosa. Vuelto: ₡{vuelto}";

            foreach (Form form in Application.OpenForms)//todas las ventanas
            {
                if (form is Productos productosForm)
                {
                    productosForm.ActualizarStockDesdeOtraVentana();
                    break;
                }
            }

            txtCodigoV.Clear();
            txtEfectivoV.Clear();
        }


        public void ActualizarLabelsStock() // Actualiza las etiquetas (Label) del formulario mostrando la cantidad de
                                            // productos en cada casilla según su código.
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label label &&
                    label.Name.StartsWith("lab") &&
                    label.BackColor == Color.Black)
                {
                    string codigo = label.Name.Substring(3);
                    var pila = sistema.ObtenerPila(codigo);

                    int cantidad = pila?.Count ?? 0;//cantidad de productos
                    label.Text = cantidad.ToString("00");
                }
            }
        }


        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio ventanaInicio = new Inicio();
            ventanaInicio.Show();
            this.Hide();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrador ventanaAdmin = new Administrador(sistema);
            ventanaAdmin.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LabResultado_Click(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            ActualizarLabelsStock();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}