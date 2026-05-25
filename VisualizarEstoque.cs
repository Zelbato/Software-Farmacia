using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Software_Farmacia
{
    public partial class VisualizarEstoque : Form
    {
        private List<ProdutoDados> todosProdutos = new List<ProdutoDados>();

        public VisualizarEstoque()
        {
            InitializeComponent();
            GerarDadosIniciais();
            AtualizarTabela(todosProdutos);
        }

        private void VisualizarProduto_Load(object sender, EventArgs e)
        {
        }

        private void GerarDadosIniciais()
        {
            // Trazer também o nome do fornecedor (se existir) usando LEFT JOIN
            string sql = @"SELECT p.Id_produto, p.Nome_produto, p.Preco_produto, p.Quantidade_produto,
                                    p.Id_fornecedorFK, f.Nome_fornecedor
                             FROM Produto p
                             LEFT JOIN Fornecedor f ON p.Id_fornecedorFK = f.Id_fornecedor";

            using (SqlConnection conn = new SqlConnection(Conexao.conexao))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
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

        private void AtualizarTabela(List<ProdutoDados> listaParaExibir)
        {
            // Se o DataGridView estiver vinculado a uma fonte de dados, Rows.Clear() lança ArgumentException.
            // Liberar a fonte de dados antes de manipular as linhas manualmente.
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            foreach (var prod in listaParaExibir)
            {
                // As colunas no Designer estão na ordem: ID, Fornecedor, Nome, Valor, Quantidade, Ações.
                dataGridView1.Rows.Add(prod.IdFornecedor, prod.FornecedorNome, prod.Nome, prod.Valor, prod.Quantidade);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string termoPesquisa = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(termoPesquisa))
            {
                AtualizarTabela(todosProdutos);
                return;
            }

            List<ProdutoDados> resultadosFiltrados = new List<ProdutoDados>();

            foreach (var prod in todosProdutos)
            {
                if (prod.Nome.ToLower().Contains(termoPesquisa) ||
                    prod.IdFornecedor.ToLower().Contains(termoPesquisa) ||
                    prod.FornecedorNome.ToLower().Contains(termoPesquisa) ||
                    prod.Valor.ToLower().Contains(termoPesquisa) ||
                    prod.Quantidade.ToLower().Contains(termoPesquisa))
                {
                    resultadosFiltrados.Add(prod);
                }
            }

            AtualizarTabela(resultadosFiltrados);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nomeColuna = dataGridView1.Columns[e.ColumnIndex].Name;

            // Captura de forma segura os dados da linha selecionada baseado na ordem das colunas adicionadas no Rows.Add
            string idFornecedor = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
            string nomeProduto = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
            string valor = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString();
            string quantidade = dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString();

            if (nomeColuna == "btnEditar")
            {
                var grid = sender as DataGridView;
                if (grid == null || e.RowIndex < 0) return;

                var row = grid.Rows[e.RowIndex];

                // Ajuste: obter o Id do produto a partir da primeira célula (conforme AtualizarTabela)
                int id = 0;
                int.TryParse(row.Cells[0]?.Value?.ToString(), out id);

                string nome = row.Cells[2]?.Value?.ToString() ?? string.Empty;

                // Buscar a descrição diretamente no banco pelo Id do produto
                string descricao = GetDescricaoProduto(id);

                decimal preco = 0m;
                // usar cultura pt-BR para reconhecer vírgula como separador decimal
                decimal.TryParse(row.Cells[3]?.Value?.ToString(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), out preco);

                int quantidadeInt = 0;
                int.TryParse(row.Cells[4]?.Value?.ToString(), out quantidadeInt);

                using (var telaEditar = new EditarProduto(id, nome, descricao, preco, quantidadeInt))
                {
                    var result = telaEditar.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        // Recarrega o grid após edição
                        GerarDadosIniciais();
                        AtualizarTabela(todosProdutos);
                    }
                }
            }
            else if (nomeColuna == "btnVisualizar")
            {
                // Captura o Id do produto a partir da primeira célula
                int idVis = 0;
                int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0]?.Value?.ToString(), out idVis);

                string nomeVis = dataGridView1.Rows[e.RowIndex].Cells[2]?.Value?.ToString() ?? string.Empty;

                decimal precoVis = 0m;
                decimal.TryParse(dataGridView1.Rows[e.RowIndex].Cells[3]?.Value?.ToString(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), out precoVis);

                int quantidadeVis = 0;
                int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[4]?.Value?.ToString(), out quantidadeVis);

                // Busca descrição pelo Id caso não esteja no grid
                string descricaoVis = GetDescricaoProduto(idVis);

                // Abre a tela de visualização e preenche os campos via método público
                using (var telaVisualizar = new VisualizarProduto())
                {
                    telaVisualizar.SetProdutoData(idVis, nomeVis, descricaoVis, precoVis, quantidadeVis);
                    telaVisualizar.ShowDialog();
                }
            }
            else if (nomeColuna == "btnDeletar")
            {
                DialogResult resultado = MessageBox.Show($"Tem certeza que deseja excluir o produto: {nomeProduto}?",
                                                        "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    todosProdutos.RemoveAll(p => p.Nome == nomeProduto && p.IdFornecedor == idFornecedor);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroProduto CadastroP = new CadastroProduto();
            CadastroP.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(); dashboard.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto CadastroP = new CadastroProduto(); CadastroP.Show();
        }

        private void visualizarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedor CadastroF = new CadastroFornecedor(); CadastroF.Show();
        }

        private void editarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarFornecedor EditarF = new EditarFornecedor(); EditarF.Show();
        }

        private void cadastrarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarColaborador CadastrarC = new CadastrarColaborador(); CadastrarC.Show();
        }

        private void editarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarColaborador EditarC = new EditarColaborador(); EditarC.Show();
        }

        private void panelCardForm_Paint(object sender, PaintEventArgs e)
        {

        }

        // Busca a descrição do produto no banco pelo Id_produto
        private string GetDescricaoProduto(int produtoId)
        {
            if (produtoId <= 0) return string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexao.conexao))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT Descricao_produto FROM Produto WHERE Id_produto = @Id";
                        cmd.Parameters.AddWithValue("@Id", produtoId);
                        var result = cmd.ExecuteScalar();
                        return result?.ToString() ?? string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                // opcional: log
                return string.Empty;
            }
        }

        private void panelTopHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class ProdutoDados
    {
        public string IdFornecedor { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string Quantidade { get; set; }
        public string FornecedorNome { get; set; }
   

        public ProdutoDados(string idFornecedor, string nome, string valor, string quantidade, string fornecedorNome)
        {
            IdFornecedor = idFornecedor;
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
            FornecedorNome = fornecedorNome;
        }
    }
}