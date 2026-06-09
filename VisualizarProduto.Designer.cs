namespace Software_Farmacia
{
    partial class VisualizarProduto
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelMainContainer = new Panel();
            panelCardForm = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Fornecedor = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            btnVisualizar = new DataGridViewButtonColumn();
            btnEditar = new DataGridViewButtonColumn();
            btnDeletar = new DataGridViewButtonColumn();
            panelHeaderDivider = new Panel();
            panelTopHeader = new Panel();
            labelHeaderSub = new Label();
            labelHeaderTitle = new Label();
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
            panelMainContainer.SuspendLayout();
            panelCardForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelTopHeader.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMainContainer
            // 
            panelMainContainer.BackColor = Color.FromArgb(245, 246, 248);
            panelMainContainer.Controls.Add(panelCardForm);
            panelMainContainer.Dock = DockStyle.Fill;
            panelMainContainer.Location = new Point(0, 147);
            panelMainContainer.Name = "panelMainContainer";
            panelMainContainer.Size = new Size(1106, 562);
            panelMainContainer.TabIndex = 3;
            // 
            // panelCardForm
            // 
            panelCardForm.BackColor = Color.White;
            panelCardForm.Controls.Add(label1);
            panelCardForm.Controls.Add(textBox1);
            panelCardForm.Controls.Add(button1);
            panelCardForm.Controls.Add(dataGridView1);
            panelCardForm.Location = new Point(35, 25);
            panelCardForm.Name = "panelCardForm";
            panelCardForm.Size = new Size(1010, 480);
            panelCardForm.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(60, 60, 60);
            label1.Location = new Point(30, 22);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 0;
            label1.Text = "Barra de Pesquisa";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(30, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 32);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.FromArgb(199, 29, 44);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(199, 29, 44);
            button1.Location = new Point(830, 43);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 2;
            button1.Text = "+ Cadastrar Novo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(199, 29, 44);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(199, 29, 44);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Fornecedor, Nome, Valor, Quantidade, btnVisualizar, btnEditar, btnDeletar });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(245, 246, 248);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(199, 29, 44);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(230, 230, 230);
            dataGridView1.Location = new Point(95, 117);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 38;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(822, 340);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 90;
            // 
            // Fornecedor
            // 
            Fornecedor.HeaderText = "Fornecedor";
            Fornecedor.MinimumWidth = 6;
            Fornecedor.Name = "Fornecedor";
            Fornecedor.ReadOnly = true;
            Fornecedor.Width = 140;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 200;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.MinimumWidth = 6;
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            Valor.Width = 90;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 6;
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            Quantidade.Width = 125;
            // 
            // btnVisualizar
            // 
            btnVisualizar.FlatStyle = FlatStyle.Flat;
            btnVisualizar.HeaderText = "Ações";
            btnVisualizar.MinimumWidth = 6;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.ReadOnly = true;
            btnVisualizar.Text = "👁️";
            btnVisualizar.UseColumnTextForButtonValue = true;
            btnVisualizar.Width = 60;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.HeaderText = "";
            btnEditar.MinimumWidth = 6;
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            btnEditar.Text = "✏️";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.Width = 60;
            // 
            // btnDeletar
            // 
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.HeaderText = "";
            btnDeletar.MinimumWidth = 6;
            btnDeletar.Name = "btnDeletar";
            btnDeletar.ReadOnly = true;
            btnDeletar.Text = "❌";
            btnDeletar.UseColumnTextForButtonValue = true;
            btnDeletar.Width = 60;
            // 
            // panelHeaderDivider
            // 
            panelHeaderDivider.BackColor = Color.FromArgb(170, 20, 32);
            panelHeaderDivider.Dock = DockStyle.Top;
            panelHeaderDivider.Location = new Point(0, 145);
            panelHeaderDivider.Name = "panelHeaderDivider";
            panelHeaderDivider.Size = new Size(1106, 2);
            panelHeaderDivider.TabIndex = 2;
            // 
            // panelTopHeader
            // 
            panelTopHeader.BackColor = Color.FromArgb(199, 29, 44);
            panelTopHeader.Controls.Add(labelHeaderSub);
            panelTopHeader.Controls.Add(labelHeaderTitle);
            panelTopHeader.Dock = DockStyle.Top;
            panelTopHeader.Location = new Point(0, 55);
            panelTopHeader.Name = "panelTopHeader";
            panelTopHeader.Size = new Size(1106, 90);
            panelTopHeader.TabIndex = 1;
            // 
            // labelHeaderSub
            // 
            labelHeaderSub.AutoSize = true;
            labelHeaderSub.Font = new Font("Segoe UI", 9.5F);
            labelHeaderSub.ForeColor = Color.FromArgb(240, 240, 240);
            labelHeaderSub.Location = new Point(35, 52);
            labelHeaderSub.Name = "labelHeaderSub";
            labelHeaderSub.Size = new Size(313, 21);
            labelHeaderSub.TabIndex = 1;
            labelHeaderSub.Text = "Gerencie, edite ou remova itens do catálogo";
            // 
            // labelHeaderTitle
            // 
            labelHeaderTitle.AutoSize = true;
            labelHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelHeaderTitle.ForeColor = Color.White;
            labelHeaderTitle.Location = new Point(30, 15);
            labelHeaderTitle.Name = "labelHeaderTitle";
            labelHeaderTitle.Size = new Size(266, 37);
            labelHeaderTitle.TabIndex = 0;
            labelHeaderTitle.Text = "Visualizar Produtos";
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
            menuStrip1.Size = new Size(1106, 55);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.ForeColor = Color.White;
            dashboardToolStripMenuItem.Margin = new Padding(0, 0, 12, 0);
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Padding = new Padding(10, 4, 10, 4);
            dashboardToolStripMenuItem.Size = new Size(150, 35);
            dashboardToolStripMenuItem.Text = "🏠 Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, editarProdutoToolStripMenuItem, visualizarProdutoToolStripMenuItem });
            produtoToolStripMenuItem.ForeColor = Color.White;
            produtoToolStripMenuItem.Margin = new Padding(0, 0, 12, 0);
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Padding = new Padding(10, 4, 10, 4);
            produtoToolStripMenuItem.Size = new Size(128, 35);
            produtoToolStripMenuItem.Text = "📦 Produto";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            cadastroToolStripMenuItem.ForeColor = Color.White;
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(241, 28);
            cadastroToolStripMenuItem.Text = "Cadastrar Produto";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // editarProdutoToolStripMenuItem
            // 
            editarProdutoToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            editarProdutoToolStripMenuItem.ForeColor = Color.White;
            editarProdutoToolStripMenuItem.Name = "editarProdutoToolStripMenuItem";
            editarProdutoToolStripMenuItem.Size = new Size(241, 28);
            editarProdutoToolStripMenuItem.Text = "Editar Produto";
            editarProdutoToolStripMenuItem.Click += editarProdutoToolStripMenuItem_Click;
            // 
            // visualizarProdutoToolStripMenuItem
            // 
            visualizarProdutoToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            visualizarProdutoToolStripMenuItem.ForeColor = Color.White;
            visualizarProdutoToolStripMenuItem.Name = "visualizarProdutoToolStripMenuItem";
            visualizarProdutoToolStripMenuItem.Size = new Size(241, 28);
            visualizarProdutoToolStripMenuItem.Text = "Visualizar Produto";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarFornecedorToolStripMenuItem, editarFornecedorToolStripMenuItem, visualizarFornecedorToolStripMenuItem });
            fornecedorToolStripMenuItem.ForeColor = Color.White;
            fornecedorToolStripMenuItem.Margin = new Padding(0, 0, 12, 0);
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Padding = new Padding(10, 4, 10, 4);
            fornecedorToolStripMenuItem.Size = new Size(153, 35);
            fornecedorToolStripMenuItem.Text = "\U0001f91d Fornecedor";
            // 
            // cadastrarFornecedorToolStripMenuItem
            // 
            cadastrarFornecedorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            cadastrarFornecedorToolStripMenuItem.ForeColor = Color.White;
            cadastrarFornecedorToolStripMenuItem.Name = "cadastrarFornecedorToolStripMenuItem";
            cadastrarFornecedorToolStripMenuItem.Size = new Size(266, 28);
            cadastrarFornecedorToolStripMenuItem.Text = "Cadastrar Fornecedor";
            cadastrarFornecedorToolStripMenuItem.Click += cadastrarFornecedorToolStripMenuItem_Click;
            // 
            // editarFornecedorToolStripMenuItem
            // 
            editarFornecedorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            editarFornecedorToolStripMenuItem.ForeColor = Color.White;
            editarFornecedorToolStripMenuItem.Name = "editarFornecedorToolStripMenuItem";
            editarFornecedorToolStripMenuItem.Size = new Size(266, 28);
            editarFornecedorToolStripMenuItem.Text = "Editar Fornecedor";
            editarFornecedorToolStripMenuItem.Click += editarFornecedorToolStripMenuItem_Click;
            // 
            // visualizarFornecedorToolStripMenuItem
            // 
            visualizarFornecedorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            visualizarFornecedorToolStripMenuItem.ForeColor = Color.White;
            visualizarFornecedorToolStripMenuItem.Name = "visualizarFornecedorToolStripMenuItem";
            visualizarFornecedorToolStripMenuItem.Size = new Size(266, 28);
            visualizarFornecedorToolStripMenuItem.Text = "Visualizar Fornecedor";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualizarEstoqueToolStripMenuItem });
            estoqueToolStripMenuItem.ForeColor = Color.White;
            estoqueToolStripMenuItem.Margin = new Padding(0, 0, 12, 0);
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Padding = new Padding(10, 4, 10, 4);
            estoqueToolStripMenuItem.Size = new Size(126, 35);
            estoqueToolStripMenuItem.Text = "📊 Estoque";
            // 
            // visualizarEstoqueToolStripMenuItem
            // 
            visualizarEstoqueToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            visualizarEstoqueToolStripMenuItem.ForeColor = Color.White;
            visualizarEstoqueToolStripMenuItem.Name = "visualizarEstoqueToolStripMenuItem";
            visualizarEstoqueToolStripMenuItem.Size = new Size(238, 28);
            visualizarEstoqueToolStripMenuItem.Text = "Visualizar Estoque";
            visualizarEstoqueToolStripMenuItem.Click += visualizarEstoqueToolStripMenuItem_Click;
            // 
            // colaboradorToolStripMenuItem
            // 
            colaboradorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarColaboradorToolStripMenuItem, editarColaboradorToolStripMenuItem, visualizarColaboradorToolStripMenuItem });
            colaboradorToolStripMenuItem.ForeColor = Color.White;
            colaboradorToolStripMenuItem.Name = "colaboradorToolStripMenuItem";
            colaboradorToolStripMenuItem.Padding = new Padding(10, 4, 10, 4);
            colaboradorToolStripMenuItem.Size = new Size(163, 35);
            colaboradorToolStripMenuItem.Text = "👥 Colaborador";
            // 
            // cadastrarColaboradorToolStripMenuItem
            // 
            cadastrarColaboradorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            cadastrarColaboradorToolStripMenuItem.ForeColor = Color.White;
            cadastrarColaboradorToolStripMenuItem.Name = "cadastrarColaboradorToolStripMenuItem";
            cadastrarColaboradorToolStripMenuItem.Size = new Size(276, 28);
            cadastrarColaboradorToolStripMenuItem.Text = "Cadastrar Colaborador";
            cadastrarColaboradorToolStripMenuItem.Click += cadastrarColaboradorToolStripMenuItem_Click;
            // 
            // editarColaboradorToolStripMenuItem
            // 
            editarColaboradorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            editarColaboradorToolStripMenuItem.ForeColor = Color.White;
            editarColaboradorToolStripMenuItem.Name = "editarColaboradorToolStripMenuItem";
            editarColaboradorToolStripMenuItem.Size = new Size(276, 28);
            editarColaboradorToolStripMenuItem.Text = "Editar Colaborador";
            editarColaboradorToolStripMenuItem.Click += editarColaboradorToolStripMenuItem_Click;
            // 
            // visualizarColaboradorToolStripMenuItem
            // 
            visualizarColaboradorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            visualizarColaboradorToolStripMenuItem.ForeColor = Color.White;
            visualizarColaboradorToolStripMenuItem.Name = "visualizarColaboradorToolStripMenuItem";
            visualizarColaboradorToolStripMenuItem.Size = new Size(276, 28);
            visualizarColaboradorToolStripMenuItem.Text = "Visualizar Colaborador";
            // 
            // VisualizarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 709);
            Controls.Add(panelMainContainer);
            Controls.Add(panelHeaderDivider);
            Controls.Add(panelTopHeader);
            Controls.Add(menuStrip1);
            Name = "VisualizarProduto";
            Text = "VisualizarProduto";
            panelMainContainer.ResumeLayout(false);
            panelCardForm.ResumeLayout(false);
            panelCardForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelTopHeader.ResumeLayout(false);
            panelTopHeader.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMainContainer;
        private Panel panelCardForm;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Fornecedor;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewButtonColumn btnVisualizar;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnDeletar;
        private Panel panelHeaderDivider;
        private Panel panelTopHeader;
        private Label labelHeaderSub;
        private Label labelHeaderTitle;
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
    }
}