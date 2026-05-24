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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            int quantidade = int.Parse(textBox2.Text);
            float preco = float.Parse(textBox3.Text);
            string descricao = textBox4.Text;

            SqlConnection conn =
            new SqlConnection(Conexao.conexao);

            conn.Open();

            string sql =
            "INSERT INTO Produto " +
            "(Nome_produto, Quantidade_produto, Preco_produto, Descricao_produto) " +
            "VALUES " +
            "(@nome, @quantidade, @preco, @descricao)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@descricao", descricao);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Produto cadastrado!");
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
