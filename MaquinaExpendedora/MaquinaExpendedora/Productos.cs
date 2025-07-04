using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaquinaExpendedora;

namespace MaquinaExpendedora
{
    public partial class Productos : Form
    {
        private Sistema sistema;
        public Productos(Sistema sistemaCompartido)
        {
            InitializeComponent();
             sistema = sistemaCompartido;
            
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            dgvStock.Columns.Clear();
            dgvStock.Columns.Add("Codigo", "Código");
            dgvStock.Columns.Add("Nombre", "Nombre");
            dgvStock.Columns.Add("Cantidad", "Cantidad");
            dgvStock.Columns.Add("Precio", "Precio");

             
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoA.Text.Trim();
            string cantidadTexto = txtCantidadA.Text.Trim();

            if (codigo.Length != 2 || !char.IsDigit(codigo[0]) || !char.IsDigit(codigo[1]))
            {
                MessageBox.Show("Código inválido.");
                txtCodigoA.Clear();
                txtCantidadA.Clear();
                
                return;
            }

            int cantidad = int.Parse(cantidadTexto);

            var pila = sistema.ObtenerPila(codigo);  
            if (pila == null)
            {
                MessageBox.Show("Código no encontrado.");
                txtCodigoA.Clear();
                txtCantidadA.Clear();
                return;
            }
            Producto p;


            ///Si la casilla tiene productos, usa el primero como referencia; si está vacía, crea uno nuevo según el código.
            if (pila.Count > 0)
            {
                p = pila.Peek();
            }
            else
            {
                
                switch (codigo)
                {
                    case "00": p = new Producto("Tronaditas", 300, 1); break;
                    case "01": p = new Producto("Doritos", 350, 1); break;
                    case "02": p = new Producto("Lays", 350, 1); break;
                    case "10": p = new Producto("Kitkat", 250, 1); break;
                    case "11": p = new Producto("Pringles", 400, 1); break;
                    case "12": p = new Producto("Chiky", 375, 1); break;
                    case "20": p = new Producto("Skittles", 300, 1); break;
                    case "21": p = new Producto("Agua Cristal", 500, 1); break;
                    case "22": p = new Producto("Oreo", 300, 1); break;
                    case "30": p = new Producto("Té frío", 450, 1); break;
                    case "31": p = new Producto("Coca-Cola", 500, 1); break;
                    case "32": p = new Producto("Cola-dieta", 500, 1); break;
                    case "40": p = new Producto("Redbull", 600, 1); break;
                    case "41": p = new Producto("Rompope", 300, 1); break;
                    case "42": p = new Producto("Fresca", 500, 1); break;
                    default:
                        
                        return;
                }
            }

            for (int i = 0; i < cantidad; i++)
            {
                pila.Push(new Producto(p.Nombre, p.Precio, 1));
            }

            foreach (DataGridViewRow fila in dgvStock.Rows)
            {
                if (fila.Cells["Codigo"].Value?.ToString() == codigo)
                {
                    fila.Cells["Cantidad"].Value = pila.Count;
                    MessageBox.Show("Producto agregado.");
                    txtCodigoA.Clear();
                    txtCantidadA.Clear();
                    break;
                }
            }

            
        }


        private void btnRemoverProducto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoR.Text.Trim();
            string cantidadTexto = txtCantidadR.Text.Trim();

            if (codigo.Length != 2 || !char.IsDigit(codigo[0]) || !char.IsDigit(codigo[1]))
            {
                MessageBox.Show("Código inválido.");
                txtCodigoR.Clear();
                txtCantidadR.Clear();
                return;
            }

            int cantidad = int.Parse(cantidadTexto);

            var pila = sistema.ObtenerPila(codigo);
            if (pila == null)
            {
                MessageBox.Show("Código no encontrado.");
                txtCodigoR.Clear();
                txtCantidadR.Clear();
                return;
            }

            if (pila.Count < cantidad)
            {
                MessageBox.Show("No hay suficientes productos para remover.");
                txtCodigoR.Clear();
                txtCantidadR.Clear();
                return;
            }

            for (int i = 0; i < cantidad; i++)
            {
                pila.Pop();
            }
 
            foreach (DataGridViewRow fila in dgvStock.Rows)
            {
                if (fila.Cells["Codigo"].Value?.ToString() == codigo)
                {
                    fila.Cells["Cantidad"].Value = pila.Count;
                    MessageBox.Show("Producto removido.");
                    txtCodigoR.Clear();
                    txtCantidadR.Clear();
                    break;
                }
            }

        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvStock.Rows.Clear();

            var productos = sistema.ObtenerPilas();

            foreach (var item in productos) 
            {
                string codigo = item.Key;
                Stack<Producto> pila = item.Value; //Obtiene el código y su pila de productos del diccionario.

                string nombre;
                decimal precio;

                if (pila.Count > 0)
                {
                    var p = pila.Peek(); //Si la pila tiene productos, toma el primero para obtener su nombre y precio.
                    nombre = p.Nombre;
                    precio = p.Precio;
                }
                else
                {
                     
                    switch (codigo)
                    {
                        case "00": nombre = "Tronaditas"; precio = 300; break;
                        case "01": nombre = "Doritos"; precio = 350; break;
                        case "02": nombre = "Lays"; precio = 350; break;
                        case "10": nombre = "Kitkat"; precio = 250; break;
                        case "11": nombre = "Pringles"; precio = 400; break;
                        case "12": nombre = "Chiky"; precio = 375; break;
                        case "20": nombre = "Skittles"; precio = 300; break;
                        case "21": nombre = "Agua Cristal"; precio = 500; break;
                        case "22": nombre = "Oreo"; precio = 300; break;
                        case "30": nombre = "Té frío"; precio = 450; break;
                        case "31": nombre = "Coca-Cola"; precio = 500; break;
                        case "32": nombre = "Cola-dieta"; precio = 500; break;
                        case "40": nombre = "Redbull"; precio = 600; break;
                        case "41": nombre = "Rompope"; precio = 300; break;
                        case "42": nombre = "Fresca"; precio = 500; break;
                        default: nombre = "(Desconocido)"; precio = 0; break;
                    }
                }

                dgvStock.Rows.Add(codigo, nombre, pila.Count, $"₡{precio}");
            }
        }


        public void ActualizarStockDesdeOtraVentana()
        {
            dgvStock.Rows.Clear();

            var productos = sistema.ObtenerPilas();

            foreach (var item in productos)
            {
                string codigo = item.Key; //extrae el codigo
                var pila = item.Value;

                if (pila.Count > 0) //si la pila tiene al menos un producto.
                {
                    var producto = pila.Peek();
                    dgvStock.Rows.Add(codigo, producto.Nombre, pila.Count, $"₡{producto.Precio}");
                    //agrega una fila al DataGridView con el código, nombre, cantidad y precio.
                }
                else
                {
                    dgvStock.Rows.Add(codigo, "(Vacío)", 0, "₡0"); //si no hay productos    
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

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras ventanaVentas = new Compras(sistema );
            ventanaVentas.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}