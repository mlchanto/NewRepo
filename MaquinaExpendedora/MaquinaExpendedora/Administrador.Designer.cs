namespace MaquinaExpendedora
{
    partial class Administrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            Usuario = new Label();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnIngresar = new Button();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usuario.ForeColor = Color.Black;
            Usuario.Location = new Point(258, 175);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(70, 23);
            Usuario.TabIndex = 0;
            Usuario.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(258, 246);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 1;
            label1.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.WhiteSmoke;
            txtUsuario.Location = new Point(229, 206);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(159, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.WhiteSmoke;
            txtPass.Location = new Point(229, 282);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(159, 23);
            txtPass.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.RoyalBlue;
            btnIngresar.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.AliceBlue;
            btnIngresar.Location = new Point(240, 353);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(139, 46);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(153, 66);
            label2.Name = "label2";
            label2.Size = new Size(276, 29);
            label2.TabIndex = 5;
            label2.Text = "Ventana de administrador";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Corbel", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, ventasToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(590, 26);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(53, 22);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click_1;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(75, 22);
            ventasToolStripMenuItem.Text = "Compras";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(46, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(84, 125);
            label3.Name = "label3";
            label3.Size = new Size(265, 23);
            label3.TabIndex = 7;
            label3.Text = "Ingrese el usuario y la contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_proveedor_16;
            pictureBox1.Location = new Point(231, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 18);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(229, 246);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(590, 454);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnIngresar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(Usuario);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Administrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            Load += Administrador_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Usuario;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnIngresar;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}