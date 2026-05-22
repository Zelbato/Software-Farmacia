using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;
namespace Software_Farmacia
{
    public partial class EditarProduto : Form
    {
        public EditarProduto()
        {
            InitializeComponent();

            panel2.BackColor = Color.Red;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 18, FontStyle.Bold);
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditarProduto_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox5.Text;
            string nome = textBox1.Text;
            string quantidade = textBox2.Text;
            string preco = textBox3.Text;
            string descricao = textBox4.Text;

            SqlConnection conn =
            new SqlConnection(Conexao.conexao);

            conn.Open();

            string sql =
            "UPDATE Produto SET " +
            "Nome_produto = @nome, " +
            "Quantidade_produto = @quantidade, " +
            "Preco_produto = @preco, " +
            "Descricao_produto = @descricao " +
            "WHERE Id_produto = @id";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@descricao", descricao);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show(
                "Produto alterado com sucesso!\n\n" +
                "ID: " + id + "\n" +
                "Nome: " + nome
                    );
        }
    }
}
