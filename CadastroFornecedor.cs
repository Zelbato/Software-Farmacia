using Microsoft.Data.SqlClient;
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
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();

            panel2.BackColor = Color.Red;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 18, FontStyle.Bold);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeFornecedor = textBox1.Text;
            string cpfFornecedor = textBox2.Text;
            string senha = textBox3.Text;
            string email = textBox4.Text;

            SqlConnection conn =
            new SqlConnection(Conexao.conexao);

            conn.Open();

            string sql =
            "INSERT INTO Fornecedor " +
            "(Nome_fornecedor, CPF_fornecedor, Senha_fornecedor, Email_fornecedor) " +
            "VALUES " +
            "(@nome, @cpf, @senha, @email)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", nomeFornecedor);
            cmd.Parameters.AddWithValue("@cpf", cpfFornecedor);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@email", email);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show(
                "FORNECEDOR CADASTRADO COM SUCESSO!\n\n" +
                "Nome: " + nomeFornecedor + "\n" +
                "CPF: " + cpfFornecedor + "\n" +
                "Email: " + email
                    );
        }
    }
}
