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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
            ExibirProximoID();
            CarregarFornecedores();
        }

        private void ExibirProximoID()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexao.conexao))
                {
                    conn.Open();
                    string sql = "SELECT IDENT_CURRENT('Produto') + IDENT_INCR('Produto')";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        object resultado = cmd.ExecuteScalar();
                        if (resultado != DBNull.Value && resultado != null)
                        {
                            int proximoId = Convert.ToInt32(resultado);
                            label6.Text = $"ID: {proximoId:D2}";
                        }
                    }
                }
            }
            catch
            {
                label6.Text = "ID: --";
            }
        }

        private void CarregarFornecedores()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexao.conexao))
                {
                    conn.Open();
                    string sql = "SELECT ID_Fornecedor, Nome_fornecedor FROM Fornecedor ORDER BY Nome_fornecedor";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            comboBox1.DataSource = dt;
                            comboBox1.DisplayMember = "Nome_fornecedor";
                            comboBox1.ValueMember = "ID_Fornecedor";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar fornecedores: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string quantidade = textBox2.Text;
            string preco = textBox3.Text;
            string descricao = textBox4.Text;

            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um fornecedor antes de salvar.");
                return;
            }
            string idFornecedor = comboBox1.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection(Conexao.conexao))
            {
                conn.Open();

                string sql = "INSERT INTO Produto (Nome_produto, Quantidade_produto, Preco_produto, Descricao_produto, ID_Fornecedor) " +
                             "VALUES (@nome, @quantidade, @preco, @descricao, @idFornecedor)";

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

            MessageBox.Show("Produto cadastrado!");
            ExibirProximoID();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto CadastroP = new CadastroProduto();
            CadastroP.Show();
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
            CadastrarColaborador CadastroC = new CadastrarColaborador();
            CadastroC.Show();
        }

        private void editarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarColaborador EditarC = new EditarColaborador();
            EditarC.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}