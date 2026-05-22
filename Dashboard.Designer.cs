namespace Software_Farmacia
{
    partial class Dashboard
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

        //private void InitializeComponent()
        //{

        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            editarProdutoToolStripMenuItem = new ToolStripMenuItem();
            visualizarProdutoToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            cadastrarFornecedorToolStripMenuItem = new ToolStripMenuItem();
            editarFornecedorToolStripMenuItem = new ToolStripMenuItem();
            visualizarFornecedorToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            visualizarEstoqueToolStripMenuItem = new ToolStripMenuItem();
            colaboradorToolStripMenuItem = new ToolStripMenuItem();
            cadastrarColaboradorToolStripMenuItem = new ToolStripMenuItem();
            editarColaboradorToolStripMenuItem = new ToolStripMenuItem();
            visualizarColaboradorToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, produtoToolStripMenuItem, fornecedorToolStripMenuItem, estoqueToolStripMenuItem, colaboradorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(96, 24);
            dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, editarProdutoToolStripMenuItem, visualizarProdutoToolStripMenuItem });
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(76, 24);
            produtoToolStripMenuItem.Text = "Produto";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(224, 26);
            cadastroToolStripMenuItem.Text = "Cadastrar Produto";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // editarProdutoToolStripMenuItem
            // 
            editarProdutoToolStripMenuItem.Name = "editarProdutoToolStripMenuItem";
            editarProdutoToolStripMenuItem.Size = new Size(224, 26);
            editarProdutoToolStripMenuItem.Text = "Editar Produto";
            editarProdutoToolStripMenuItem.Click += editarProdutoToolStripMenuItem_Click;
            // 
            // visualizarProdutoToolStripMenuItem
            // 
            visualizarProdutoToolStripMenuItem.Name = "visualizarProdutoToolStripMenuItem";
            visualizarProdutoToolStripMenuItem.Size = new Size(224, 26);
            visualizarProdutoToolStripMenuItem.Text = "Visualizar Produto";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarFornecedorToolStripMenuItem, editarFornecedorToolStripMenuItem, visualizarFornecedorToolStripMenuItem });
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(98, 24);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // cadastrarFornecedorToolStripMenuItem
            // 
            cadastrarFornecedorToolStripMenuItem.Name = "cadastrarFornecedorToolStripMenuItem";
            cadastrarFornecedorToolStripMenuItem.Size = new Size(234, 26);
            cadastrarFornecedorToolStripMenuItem.Text = "Cadastrar Fornecedor";
            cadastrarFornecedorToolStripMenuItem.Click += cadastrarFornecedorToolStripMenuItem_Click;
            // 
            // editarFornecedorToolStripMenuItem
            // 
            editarFornecedorToolStripMenuItem.Name = "editarFornecedorToolStripMenuItem";
            editarFornecedorToolStripMenuItem.Size = new Size(234, 26);
            editarFornecedorToolStripMenuItem.Text = "Editar Fornecedor";
            editarFornecedorToolStripMenuItem.Click += editarFornecedorToolStripMenuItem_Click;
            // 
            // visualizarFornecedorToolStripMenuItem
            // 
            visualizarFornecedorToolStripMenuItem.Name = "visualizarFornecedorToolStripMenuItem";
            visualizarFornecedorToolStripMenuItem.Size = new Size(234, 26);
            visualizarFornecedorToolStripMenuItem.Text = "Visualizar Fornecedor";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualizarEstoqueToolStripMenuItem });
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(76, 24);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // visualizarEstoqueToolStripMenuItem
            // 
            visualizarEstoqueToolStripMenuItem.Name = "visualizarEstoqueToolStripMenuItem";
            visualizarEstoqueToolStripMenuItem.Size = new Size(224, 26);
            visualizarEstoqueToolStripMenuItem.Text = "Visualizar Estoque ";
            // 
            // colaboradorToolStripMenuItem
            // 
            colaboradorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarColaboradorToolStripMenuItem, editarColaboradorToolStripMenuItem, visualizarColaboradorToolStripMenuItem });
            colaboradorToolStripMenuItem.Name = "colaboradorToolStripMenuItem";
            colaboradorToolStripMenuItem.Size = new Size(107, 24);
            colaboradorToolStripMenuItem.Text = "Colaborador";
            // 
            // cadastrarColaboradorToolStripMenuItem
            // 
            cadastrarColaboradorToolStripMenuItem.Name = "cadastrarColaboradorToolStripMenuItem";
            cadastrarColaboradorToolStripMenuItem.Size = new Size(243, 26);
            cadastrarColaboradorToolStripMenuItem.Text = "Cadastrar Colaborador";
            cadastrarColaboradorToolStripMenuItem.Click += cadastrarColaboradorToolStripMenuItem_Click;
            // 
            // editarColaboradorToolStripMenuItem
            // 
            editarColaboradorToolStripMenuItem.Name = "editarColaboradorToolStripMenuItem";
            editarColaboradorToolStripMenuItem.Size = new Size(243, 26);
            editarColaboradorToolStripMenuItem.Text = "Editar Colaborador";
            editarColaboradorToolStripMenuItem.Click += editarColaboradorToolStripMenuItem_Click;
            // 
            // visualizarColaboradorToolStripMenuItem
            // 
            visualizarColaboradorToolStripMenuItem.Name = "visualizarColaboradorToolStripMenuItem";
            visualizarColaboradorToolStripMenuItem.Size = new Size(243, 26);
            visualizarColaboradorToolStripMenuItem.Text = "Visualizar Colaborador";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(150, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem editarProdutoToolStripMenuItem;
        private ToolStripMenuItem visualizarProdutoToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem cadastrarFornecedorToolStripMenuItem;
        private ToolStripMenuItem editarFornecedorToolStripMenuItem;
        private ToolStripMenuItem visualizarFornecedorToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem visualizarEstoqueToolStripMenuItem;
        private ToolStripMenuItem colaboradorToolStripMenuItem;
        private ToolStripMenuItem cadastrarColaboradorToolStripMenuItem;
        private ToolStripMenuItem editarColaboradorToolStripMenuItem;
        private ToolStripMenuItem visualizarColaboradorToolStripMenuItem;
        private DataGridView dataGridView1;
    }
}