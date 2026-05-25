using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Software_Farmacia
{
    public partial class VisualizarProduto : Form
    {
        public VisualizarProduto()
        {
            InitializeComponent();
        }

    // Método público para preencher os dados do produto de forma robusta
    public void SetProdutoData(int id, string nome, string descricao, decimal preco, int quantidade)
    {
        try
        {
            // Tenta vários nomes comuns para cada controle (fallbacks)
            string[] idNames = new[] { "labelId", "label7", "lblId", "lblIdProduto" };
            string[] nomeNames = new[] { "textBoxNome", "txtNome", "textBox1", "txtNomeProduto" };
            string[] descricaoNames = new[] { "textBoxDescricao", "txtDescricao", "textBox4", "txtDescricaoProduto" };
            string[] precoNames = new[] { "textBoxPreco", "txtPreco", "textBox3", "txtPrecoProduto" };
            string[] quantidadeNames = new[] { "textBoxQuantidade", "txtQuantidade", "textBox2", "txtQuantidadeProduto" };

            void TrySet(string[] names, string value, bool isTextBox = true)
            {
                foreach (var n in names)
                {
                    var ctrls = this.Controls.Find(n, true);
                    if (ctrls.Length > 0)
                    {
                        if (isTextBox && ctrls[0] is TextBox tb)
                        {
                            tb.Text = value;
                            return;
                        }
                        if (!isTextBox && ctrls[0] is Label lbl)
                        {
                            lbl.Text = value;
                            return;
                        }
                        // Se for outro tipo de controle com propriedade Text
                        var prop = ctrls[0].GetType().GetProperty("Text");
                        if (prop != null) { prop.SetValue(ctrls[0], value); return; }
                    }
                }
            }

            TrySet(idNames, id.ToString(), isTextBox: false);
            TrySet(nomeNames, nome);
            TrySet(descricaoNames, descricao);
            TrySet(precoNames, preco.ToString("N2", CultureInfo.GetCultureInfo("pt-BR")));
            TrySet(quantidadeNames, quantidade.ToString());
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao preencher dados de visualização: {ex.Message}");
        }
    }

        // Novo construtor que recebe dados do produto
        public VisualizarProduto(int id, string nome, string descricao, decimal preco, int quantidade)
        {
            InitializeComponent();

            try
            {
                // Preenche controles conforme nomes do Designer (ajuste se necessário)
                var lblId = this.Controls.Find("labelId", true);
                if (lblId.Length > 0) lblId[0].Text = id.ToString();

                var txtNome = this.Controls.Find("textBoxNome", true);
                if (txtNome.Length > 0) ((TextBox)txtNome[0]).Text = nome;

                var txtDescricao = this.Controls.Find("textBoxDescricao", true);
                if (txtDescricao.Length > 0) ((TextBox)txtDescricao[0]).Text = descricao;

                var txtPreco = this.Controls.Find("textBoxPreco", true);
                if (txtPreco.Length > 0) ((TextBox)txtPreco[0]).Text = preco.ToString("N2", CultureInfo.GetCultureInfo("pt-BR"));

                var txtQuantidade = this.Controls.Find("textBoxQuantidade", true);
                if (txtQuantidade.Length > 0) ((TextBox)txtQuantidade[0]).Text = quantidade.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao preencher dados na tela de visualização: {ex.Message}");
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(); dashboard.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto CadastroP = new CadastroProduto(); CadastroP.Show();
        }

        private void editarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarProduto EditarP = new EditarProduto(); EditarP.Show();
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedor CadastroF = new CadastroFornecedor(); CadastroF.Show();
        }

        private void editarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarFornecedor EditarF = new EditarFornecedor(); EditarF.Show();
        }

        private void visualizarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarEstoque VisualizarE = new VisualizarEstoque(); VisualizarE.Show();
        }

        private void cadastrarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarColaborador CadastrarC = new CadastrarColaborador(); CadastrarC.Show();
        }

        private void editarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarColaborador EditarC = new EditarColaborador(); EditarC.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
