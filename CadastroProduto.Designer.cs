namespace Software_Farmacia
{
    partial class CadastroProduto
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
            panel1 = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            menuStrip1.TabIndex = 2;
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
            produtoToolStripMenuItem.Click += produtoToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(224, 26);
            cadastroToolStripMenuItem.Text = "Cadastrar Produto";
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
            // 
            // editarFornecedorToolStripMenuItem
            // 
            editarFornecedorToolStripMenuItem.Name = "editarFornecedorToolStripMenuItem";
            editarFornecedorToolStripMenuItem.Size = new Size(234, 26);
            editarFornecedorToolStripMenuItem.Text = "Editar Fornecedor";
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
            visualizarEstoqueToolStripMenuItem.Size = new Size(216, 26);
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
            // 
            // editarColaboradorToolStripMenuItem
            // 
            editarColaboradorToolStripMenuItem.Name = "editarColaboradorToolStripMenuItem";
            editarColaboradorToolStripMenuItem.Size = new Size(243, 26);
            editarColaboradorToolStripMenuItem.Text = "Editar Colaborador";
            // 
            // visualizarColaboradorToolStripMenuItem
            // 
            visualizarColaboradorToolStripMenuItem.Name = "visualizarColaboradorToolStripMenuItem";
            visualizarColaboradorToolStripMenuItem.Size = new Size(243, 26);
            visualizarColaboradorToolStripMenuItem.Text = "Visualizar Colaborador";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 418);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(57, 213);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(663, 66);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(574, 132);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(146, 27);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(304, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(517, 340);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(626, 340);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F);
            label5.Location = new Point(57, 195);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 4;
            label5.Text = "Descrição do Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F);
            label4.Location = new Point(304, 114);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Qtde Produto";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F);
            label3.Location = new Point(574, 114);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Preço Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F);
            label2.Location = new Point(57, 114);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome Produto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 62);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(33, 10);
            label1.Name = "label1";
            label1.Size = new Size(302, 41);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produto ";
            label1.Click += label1_Click;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "CadastroProduto";
            Text = "CadastroProduto";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
    }
}