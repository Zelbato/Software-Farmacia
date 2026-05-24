using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Software_Farmacia
{
    public partial class EditarProduto : Form
    {
        public EditarProduto()
        {
            InitializeComponent();
            CarregarFornecedores();
        }

        private void CarregarFornecedores()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexao.conexao))
                {
                    conn.Open();

                    string sql =
                    "SELECT Id_fornecedor, Nome_fornecedor " +
                    "FROM Fornecedor " +
                    "ORDER BY Nome_fornecedor";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            comboBox1.DataSource = dt;
                            comboBox1.DisplayMember = "Nome_fornecedor";
                            comboBox1.ValueMember = "Id_fornecedor";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar fornecedores: {ex.Message}");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            int quantidade = int.Parse(textBox2.Text);
            float preco = float.Parse(textBox3.Text);
            string descricao = textBox4.Text;

            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um fornecedor.");
                return;
            }

            string idFornecedor = comboBox1.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection(Conexao.conexao))
            {
                conn.Open();

                string sql =
                "UPDATE Produto SET " +
                "Nome_produto = @nome, " +
                "Quantidade_produto = @quantidade, " +
                "Preco_produto = @preco, " +
                "Descricao_produto = @descricao, " +
                "Id_fornecedorFK = @idFornecedor " +
                "WHERE Id_produto = @id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@preco", preco);
                    cmd.Parameters.AddWithValue("@descricao", descricao);
                    cmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Produto alterado com sucesso!\n\nNome: " + nome);
        }
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastroP = new CadastroProduto();
            cadastroP.Show();
        }

        private void editarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarProduto EditarP = new EditarProduto();
            EditarP.Show();
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedor CadastroF = new CadastroFornecedor();
            CadastroF.Show();
        }

        private void editarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarFornecedor EditarF = new EditarFornecedor();
            EditarF.Show();
        }

        private void cadastrarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarColaborador CadastrarC = new CadastrarColaborador();
            CadastrarC.Show();
        }

        private void editarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarColaborador EditarC = new EditarColaborador();
            EditarC.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panelCardForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}