using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        private void VisualizarProduto_Load(object sender, EventArgs e)
        {
        }

        private void GerarDadosIniciais()
        {
            todosProdutos.Add(new ProdutoDados("10", "Dipirona Monoidratada 500mg", "4,50", "120", "Analgésico e Antitérmico - Caixa c/ 10 comp."));
            todosProdutos.Add(new ProdutoDados("22", "Amoxicilina 500mg", "22,90", "45", "Antibiótico - Genérico Germed"));
            todosProdutos.Add(new ProdutoDados("05", "Protetor Solar FPS 60", "49,99", "15", "Toque seco - 50g"));
            todosProdutos.Add(new ProdutoDados("14", "Paracetamol Gotas 200mg/ml", "8,20", "60", "Uso pediátrico e adulto - 15ml"));
        }

        private void AtualizarTabela(List<ProdutoDados> listaParaExibir)
        {
            dataGridView1.Rows.Clear();
            foreach (var prod in listaParaExibir)
            {
                dataGridView1.Rows.Add(prod.IdFornecedor, prod.Nome, prod.Valor, prod.Quantidade, prod.Descricao);
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

            if (nomeColuna == "btnEditar")
            {
                EditarProduto telaEditar = new EditarProduto();
                telaEditar.ShowDialog();
            }
            else if (nomeColuna == "btnDeletar")
            {
                string nomeProduto = dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value?.ToString();
                string idFornecedor = dataGridView1.Rows[e.RowIndex].Cells["ID_Fornecedor"].Value?.ToString();

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
            VisualizarProduto visualizarP = new VisualizarProduto(); visualizarP.Show();
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
    }

    public class ProdutoDados
    {
        public string IdFornecedor { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string Quantidade { get; set; }
        public string Descricao { get; set; }

        public ProdutoDados(string idFornecedor, string nome, string valor, string quantidade, string descricao)
        {
            IdFornecedor = idFornecedor;
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
            Descricao = descricao;
        }
    }
}