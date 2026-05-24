using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Software_Farmacia
{
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
            ExibirProximoID();
        }

        private void ExibirProximoID()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexao.conexao))
                {
                    conn.Open();
                    string sql = "SELECT IDENT_CURRENT('Fornecedor') + IDENT_INCR('Fornecedor')";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeFornecedor = textBox1.Text;
            string cpfFornecedor = textBox2.Text;
            string senha = textBox3.Text;
            string email = textBox4.Text;

            using (SqlConnection conn = new SqlConnection(Conexao.conexao))
            {
                conn.Open();

                string sql = "INSERT INTO Fornecedor (Nome_fornecedor, CPF_fornecedor, Senha_fornecedor, Email_fornecedor) " +
                             "VALUES (@nome, @cpf, @senha, @email)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nomeFornecedor);
                    cmd.Parameters.AddWithValue("@cpf", cpfFornecedor);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("FORNECEDOR CADASTRADO COM SUCESSO!\n\n" +
                            "Nome: " + nomeFornecedor + "\n" +
                            "CPF: " + cpfFornecedor + "\n" +
                            "Email: " + email);

            ExibirProximoID();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
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
    }
}