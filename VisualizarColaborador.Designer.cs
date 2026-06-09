namespace Software_Farmacia
{
    partial class VisualizarColaborador
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            visualizarProdutoToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            cadastrarFornecedorToolStripMenuItem = new ToolStripMenuItem();
            visualizarFornecedorToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            visualizarEstoqueToolStripMenuItem = new ToolStripMenuItem();
            colaboradorToolStripMenuItem = new ToolStripMenuItem();
            cadastrarColaboradorToolStripMenuItem = new ToolStripMenuItem();
            visualizarColaboradorToolStripMenuItem = new ToolStripMenuItem();
            panelTopHeader = new Panel();
            labelHeaderSub = new Label();
            labelHeaderTitle = new Label();
            panelHeaderDivider = new Panel();
            panelMainContainer = new Panel();
            panelCardForm = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            btnVisualizar = new DataGridViewButtonColumn();
            btnEditar = new DataGridViewButtonColumn();
            btnDeletar = new DataGridViewButtonColumn();
            menuStrip1.SuspendLayout();
            panelTopHeader.SuspendLayout();
            panelMainContainer.SuspendLayout();
            panelCardForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            menuStrip1.Size = new Size(1080, 47);
            menuStrip1.TabIndex = 0;
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
            produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, visualizarProdutoToolStripMenuItem });
            produtoToolStripMenuItem.ForeColor = Color.White;
            produtoToolStripMenuItem.Margin = new Padding(0, 0, 15, 0);
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(118, 27);
            produtoToolStripMenuItem.Text = "📦 Produto";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            cadastroToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            cadastroToolStripMenuItem.ForeColor = Color.White;
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(227, 26);
            cadastroToolStripMenuItem.Text = "Cadastrar Produto";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // visualizarProdutoToolStripMenuItem
            // 
            visualizarProdutoToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            visualizarProdutoToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            visualizarProdutoToolStripMenuItem.ForeColor = Color.White;
            visualizarProdutoToolStripMenuItem.Name = "visualizarProdutoToolStripMenuItem";
            visualizarProdutoToolStripMenuItem.Size = new Size(227, 26);
            visualizarProdutoToolStripMenuItem.Text = "Visualizar Produto";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarFornecedorToolStripMenuItem, visualizarFornecedorToolStripMenuItem });
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
            colaboradorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarColaboradorToolStripMenuItem, visualizarColaboradorToolStripMenuItem });
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
            // visualizarColaboradorToolStripMenuItem
            // 
            visualizarColaboradorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            visualizarColaboradorToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            visualizarColaboradorToolStripMenuItem.ForeColor = Color.White;
            visualizarColaboradorToolStripMenuItem.Name = "visualizarColaboradorToolStripMenuItem";
            visualizarColaboradorToolStripMenuItem.Size = new Size(259, 26);
            visualizarColaboradorToolStripMenuItem.Text = "Visualizar Colaborador";
            visualizarColaboradorToolStripMenuItem.Click += visualizarColaboradorToolStripMenuItem_Click;
            // 
            // panelTopHeader
            // 
            panelTopHeader.BackColor = Color.FromArgb(199, 29, 44);
            panelTopHeader.Controls.Add(labelHeaderSub);
            panelTopHeader.Controls.Add(labelHeaderTitle);
            panelTopHeader.Dock = DockStyle.Top;
            panelTopHeader.Location = new Point(0, 47);
            panelTopHeader.Name = "panelTopHeader";
            panelTopHeader.Size = new Size(1080, 90);
            panelTopHeader.TabIndex = 1;
            // 
            // labelHeaderSub
            // 
            labelHeaderSub.AutoSize = true;
            labelHeaderSub.Font = new Font("Segoe UI", 9.5F);
            labelHeaderSub.ForeColor = Color.FromArgb(240, 240, 240);
            labelHeaderSub.Location = new Point(35, 52);
            labelHeaderSub.Name = "labelHeaderSub";
            labelHeaderSub.Size = new Size(294, 21);
            labelHeaderSub.TabIndex = 1;
            labelHeaderSub.Text = "Gerencie, edite ou remova colaboradores";
            // 
            // labelHeaderTitle
            // 
            labelHeaderTitle.AutoSize = true;
            labelHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelHeaderTitle.ForeColor = Color.White;
            labelHeaderTitle.Location = new Point(30, 15);
            labelHeaderTitle.Name = "labelHeaderTitle";
            labelHeaderTitle.Size = new Size(337, 37);
            labelHeaderTitle.TabIndex = 0;
            labelHeaderTitle.Text = "Visualizar Colaboradores";
            // 
            // panelHeaderDivider
            // 
            panelHeaderDivider.BackColor = Color.FromArgb(170, 20, 32);
            panelHeaderDivider.Dock = DockStyle.Top;
            panelHeaderDivider.Location = new Point(0, 137);
            panelHeaderDivider.Name = "panelHeaderDivider";
            panelHeaderDivider.Size = new Size(1080, 2);
            panelHeaderDivider.TabIndex = 2;
            // 
            // panelMainContainer
            // 
            panelMainContainer.BackColor = Color.FromArgb(245, 246, 248);
            panelMainContainer.Controls.Add(panelCardForm);
            panelMainContainer.Dock = DockStyle.Fill;
            panelMainContainer.Location = new Point(0, 139);
            panelMainContainer.Name = "panelMainContainer";
            panelMainContainer.Size = new Size(1080, 541);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, CPF, Cargo, Salario, Email, btnVisualizar, btnEditar, btnDeletar });
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
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 200;
            // 
            // CPF
            // 
            CPF.HeaderText = "CPF";
            CPF.MinimumWidth = 6;
            CPF.Name = "CPF";
            CPF.ReadOnly = true;
            CPF.Width = 140;
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 6;
            Cargo.Name = "Cargo";
            Cargo.ReadOnly = true;
            Cargo.Width = 140;
            // 
            // Salario
            // 
            Salario.HeaderText = "Salário";
            Salario.MinimumWidth = 6;
            Salario.Name = "Salario";
            Salario.ReadOnly = true;
            Salario.Width = 90;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 160;
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
            // VisualizarColaborador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1080, 680);
            Controls.Add(panelMainContainer);
            Controls.Add(panelHeaderDivider);
            Controls.Add(panelTopHeader);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "VisualizarColaborador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Software Farmácia - Colaboradores";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelTopHeader.ResumeLayout(false);
            panelTopHeader.PerformLayout();
            panelMainContainer.ResumeLayout(false);
            panelCardForm.ResumeLayout(false);
            panelCardForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem visualizarProdutoToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem cadastrarFornecedorToolStripMenuItem;
        private ToolStripMenuItem visualizarFornecedorToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem visualizarEstoqueToolStripMenuItem;
        private ToolStripMenuItem colaboradorToolStripMenuItem;
        private ToolStripMenuItem cadastrarColaboradorToolStripMenuItem;
        private ToolStripMenuItem visualizarColaboradorToolStripMenuItem;
        private Panel panelTopHeader;
        private Label labelHeaderSub;
        private Label labelHeaderTitle;
        private Panel panelHeaderDivider;
        private Panel panelMainContainer;
        private Panel panelCardForm;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Salario;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewButtonColumn btnVisualizar;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnDeletar;
    }
}
