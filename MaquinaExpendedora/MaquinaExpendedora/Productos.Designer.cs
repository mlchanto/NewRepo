namespace MaquinaExpendedora
{
    partial class Productos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtCodigoA = new TextBox();
            txtCantidadA = new TextBox();
            btnConsultar = new Button();
            dgvStock = new DataGridView();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            administradorToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAgregarProducto = new Button();
            txtCantidadR = new TextBox();
            txtCodigoR = new TextBox();
            btnRemoverProducto = new Button();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCodigoA
            // 
            txtCodigoA.BackColor = Color.White;
            txtCodigoA.Location = new Point(193, 139);
            txtCodigoA.Name = "txtCodigoA";
            txtCodigoA.Size = new Size(119, 23);
            txtCodigoA.TabIndex = 0;
            // 
            // txtCantidadA
            // 
            txtCantidadA.BackColor = Color.White;
            txtCantidadA.Location = new Point(193, 190);
            txtCantidadA.Name = "txtCantidadA";
            txtCantidadA.Size = new Size(119, 23);
            txtCantidadA.TabIndex = 1;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.RoyalBlue;
            btnConsultar.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(712, 51);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(108, 32);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvStock
            // 
            dgvStock.BackgroundColor = Color.White;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvStock.DefaultCellStyle = dataGridViewCellStyle1;
            dgvStock.GridColor = Color.Black;
            dgvStock.Location = new Point(369, 102);
            dgvStock.Name = "dgvStock";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvStock.Size = new Size(481, 444);
            dgvStock.TabIndex = 1;
            dgvStock.CellContentClick += dgvStock_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(459, 55);
            label1.Name = "label1";
            label1.Size = new Size(226, 23);
            label1.TabIndex = 0;
            label1.Text = "Disponibilidad de productos";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, administradorToolStripMenuItem, ventasToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(862, 27);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(57, 23);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // administradorToolStripMenuItem
            // 
            administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            administradorToolStripMenuItem.Size = new Size(117, 23);
            administradorToolStripMenuItem.Text = "Administrador";
            administradorToolStripMenuItem.Click += administradorToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(80, 23);
            ventasToolStripMenuItem.Text = "Compras";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(51, 23);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(82, 57);
            label2.Name = "label2";
            label2.Size = new Size(216, 26);
            label2.TabIndex = 5;
            label2.Text = "Administrar productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(83, 139);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 6;
            label3.Text = "Código";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(83, 187);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 7;
            label4.Text = "Cantidad";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.RoyalBlue;
            btnAgregarProducto.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Location = new Point(178, 255);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(108, 32);
            btnAgregarProducto.TabIndex = 3;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // txtCantidadR
            // 
            txtCantidadR.BackColor = Color.White;
            txtCantidadR.Location = new Point(193, 413);
            txtCantidadR.Name = "txtCantidadR";
            txtCantidadR.Size = new Size(119, 23);
            txtCantidadR.TabIndex = 11;
            // 
            // txtCodigoR
            // 
            txtCodigoR.BackColor = Color.White;
            txtCodigoR.Location = new Point(193, 367);
            txtCodigoR.Name = "txtCodigoR";
            txtCodigoR.Size = new Size(119, 23);
            txtCodigoR.TabIndex = 10;
            // 
            // btnRemoverProducto
            // 
            btnRemoverProducto.BackColor = Color.RoyalBlue;
            btnRemoverProducto.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoverProducto.ForeColor = Color.White;
            btnRemoverProducto.Location = new Point(178, 482);
            btnRemoverProducto.Name = "btnRemoverProducto";
            btnRemoverProducto.Size = new Size(108, 32);
            btnRemoverProducto.TabIndex = 16;
            btnRemoverProducto.Text = "Remover";
            btnRemoverProducto.UseVisualStyleBackColor = false;
            btnRemoverProducto.Click += btnRemoverProducto_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(83, 367);
            label5.Name = "label5";
            label5.Size = new Size(65, 23);
            label5.TabIndex = 17;
            label5.Text = "Código";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(83, 413);
            label6.Name = "label6";
            label6.Size = new Size(80, 23);
            label6.TabIndex = 18;
            label6.Text = "Cantidad";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(862, 558);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnRemoverProducto);
            Controls.Add(txtCantidadR);
            Controls.Add(txtCodigoR);
            Controls.Add(dgvStock);
            Controls.Add(btnConsultar);
            Controls.Add(btnAgregarProducto);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCantidadA);
            Controls.Add(txtCodigoA);
            Controls.Add(menuStrip1);
            Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox txtCodigoA;
        private TextBox txtCantidadA;
        private Button btnConsultar;
        private DataGridView dgvStock;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem administradorToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAgregarProducto;
        private ToolStripMenuItem salirToolStripMenuItem;
        private TextBox txtCantidadR;
        private TextBox txtCodigoR;
        private Button btnRemoverProducto;
        private Label label5;
        private Label label6;
    }
}