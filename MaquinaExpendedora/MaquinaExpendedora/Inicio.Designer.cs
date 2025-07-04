namespace MaquinaExpendedora
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            administradorToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            btnCompra = new Button();
            label6 = new Label();
            btnAdmi = new Button();
            btnSalir = new Button();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(93, 134);
            label1.Name = "label1";
            label1.Size = new Size(108, 26);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Corbel", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { administradorToolStripMenuItem, ventasToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(589, 26);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuInicio";
            // 
            // administradorToolStripMenuItem
            // 
            administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            administradorToolStripMenuItem.Size = new Size(108, 22);
            administradorToolStripMenuItem.Text = "Administrador";
            administradorToolStripMenuItem.Click += administradorToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(74, 22);
            ventasToolStripMenuItem.Text = "Comprar";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(46, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(171, 65);
            label2.Name = "label2";
            label2.Size = new Size(243, 29);
            label2.TabIndex = 4;
            label2.Text = "Máquina Expendedora";
            // 
            // btnCompra
            // 
            btnCompra.BackColor = Color.RoyalBlue;
            btnCompra.Image = Properties.Resources.icons8_agregar_a_carrito_de_compras_16;
            btnCompra.Location = new Point(366, 286);
            btnCompra.Name = "btnCompra";
            btnCompra.Size = new Size(88, 32);
            btnCompra.TabIndex = 14;
            btnCompra.UseVisualStyleBackColor = false;
            btnCompra.Click += btnCompra_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(93, 179);
            label6.Name = "label6";
            label6.Size = new Size(176, 23);
            label6.TabIndex = 15;
            label6.Text = "Selccione una opción:";
            // 
            // btnAdmi
            // 
            btnAdmi.BackColor = Color.RoyalBlue;
            btnAdmi.Image = (Image)resources.GetObject("btnAdmi.Image");
            btnAdmi.Location = new Point(366, 236);
            btnAdmi.Name = "btnAdmi";
            btnAdmi.Size = new Size(88, 32);
            btnAdmi.TabIndex = 16;
            btnAdmi.UseVisualStyleBackColor = false;
            btnAdmi.Click += btnAdmi_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.RoyalBlue;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(366, 337);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 32);
            btnSalir.TabIndex = 17;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(114, 239);
            label3.Name = "label3";
            label3.Size = new Size(230, 23);
            label3.TabIndex = 18;
            label3.Text = "Agregar/Remover productos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(114, 295);
            label5.Name = "label5";
            label5.Size = new Size(190, 23);
            label5.TabIndex = 19;
            label5.Text = "Comprar en la máquina";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(114, 346);
            label7.Name = "label7";
            label7.Size = new Size(163, 23);
            label7.TabIndex = 20;
            label7.Text = "Salir de la aplicación";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(589, 461);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnSalir);
            Controls.Add(btnAdmi);
            Controls.Add(label6);
            Controls.Add(btnCompra);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem administradorToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label label2;
        private Button btnCompra;
        private Label label6;
        private Button btnAdmi;
        private Button btnSalir;
        private Label label3;
        private Label label5;
        private Label label7;
    }
}
