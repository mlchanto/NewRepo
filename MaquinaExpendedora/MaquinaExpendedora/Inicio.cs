namespace MaquinaExpendedora
{
    public partial class Inicio : Form
    {
        private Sistema sistema = new Sistema();
        public Inicio()
        {
            InitializeComponent();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrador ventanaAdmin = new Administrador(sistema);
            ventanaAdmin.Show();
            this.Hide();


        }
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras ventanaVentas = new Compras(sistema);
            ventanaVentas.Show();
            this.Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmi_Click(object sender, EventArgs e)
        {
            Administrador ventanaAdmin = new Administrador(sistema);
            ventanaAdmin.Show();
            this.Hide();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            Compras ventanaVentas = new Compras(sistema);
            ventanaVentas.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
