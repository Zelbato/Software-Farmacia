using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Software_Farmacia
{
    public partial class CadastrarColaborador : Form
    {
        public CadastrarColaborador()
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
                    string sql = "SELECT IDENT_CURRENT('Colaborador') + IDENT_INCR('Colaborador')";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        object resultado = cmd.ExecuteScalar();
                        if (resultado != DBNull.Value && resultado != null)
                        {
                            int proximoId = Convert.ToInt32(resultado);
                            label8.Text = $"ID: {proximoId:D2}";
                        }
                    }
                }
            }
            catch
            {
                label8.Text = "ID: --";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeColaborador = textBox1.Text;
            string cpf = textBox2.Text;
            string senha = textBox3.Text;
            string email = textBox4.Text;
            string cargo = textBox5.Text;

            if (!float.TryParse(textBox6.Text, out float salario))
            {
                salario = 0;
            }

            using (SqlConnection conn = new SqlConnection(Conexao.conexao))
            {
                conn.Open();

                string sql = "INSERT INTO Colaborador (Nome_colaborador, CPF_colaborador, Senha_colaborador, " +
                             "Email_colaborador, Cargo_colaborador, Salario_colaborador) " +
                             "VALUES (@nome, @cpf, @senha, @email, @cargo, @salario)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nomeColaborador);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@cargo", cargo);
                    cmd.Parameters.AddWithValue("@salario", salario);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("COLABORADOR CADASTRADO COM SUCESSO!\n\n" +
                            "Nome: " + nomeColaborador + "\n" +
                            "CPF: " + cpf + "\n" +
                            "Cargo: " + cargo);

            ExibirProximoID();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
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
            CadastrarColaborador CadastrarC = new CadastrarColaborador();
            CadastrarC.Show();
        }

        private void editarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarColaborador EditarC = new EditarColaborador();
            EditarC.Show();
        }
    }
}