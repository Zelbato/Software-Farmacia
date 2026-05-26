using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Software_Farmacia
{
    public partial class EditarColaborador : Form
    {
        public EditarColaborador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string id = textBox7.Text;
            string nomeFuncionario = textBox1.Text;
            string cpf = textBox2.Text;
            string senha = textBox3.Text;
            string email = textBox4.Text;
            string cargo = textBox5.Text;
            string salario = textBox6.Text;

            using (SqlConnection conn = new SqlConnection(Conexao.conexao))
            {
                conn.Open();

                string sql = "UPDATE Funcionario SET " +
                             "Nome_funcionario = @nome, " +
                             "CPF_funcionario = @cpf, " +
                             "Senha_funcionario = @senha, " +
                             "Email_funcionario = @email, " +
                             "Cargo_funcionario = @cargo, " +
                             "Salario_funcionario = @salario " +
                             "WHERE Id_funcionario = @id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", nomeFuncionario);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@cargo", cargo);
                    cmd.Parameters.AddWithValue("@salario", salario);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("FUNCIONÁRIO EDITADO COM SUCESSO!\n\n" +
                            //"ID: " + id + "\n" +
                            "Nome: " + nomeFuncionario);
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
            CadastroFornecedor CadastraoF = new CadastroFornecedor();
            CadastraoF.Show();
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

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}