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
            panelMainContainer = new Panel();
            panelCardForm = new Panel();
            labelFornecedor = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
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
            panelTopHeader.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMainContainer
            // 
            panelMainContainer.BackColor = Color.FromArgb(245, 246, 248);
            panelMainContainer.Controls.Add(panelCardForm);
            panelMainContainer.Dock = DockStyle.Fill;
            panelMainContainer.Location = new Point(0, 145);
            panelMainContainer.Name = "panelMainContainer";
            panelMainContainer.Size = new Size(1106, 564);
            panelMainContainer.TabIndex = 6;
            // 
            // panelCardForm
            // 
            panelCardForm.BackColor = Color.White;
            panelCardForm.Controls.Add(labelFornecedor);
            panelCardForm.Controls.Add(comboBox1);
            panelCardForm.Controls.Add(label6);
            panelCardForm.Controls.Add(label1);
            panelCardForm.Controls.Add(label2);
            panelCardForm.Controls.Add(textBox1);
            panelCardForm.Controls.Add(label5);
            panelCardForm.Controls.Add(textBox4);
            panelCardForm.Controls.Add(label3);
            panelCardForm.Controls.Add(textBox3);
            panelCardForm.Controls.Add(label4);
            panelCardForm.Controls.Add(textBox2);
            panelCardForm.Location = new Point(35, 25);
            panelCardForm.Name = "panelCardForm";
            panelCardForm.Size = new Size(1010, 490);
            panelCardForm.TabIndex = 0;
            // 
            // labelFornecedor
            // 
            labelFornecedor.AutoSize = true;
            labelFornecedor.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            labelFornecedor.ForeColor = Color.FromArgb(60, 60, 60);
            labelFornecedor.Location = new Point(700, 75);
            labelFornecedor.Name = "labelFornecedor";
            labelFornecedor.Size = new Size(107, 21);
            labelFornecedor.TabIndex = 13;
            labelFornecedor.Text = "Fornecedor *";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(700, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 33);
            comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(60, 60, 60);
            label6.Location = new Point(1630, 25);
            label6.Name = "label6";
            label6.Size = new Size(150, 30);
            label6.TabIndex = 11;
            label6.Text = "ID: 00";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(199, 29, 44);
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(110, 35);
            label1.TabIndex = 0;
            label1.Text = "Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(60, 60, 60);
            label2.Location = new Point(35, 75);
            label2.Name = "label2";
            label2.Size = new Size(158, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome do Produto *";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(35, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(640, 32);
            textBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(60, 60, 60);
            label5.Location = new Point(35, 155);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 3;
            label5.Text = "Descrição";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11F);
            textBox4.Location = new Point(35, 182);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(935, 120);
            textBox4.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(60, 60, 60);
            label3.Location = new Point(35, 325);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 5;
            label3.Text = "Valor (R$) *";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F);
            textBox3.Location = new Point(35, 352);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(445, 32);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(60, 60, 60);
            label4.Location = new Point(525, 325);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 7;
            label4.Text = "Quantidade *";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(525, 352);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(445, 32);
            textBox2.TabIndex = 8;
            // 
            // panelHeaderDivider
            // 
            panelHeaderDivider.BackColor = Color.FromArgb(170, 20, 32);
            panelHeaderDivider.Dock = DockStyle.Top;
            panelHeaderDivider.Location = new Point(0, 143);
            panelHeaderDivider.Name = "panelHeaderDivider";
            panelHeaderDivider.Size = new Size(1106, 2);
            panelHeaderDivider.TabIndex = 7;
            // 
            // panelTopHeader
            // 
            panelTopHeader.BackColor = Color.FromArgb(199, 29, 44);
            panelTopHeader.Controls.Add(labelHeaderSub);
            panelTopHeader.Controls.Add(labelHeaderTitle);
            panelTopHeader.Dock = DockStyle.Top;
            panelTopHeader.Location = new Point(0, 53);
            panelTopHeader.Name = "panelTopHeader";
            panelTopHeader.Size = new Size(1106, 90);
            panelTopHeader.TabIndex = 5;
            // 
            // labelHeaderSub
            // 
            labelHeaderSub.AutoSize = true;
            labelHeaderSub.Font = new Font("Segoe UI", 9.5F);
            labelHeaderSub.ForeColor = Color.FromArgb(240, 240, 240);
            labelHeaderSub.Location = new Point(35, 52);
            labelHeaderSub.Name = "labelHeaderSub";
            labelHeaderSub.Size = new Size(222, 21);
            labelHeaderSub.TabIndex = 1;
            labelHeaderSub.Text = "Preencha os dados do produto";
            // 
            // labelHeaderTitle
            // 
            labelHeaderTitle.AutoSize = true;
            labelHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelHeaderTitle.ForeColor = Color.White;
            labelHeaderTitle.Location = new Point(30, 15);
            labelHeaderTitle.Name = "labelHeaderTitle";
            labelHeaderTitle.Size = new Size(293, 37);
            labelHeaderTitle.TabIndex = 0;
            labelHeaderTitle.Text = "Visualizar de Produto";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(199, 29, 44);
            menuStrip1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, produtoToolStripMenuItem, fornecedorToolStripMenuItem, estoqueToolStripMenuItem, colaboradorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(15, 8, 15, 8);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1106, 53);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.ForeColor = Color.White;
            dashboardToolStripMenuItem.Margin = new Padding(0, 0, 12, 0);
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Padding = new Padding(10, 4, 10, 4);
            dashboardToolStripMenuItem.Size = new Size(156, 37);
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
            produtoToolStripMenuItem.Size = new Size(132, 37);
            produtoToolStripMenuItem.Text = "📦 Produto";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            cadastroToolStripMenuItem.ForeColor = Color.White;
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(254, 30);
            cadastroToolStripMenuItem.Text = "Cadastrar Produto";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // editarProdutoToolStripMenuItem
            // 
            editarProdutoToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            editarProdutoToolStripMenuItem.ForeColor = Color.White;
            editarProdutoToolStripMenuItem.Name = "editarProdutoToolStripMenuItem";
            editarProdutoToolStripMenuItem.Size = new Size(254, 30);
            editarProdutoToolStripMenuItem.Text = "Editar Produto";
            editarProdutoToolStripMenuItem.Click += editarProdutoToolStripMenuItem_Click;
            // 
            // visualizarProdutoToolStripMenuItem
            // 
            visualizarProdutoToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            visualizarProdutoToolStripMenuItem.ForeColor = Color.White;
            visualizarProdutoToolStripMenuItem.Name = "visualizarProdutoToolStripMenuItem";
            visualizarProdutoToolStripMenuItem.Size = new Size(254, 30);
            visualizarProdutoToolStripMenuItem.Text = "Visualizar Produto";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarFornecedorToolStripMenuItem, editarFornecedorToolStripMenuItem, visualizarFornecedorToolStripMenuItem });
            fornecedorToolStripMenuItem.ForeColor = Color.White;
            fornecedorToolStripMenuItem.Margin = new Padding(0, 0, 12, 0);
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Padding = new Padding(10, 4, 10, 4);
            fornecedorToolStripMenuItem.Size = new Size(160, 37);
            fornecedorToolStripMenuItem.Text = "\U0001f91d Fornecedor";
            // 
            // cadastrarFornecedorToolStripMenuItem
            // 
            cadastrarFornecedorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            cadastrarFornecedorToolStripMenuItem.ForeColor = Color.White;
            cadastrarFornecedorToolStripMenuItem.Name = "cadastrarFornecedorToolStripMenuItem";
            cadastrarFornecedorToolStripMenuItem.Size = new Size(282, 30);
            cadastrarFornecedorToolStripMenuItem.Text = "Cadastrar Fornecedor";
            cadastrarFornecedorToolStripMenuItem.Click += cadastrarFornecedorToolStripMenuItem_Click;
            // 
            // editarFornecedorToolStripMenuItem
            // 
            editarFornecedorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            editarFornecedorToolStripMenuItem.ForeColor = Color.White;
            editarFornecedorToolStripMenuItem.Name = "editarFornecedorToolStripMenuItem";
            editarFornecedorToolStripMenuItem.Size = new Size(282, 30);
            editarFornecedorToolStripMenuItem.Text = "Editar Fornecedor";
            editarFornecedorToolStripMenuItem.Click += editarFornecedorToolStripMenuItem_Click;
            // 
            // visualizarFornecedorToolStripMenuItem
            // 
            visualizarFornecedorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            visualizarFornecedorToolStripMenuItem.ForeColor = Color.White;
            visualizarFornecedorToolStripMenuItem.Name = "visualizarFornecedorToolStripMenuItem";
            visualizarFornecedorToolStripMenuItem.Size = new Size(282, 30);
            visualizarFornecedorToolStripMenuItem.Text = "Visualizar Fornecedor";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualizarEstoqueToolStripMenuItem });
            estoqueToolStripMenuItem.ForeColor = Color.White;
            estoqueToolStripMenuItem.Margin = new Padding(0, 0, 12, 0);
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Padding = new Padding(10, 4, 10, 4);
            estoqueToolStripMenuItem.Size = new Size(131, 37);
            estoqueToolStripMenuItem.Text = "📊 Estoque";
            // 
            // visualizarEstoqueToolStripMenuItem
            // 
            visualizarEstoqueToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            visualizarEstoqueToolStripMenuItem.ForeColor = Color.White;
            visualizarEstoqueToolStripMenuItem.Name = "visualizarEstoqueToolStripMenuItem";
            visualizarEstoqueToolStripMenuItem.Size = new Size(253, 30);
            visualizarEstoqueToolStripMenuItem.Text = "Visualizar Estoque";
            visualizarEstoqueToolStripMenuItem.Click += visualizarEstoqueToolStripMenuItem_Click;
            // 
            // colaboradorToolStripMenuItem
            // 
            colaboradorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarColaboradorToolStripMenuItem, editarColaboradorToolStripMenuItem, visualizarColaboradorToolStripMenuItem });
            colaboradorToolStripMenuItem.ForeColor = Color.White;
            colaboradorToolStripMenuItem.Name = "colaboradorToolStripMenuItem";
            colaboradorToolStripMenuItem.Padding = new Padding(10, 4, 10, 4);
            colaboradorToolStripMenuItem.Size = new Size(169, 37);
            colaboradorToolStripMenuItem.Text = "👥 Colaborador";
            // 
            // cadastrarColaboradorToolStripMenuItem
            // 
            cadastrarColaboradorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            cadastrarColaboradorToolStripMenuItem.ForeColor = Color.White;
            cadastrarColaboradorToolStripMenuItem.Name = "cadastrarColaboradorToolStripMenuItem";
            cadastrarColaboradorToolStripMenuItem.Size = new Size(291, 30);
            cadastrarColaboradorToolStripMenuItem.Text = "Cadastrar Colaborador";
            cadastrarColaboradorToolStripMenuItem.Click += cadastrarColaboradorToolStripMenuItem_Click;
            // 
            // editarColaboradorToolStripMenuItem
            // 
            editarColaboradorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            editarColaboradorToolStripMenuItem.ForeColor = Color.White;
            editarColaboradorToolStripMenuItem.Name = "editarColaboradorToolStripMenuItem";
            editarColaboradorToolStripMenuItem.Size = new Size(291, 30);
            editarColaboradorToolStripMenuItem.Text = "Editar Colaborador";
            editarColaboradorToolStripMenuItem.Click += editarColaboradorToolStripMenuItem_Click;
            // 
            // visualizarColaboradorToolStripMenuItem
            // 
            visualizarColaboradorToolStripMenuItem.BackColor = Color.FromArgb(199, 29, 44);
            visualizarColaboradorToolStripMenuItem.ForeColor = Color.White;
            visualizarColaboradorToolStripMenuItem.Name = "visualizarColaboradorToolStripMenuItem";
            visualizarColaboradorToolStripMenuItem.Size = new Size(291, 30);
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
        private Label labelFornecedor;
        private ComboBox comboBox1;
        private Label label6;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
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