namespace Software_Farmacia
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            panelMainContainer = new Panel();
            cardProdutos = new Panel();
            lblCardProdutosValor = new Label();
            lblCardProdutosTitulo = new Label();
            cardProdutosLinha = new Panel();
            cardColaboradores = new Panel();
            lblCardColaboradoresValor = new Label();
            lblCardColaboradoresTitulo = new Label();
            cardColaboradoresLinha = new Panel();
            cardEstoque = new Panel();
            lblCardEstoqueValor = new Label();
            lblCardEstoqueTitulo = new Label();
            cardEstoqueLinha = new Panel();
            panelGrafico = new Panel();
            lblGraficoTitulo = new Label();
            gridProdutos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colQtd = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            panelMainContainer.SuspendLayout();
            cardProdutos.SuspendLayout();
            cardColaboradores.SuspendLayout();
            cardEstoque.SuspendLayout();
            panelGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdutos).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(199, 29, 44);
            menuStrip1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, produtoToolStripMenuItem, fornecedorToolStripMenuItem, estoqueToolStripMenuItem, colaboradorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(15, 10, 0, 10);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1150, 47);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.ForeColor = Color.White;
            dashboardToolStripMenuItem.Margin = new Padding(0, 0, 15, 0);
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(140, 27);
            dashboardToolStripMenuItem.Text = "🏠 Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, editarProdutoToolStripMenuItem, visualizarProdutoToolStripMenuItem });
            produtoToolStripMenuItem.ForeColor = Color.White;
            produtoToolStripMenuItem.Margin = new Padding(0, 0, 15, 0);
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(118, 27);
            produtoToolStripMenuItem.Text = "📦 Produto";
            produtoToolStripMenuItem.Click += produtoToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            cadastroToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            cadastroToolStripMenuItem.ForeColor = Color.White;
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(224, 26);
            cadastroToolStripMenuItem.Text = "Cadastrar Produto";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // editarProdutoToolStripMenuItem
            // 
            editarProdutoToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            editarProdutoToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            editarProdutoToolStripMenuItem.ForeColor = Color.White;
            editarProdutoToolStripMenuItem.Name = "editarProdutoToolStripMenuItem";
            editarProdutoToolStripMenuItem.Size = new Size(224, 26);
            editarProdutoToolStripMenuItem.Text = "Editar Produto";
            editarProdutoToolStripMenuItem.Click += editarProdutoToolStripMenuItem_Click;
            // 
            // visualizarProdutoToolStripMenuItem
            // 
            visualizarProdutoToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            visualizarProdutoToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            visualizarProdutoToolStripMenuItem.ForeColor = Color.White;
            visualizarProdutoToolStripMenuItem.Name = "visualizarProdutoToolStripMenuItem";
            visualizarProdutoToolStripMenuItem.Size = new Size(224, 26);
            visualizarProdutoToolStripMenuItem.Text = "Visualizar Produto";
            visualizarProdutoToolStripMenuItem.Click += visualizarProdutoToolStripMenuItem_Click;
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarFornecedorToolStripMenuItem, editarFornecedorToolStripMenuItem, visualizarFornecedorToolStripMenuItem });
            fornecedorToolStripMenuItem.ForeColor = Color.White;
            fornecedorToolStripMenuItem.Margin = new Padding(0, 0, 15, 0);
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(143, 27);
            fornecedorToolStripMenuItem.Text = "\U0001f91d Fornecedor";
            // 
            // cadastrarFornecedorToolStripMenuItem
            // 
            cadastrarFornecedorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            cadastrarFornecedorToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            cadastrarFornecedorToolStripMenuItem.ForeColor = Color.White;
            cadastrarFornecedorToolStripMenuItem.Name = "cadastrarFornecedorToolStripMenuItem";
            cadastrarFornecedorToolStripMenuItem.Size = new Size(252, 26);
            cadastrarFornecedorToolStripMenuItem.Text = "Cadastrar Fornecedor";
            cadastrarFornecedorToolStripMenuItem.Click += cadastrarFornecedorToolStripMenuItem_Click;
            // 
            // editarFornecedorToolStripMenuItem
            // 
            editarFornecedorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            editarFornecedorToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            editarFornecedorToolStripMenuItem.ForeColor = Color.White;
            editarFornecedorToolStripMenuItem.Name = "editarFornecedorToolStripMenuItem";
            editarFornecedorToolStripMenuItem.Size = new Size(252, 26);
            editarFornecedorToolStripMenuItem.Text = "Editar Fornecedor";
            editarFornecedorToolStripMenuItem.Click += editarFornecedorToolStripMenuItem_Click;
            // 
            // visualizarFornecedorToolStripMenuItem
            // 
            visualizarFornecedorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            visualizarFornecedorToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            visualizarFornecedorToolStripMenuItem.ForeColor = Color.White;
            visualizarFornecedorToolStripMenuItem.Name = "visualizarFornecedorToolStripMenuItem";
            visualizarFornecedorToolStripMenuItem.Size = new Size(252, 26);
            visualizarFornecedorToolStripMenuItem.Text = "Visualizar Fornecedor";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualizarEstoqueToolStripMenuItem });
            estoqueToolStripMenuItem.ForeColor = Color.White;
            estoqueToolStripMenuItem.Margin = new Padding(0, 0, 15, 0);
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(116, 27);
            estoqueToolStripMenuItem.Text = "📊 Estoque";
            estoqueToolStripMenuItem.Click += estoqueToolStripMenuItem_Click;
            // 
            // visualizarEstoqueToolStripMenuItem
            // 
            visualizarEstoqueToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            visualizarEstoqueToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            visualizarEstoqueToolStripMenuItem.ForeColor = Color.White;
            visualizarEstoqueToolStripMenuItem.Name = "visualizarEstoqueToolStripMenuItem";
            visualizarEstoqueToolStripMenuItem.Size = new Size(224, 26);
            visualizarEstoqueToolStripMenuItem.Text = "Visualizar Estoque";
            visualizarEstoqueToolStripMenuItem.Click += visualizarEstoqueToolStripMenuItem_Click;
            // 
            // colaboradorToolStripMenuItem
            // 
            colaboradorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarColaboradorToolStripMenuItem, editarColaboradorToolStripMenuItem, visualizarColaboradorToolStripMenuItem });
            colaboradorToolStripMenuItem.ForeColor = Color.White;
            colaboradorToolStripMenuItem.Margin = new Padding(0, 0, 15, 0);
            colaboradorToolStripMenuItem.Name = "colaboradorToolStripMenuItem";
            colaboradorToolStripMenuItem.Size = new Size(153, 27);
            colaboradorToolStripMenuItem.Text = "👥 Colaborador";
            // 
            // cadastrarColaboradorToolStripMenuItem
            // 
            cadastrarColaboradorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            cadastrarColaboradorToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            cadastrarColaboradorToolStripMenuItem.ForeColor = Color.White;
            cadastrarColaboradorToolStripMenuItem.Name = "cadastrarColaboradorToolStripMenuItem";
            cadastrarColaboradorToolStripMenuItem.Size = new Size(259, 26);
            cadastrarColaboradorToolStripMenuItem.Text = "Cadastrar Colaborador";
            cadastrarColaboradorToolStripMenuItem.Click += cadastrarColaboradorToolStripMenuItem_Click;
            // 
            // editarColaboradorToolStripMenuItem
            // 
            editarColaboradorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            editarColaboradorToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            editarColaboradorToolStripMenuItem.ForeColor = Color.White;
            editarColaboradorToolStripMenuItem.Name = "editarColaboradorToolStripMenuItem";
            editarColaboradorToolStripMenuItem.Size = new Size(259, 26);
            editarColaboradorToolStripMenuItem.Text = "Editar Colaborador";
            editarColaboradorToolStripMenuItem.Click += editarColaboradorToolStripMenuItem_Click;
            // 
            // visualizarColaboradorToolStripMenuItem
            // 
            visualizarColaboradorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            visualizarColaboradorToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            visualizarColaboradorToolStripMenuItem.ForeColor = Color.White;
            visualizarColaboradorToolStripMenuItem.Name = "visualizarColaboradorToolStripMenuItem";
            visualizarColaboradorToolStripMenuItem.Size = new Size(259, 26);
            visualizarColaboradorToolStripMenuItem.Text = "Visualizar Colaborador";
            // 
            // panelMainContainer
            // 
            panelMainContainer.BackColor = Color.White;
            panelMainContainer.Controls.Add(cardProdutos);
            panelMainContainer.Controls.Add(cardColaboradores);
            panelMainContainer.Controls.Add(cardEstoque);
            panelMainContainer.Controls.Add(panelGrafico);
            panelMainContainer.Controls.Add(gridProdutos);
            panelMainContainer.Dock = DockStyle.Fill;
            panelMainContainer.Location = new Point(0, 47);
            panelMainContainer.Name = "panelMainContainer";
            panelMainContainer.Size = new Size(1150, 653);
            panelMainContainer.TabIndex = 2;
            // 
            // cardProdutos
            // 
            cardProdutos.BackColor = Color.FromArgb(254, 242, 242);
            cardProdutos.Controls.Add(lblCardProdutosValor);
            cardProdutos.Controls.Add(lblCardProdutosTitulo);
            cardProdutos.Controls.Add(cardProdutosLinha);
            cardProdutos.Location = new Point(40, 30);
            cardProdutos.Name = "cardProdutos";
            cardProdutos.Size = new Size(320, 110);
            cardProdutos.TabIndex = 0;
            // 
            // lblCardProdutosValor
            // 
            lblCardProdutosValor.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCardProdutosValor.ForeColor = Color.FromArgb(199, 29, 44);
            lblCardProdutosValor.Location = new Point(15, 45);
            lblCardProdutosValor.Name = "lblCardProdutosValor";
            lblCardProdutosValor.Size = new Size(200, 50);
            lblCardProdutosValor.TabIndex = 0;
            lblCardProdutosValor.Text = "0";
            lblCardProdutosValor.Click += lblCardProdutosValor_Click;
            // 
            // lblCardProdutosTitulo
            // 
            lblCardProdutosTitulo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCardProdutosTitulo.ForeColor = Color.FromArgb(165, 28, 36);
            lblCardProdutosTitulo.Location = new Point(20, 20);
            lblCardProdutosTitulo.Name = "lblCardProdutosTitulo";
            lblCardProdutosTitulo.Size = new Size(200, 20);
            lblCardProdutosTitulo.TabIndex = 1;
            lblCardProdutosTitulo.Text = "TOTAL PRODUTOS";
            // 
            // cardProdutosLinha
            // 
            cardProdutosLinha.BackColor = Color.FromArgb(199, 29, 44);
            cardProdutosLinha.Dock = DockStyle.Left;
            cardProdutosLinha.Location = new Point(0, 0);
            cardProdutosLinha.Name = "cardProdutosLinha";
            cardProdutosLinha.Size = new Size(5, 110);
            cardProdutosLinha.TabIndex = 2;
            // 
            // cardColaboradores
            // 
            cardColaboradores.BackColor = Color.FromArgb(254, 242, 242);
            cardColaboradores.Controls.Add(lblCardColaboradoresValor);
            cardColaboradores.Controls.Add(lblCardColaboradoresTitulo);
            cardColaboradores.Controls.Add(cardColaboradoresLinha);
            cardColaboradores.Location = new Point(410, 30);
            cardColaboradores.Name = "cardColaboradores";
            cardColaboradores.Size = new Size(320, 110);
            cardColaboradores.TabIndex = 1;
            // 
            // lblCardColaboradoresValor
            // 
            lblCardColaboradoresValor.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCardColaboradoresValor.ForeColor = Color.FromArgb(199, 29, 44);
            lblCardColaboradoresValor.Location = new Point(15, 45);
            lblCardColaboradoresValor.Name = "lblCardColaboradoresValor";
            lblCardColaboradoresValor.Size = new Size(200, 50);
            lblCardColaboradoresValor.TabIndex = 0;
            lblCardColaboradoresValor.Text = "0";
            lblCardColaboradoresValor.Click += lblCardColaboradoresValor_Click;
            // 
            // lblCardColaboradoresTitulo
            // 
            lblCardColaboradoresTitulo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCardColaboradoresTitulo.ForeColor = Color.FromArgb(165, 28, 36);
            lblCardColaboradoresTitulo.Location = new Point(20, 20);
            lblCardColaboradoresTitulo.Name = "lblCardColaboradoresTitulo";
            lblCardColaboradoresTitulo.Size = new Size(200, 20);
            lblCardColaboradoresTitulo.TabIndex = 1;
            lblCardColaboradoresTitulo.Text = "COLABORADORES";
            // 
            // cardColaboradoresLinha
            // 
            cardColaboradoresLinha.BackColor = Color.FromArgb(199, 29, 44);
            cardColaboradoresLinha.Dock = DockStyle.Left;
            cardColaboradoresLinha.Location = new Point(0, 0);
            cardColaboradoresLinha.Name = "cardColaboradoresLinha";
            cardColaboradoresLinha.Size = new Size(5, 110);
            cardColaboradoresLinha.TabIndex = 2;
            // 
            // cardEstoque
            // 
            cardEstoque.BackColor = Color.FromArgb(254, 242, 242);
            cardEstoque.Controls.Add(lblCardEstoqueValor);
            cardEstoque.Controls.Add(lblCardEstoqueTitulo);
            cardEstoque.Controls.Add(cardEstoqueLinha);
            cardEstoque.Location = new Point(780, 30);
            cardEstoque.Name = "cardEstoque";
            cardEstoque.Size = new Size(330, 110);
            cardEstoque.TabIndex = 2;
            // 
            // lblCardEstoqueValor
            // 
            lblCardEstoqueValor.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCardEstoqueValor.ForeColor = Color.FromArgb(199, 29, 44);
            lblCardEstoqueValor.Location = new Point(15, 45);
            lblCardEstoqueValor.Name = "lblCardEstoqueValor";
            lblCardEstoqueValor.Size = new Size(200, 50);
            lblCardEstoqueValor.TabIndex = 0;
            lblCardEstoqueValor.Text = "0 Baixos";
            // 
            // lblCardEstoqueTitulo
            // 
            lblCardEstoqueTitulo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCardEstoqueTitulo.ForeColor = Color.FromArgb(165, 28, 36);
            lblCardEstoqueTitulo.Location = new Point(20, 20);
            lblCardEstoqueTitulo.Name = "lblCardEstoqueTitulo";
            lblCardEstoqueTitulo.Size = new Size(200, 20);
            lblCardEstoqueTitulo.TabIndex = 1;
            lblCardEstoqueTitulo.Text = "ALERTAS DE ESTOQUE";
            // 
            // cardEstoqueLinha
            // 
            cardEstoqueLinha.BackColor = Color.FromArgb(199, 29, 44);
            cardEstoqueLinha.Dock = DockStyle.Left;
            cardEstoqueLinha.Location = new Point(0, 0);
            cardEstoqueLinha.Name = "cardEstoqueLinha";
            cardEstoqueLinha.Size = new Size(5, 110);
            cardEstoqueLinha.TabIndex = 2;
            // 
            // panelGrafico
            // 
            panelGrafico.BackColor = Color.White;
            panelGrafico.BorderStyle = BorderStyle.FixedSingle;
            panelGrafico.Controls.Add(lblGraficoTitulo);
            panelGrafico.Location = new Point(40, 180);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(510, 430);
            panelGrafico.TabIndex = 3;
            panelGrafico.Paint += panelGrafico_Paint;
            // 
            // lblGraficoTitulo
            // 
            lblGraficoTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGraficoTitulo.ForeColor = Color.FromArgb(199, 29, 44);
            lblGraficoTitulo.Location = new Point(20, 20);
            lblGraficoTitulo.Name = "lblGraficoTitulo";
            lblGraficoTitulo.Size = new Size(400, 25);
            lblGraficoTitulo.TabIndex = 0;
            lblGraficoTitulo.Text = "📊 Desempenho Mensal de Vendas";
            // 
            // gridProdutos
            // 
            gridProdutos.AllowUserToAddRows = false;
            gridProdutos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            gridProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridProdutos.BackgroundColor = Color.White;
            gridProdutos.BorderStyle = BorderStyle.None;
            gridProdutos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridProdutos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(254, 242, 242);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(199, 29, 44);
            gridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridProdutos.ColumnHeadersHeight = 45;
            gridProdutos.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, colQtd, colStatus });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(199, 29, 44);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            gridProdutos.EnableHeadersVisualStyles = false;
            gridProdutos.GridColor = Color.FromArgb(254, 242, 242);
            gridProdutos.Location = new Point(590, 180);
            gridProdutos.Name = "gridProdutos";
            gridProdutos.ReadOnly = true;
            gridProdutos.RowHeadersVisible = false;
            gridProdutos.RowHeadersWidth = 51;
            gridProdutos.RowTemplate.Height = 40;
            gridProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridProdutos.Size = new Size(520, 430);
            gridProdutos.TabIndex = 4;
            gridProdutos.CellContentClick += gridProdutos_CellContentClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "ID";
            colId.FillWeight = 35F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNome
            // 
            colNome.DataPropertyName = "Produto";
            colNome.HeaderText = "Produto";
            colNome.MinimumWidth = 6;
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colQtd
            // 
            colQtd.DataPropertyName = "Estoque";
            colQtd.HeaderText = "Estoque";
            colQtd.MinimumWidth = 6;
            colQtd.Name = "colQtd";
            colQtd.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1150, 700);
            Controls.Add(panelMainContainer);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Software Farmácia - Dashboard Administrativo";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelMainContainer.ResumeLayout(false);
            cardProdutos.ResumeLayout(false);
            cardColaboradores.ResumeLayout(false);
            cardEstoque.ResumeLayout(false);
            panelGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarColaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarColaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarColaboradorToolStripMenuItem;

        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Panel cardProdutos;
        private System.Windows.Forms.Panel cardProdutosLinha;
        private System.Windows.Forms.Label lblCardProdutosTitulo;
        private System.Windows.Forms.Label lblCardProdutosValor;
        private System.Windows.Forms.Panel cardColaboradores;
        private System.Windows.Forms.Panel cardColaboradoresLinha;
        private System.Windows.Forms.Label lblCardColaboradoresTitulo;
        private System.Windows.Forms.Label lblCardColaboradoresValor;
        private System.Windows.Forms.Panel cardEstoque;
        private System.Windows.Forms.Panel cardEstoqueLinha;
        private System.Windows.Forms.Label lblCardEstoqueTitulo;
        private System.Windows.Forms.Label lblCardEstoqueValor;
        private System.Windows.Forms.Panel panelGrafico;
        private System.Windows.Forms.Label lblGraficoTitulo;
        private System.Windows.Forms.DataGridView gridProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}