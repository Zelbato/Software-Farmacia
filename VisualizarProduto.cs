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
        private List<ProdutoDados> todosProdutos = new List<ProdutoDados>();

        public VisualizarProduto()
        {
            InitializeComponent();
            GerarDadosIniciais();
            AtualizarTabela(todosProdutos);
        }

        // Método público para preencher os dados do produto de forma robusta (compatibilidade com VisualizarEstoque)
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

        private void GerarDadosIniciais()
        {
            string sql = @"SELECT p.Id_produto, p.Nome_produto, p.Preco_produto, p.Quantidade_produto,
                                    p.Id_fornecedorFK, f.Nome_fornecedor
                             FROM Produto p
                             LEFT JOIN Fornecedor f ON p.Id_fornecedorFK = f.Id_fornecedor";

            try
            {
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(Conexao.conexao))
                {
                    conn.Open();
                    using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn))
                    {
                        using (var da = new Microsoft.Data.SqlClient.SqlDataAdapter(cmd))
                        {
                            var dt = new DataTable();
                            da.Fill(dt);
                            todosProdutos.Clear();
                            foreach (DataRow row in dt.Rows)
                            {
                                todosProdutos.Add(new ProdutoDados(
                                    row["Id_produto"].ToString(),
                                    row["Nome_produto"].ToString(),
                                    row["Preco_produto"].ToString(),
                                    row["Quantidade_produto"].ToString(),
                                    row.Table.Columns.Contains("Nome_fornecedor") ? row["Nome_fornecedor"].ToString() : string.Empty
                                ));
                            }
                        }
                    }
                }
            }
            catch
            {
                // ignorar erros de leitura
            }
        }

        private void AtualizarTabela(List<ProdutoDados> listaParaExibir)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            foreach (var prod in listaParaExibir)
            {
                dataGridView1.Rows.Add(prod.IdFornecedor, prod.FornecedorNome, prod.Nome, prod.Valor, prod.Quantidade);
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(); dashboard.Show();
            this.Hide();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto CadastroP = new CadastroProduto(); CadastroP.Show();
            this.Hide();
        }

        private void editarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarProduto EditarP = new EditarProduto(); EditarP.Show();
            this.Hide();
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedor CadastroF = new CadastroFornecedor(); CadastroF.Show();
            this.Hide();
        }

        private void editarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarFornecedor EditarF = new EditarFornecedor(); EditarF.Show();
            this.Hide();
        }

        private void visualizarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarEstoque VisualizarE = new VisualizarEstoque(); VisualizarE.Show();
            this.Hide();
        }

        private void cadastrarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarColaborador CadastrarC = new CadastrarColaborador(); CadastrarC.Show();
            this.Hide();
        }

        private void editarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarColaborador EditarC = new EditarColaborador(); EditarC.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string termoPesquisa = textBox1.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(termoPesquisa))
            {
                AtualizarTabela(todosProdutos);
                return;
            }

            var resultados = new List<ProdutoDados>();
            foreach (var p in todosProdutos)
            {
                if ((p.Nome ?? string.Empty).ToLower().Contains(termoPesquisa) ||
                    (p.IdFornecedor ?? string.Empty).ToLower().Contains(termoPesquisa) ||
                    (p.FornecedorNome ?? string.Empty).ToLower().Contains(termoPesquisa) ||
                    (p.Valor ?? string.Empty).ToLower().Contains(termoPesquisa) ||
                    (p.Quantidade ?? string.Empty).ToLower().Contains(termoPesquisa))
                {
                    resultados.Add(p);
                }
            }

            AtualizarTabela(resultados);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nomeColuna = dataGridView1.Columns[e.ColumnIndex].Name;

            var row = dataGridView1.Rows[e.RowIndex];
            int id = 0; int.TryParse(row.Cells[0]?.Value?.ToString(), out id);
            string nome = row.Cells[2]?.Value?.ToString() ?? string.Empty;

            if (nomeColuna == "btnEditar")
            {
                string descricao = GetDescricaoProduto(id);
                decimal preco = 0m;
                decimal.TryParse(row.Cells[3]?.Value?.ToString(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), out preco);
                int quantidadeInt = 0; int.TryParse(row.Cells[4]?.Value?.ToString(), out quantidadeInt);

                using (var tela = new EditarProduto(id, nome, descricao, preco, quantidadeInt))
                {
                    tela.ShowDialog();
                }

                GerarDadosIniciais();
                AtualizarTabela(todosProdutos);
            }
            else if (nomeColuna == "btnVisualizar")
            {
                string descricao = GetDescricaoProduto(id);
                decimal preco = 0m;
                decimal.TryParse(row.Cells[3]?.Value?.ToString(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), out preco);
                int quantidadeInt = 0; int.TryParse(row.Cells[4]?.Value?.ToString(), out quantidadeInt);

                using (var tela = new EditarProduto(id, nome, descricao, preco, quantidadeInt))
                {
                    var btnSalvar = tela.Controls.Find("button1", true);
                    if (btnSalvar.Length > 0) ((Button)btnSalvar[0]).Enabled = false;
                    tela.ShowDialog();
                }
            }
            else if (nomeColuna == "btnDeletar")
            {
                DialogResult resultado = MessageBox.Show($"Tem certeza que deseja excluir o produto: {nome}?",
                                                        "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    todosProdutos.RemoveAll(p => p.Nome == nome && p.IdFornecedor == row.Cells[0]?.Value?.ToString());
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Busca a descrição do produto no banco pelo Id_produto
        private string GetDescricaoProduto(int produtoId)
        {
            if (produtoId <= 0) return string.Empty;

            try
            {
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(Conexao.conexao))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT Descricao_produto FROM Produto WHERE Id_produto = @Id";
                        cmd.Parameters.AddWithValue("@Id", produtoId);
                        var result = cmd.ExecuteScalar();
                        return result?.ToString() ?? string.Empty;
                    }
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroProduto CadastroP = new CadastroProduto();
            CadastroP.Show();
        }

        // Classe auxiliar para armazenar dados do produto
        private class ProdutoDados
        {
            public string IdFornecedor { get; }
            public string Nome { get; }
            public string Valor { get; }
            public string Quantidade { get; }
            public string FornecedorNome { get; }

            public ProdutoDados(string idProduto, string nome, string valor, string quantidade, string fornecedorNome)
            {
                IdFornecedor = idProduto ?? string.Empty;
                Nome = nome ?? string.Empty;
                Valor = valor ?? string.Empty;
                Quantidade = quantidade ?? string.Empty;
                FornecedorNome = fornecedorNome ?? string.Empty;
            }
        }

        private void panelCardForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
