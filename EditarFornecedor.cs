using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Software_Farmacia
{
    public partial class EditarFornecedor : Form
    {
        public EditarFornecedor()
        {
            InitializeComponent();

            button2.Click += button2_Click;
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

                string sql = "UPDATE Fornecedor SET " +
                             "Nome_fornecedor = @nome, " +
                             "CPF_fornecedor = @cpf, " +
                             "Senha_fornecedor = @senha, " +
                             "Email_fornecedor = @email " +
                             "WHERE Id_fornecedor = @id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {

                    cmd.Parameters.AddWithValue("@nome", nomeFornecedor);
                    cmd.Parameters.AddWithValue("@cpf", cpfFornecedor);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("DADOS DO FORNECEDOR ALTERADOS!\n\n" +

                            "Nome: " + nomeFornecedor + "\n" +
                            "CPF: " + cpfFornecedor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

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

        private void panelCardForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
