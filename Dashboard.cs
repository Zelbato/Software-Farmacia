using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Software_Farmacia
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CarregarDadosDashboard();
        }

        private void CarregarDadosDashboard()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexao.conexao))
                {
                    conn.Open();

                    // 1. Quantidade Total de Produtos
                    string sqlProdutos = "SELECT COUNT(*) FROM Produto";
                    using (SqlCommand cmd = new SqlCommand(sqlProdutos, conn))
                    {
                        int totalProdutos = (int)cmd.ExecuteScalar();
                        lblCardProdutosValor.Text = totalProdutos.ToString("N0");
                    }

                    // 2. Quantidade Total de Colaboradores (Funcionários)
                    string sqlFuncionarios = "SELECT COUNT(*) FROM Funcionario";
                    using (SqlCommand cmd = new SqlCommand(sqlFuncionarios, conn))
                    {
                        int totalFuncionarios = (int)cmd.ExecuteScalar();
                        lblCardColaboradoresValor.Text = totalFuncionarios.ToString();
                    }

                    // 3. Opcional: Alertas de Estoque Baixo (Se você tiver o label correspondente na tela)
                    // string sqlEstoqueBaixo = "SELECT COUNT(*) FROM Produto WHERE Quantidade_produto < 10";
                    // using (SqlCommand cmd = new SqlCommand(sqlEstoqueBaixo, conn))
                    // {
                    //     int estoqueBaixo = (int)cmd.ExecuteScalar();
                    //     lblCardAlertasValor.Text = estoqueBaixo + " Baixos";
                    // }

                    // 4. Alimentar a Tabela (gridProdutos) do lado direito
                    string sqlTabela = "SELECT Id_produto AS [ID], Nome_produto AS [Produto], Quantidade_produto AS [Estoque], " +
                                       "CASE WHEN Quantidade_produto < 10 THEN 'Baixo' ELSE 'OK' END AS [Status] " +
                                       "FROM Produto";

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlTabela, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        gridProdutos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do Dashboard: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Navegação do MenuStrip ---
        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto CadastroP = new CadastroProduto();
            CadastroP.Show();
            this.Hide();
        }

        private void editarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarProduto EditarP = new EditarProduto();
            EditarP.Show();
            this.Hide();
        }

        private void visualizarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedor CadastroF = new CadastroFornecedor();
            CadastroF.Show();
            this.Hide();
        }

        private void editarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarFornecedor EditarF = new EditarFornecedor();
            EditarF.Show();
            this.Hide();
        }

        private void cadastrarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarColaborador CadastrarC = new CadastrarColaborador();
            CadastrarC.Show();
            this.Hide();
        }

        private void editarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarColaborador EditarC = new EditarColaborador();
            EditarC.Show();
            this.Hide();
        }

        private void gridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblCardProdutosValor_Click(object sender, EventArgs e) { }
        private void lblCardColaboradoresValor_Click(object sender, EventArgs e) { }
        private void panelGrafico_Paint(object sender, PaintEventArgs e) { }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visualizarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarEstoque VisualizarE = new VisualizarEstoque();
            VisualizarE.Show();
            this.Hide();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}