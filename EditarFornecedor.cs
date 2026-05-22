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
    public partial class EditarFornecedor : Form
    {
        public EditarFornecedor()
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
            string id = textBox5.Text;
            string nomeFornecedor = textBox1.Text;
            string cpfFornecedor = textBox2.Text;
            string senha = textBox3.Text;
            string email = textBox4.Text;

            SqlConnection conn =
            new SqlConnection(Conexao.conexao);

            conn.Open();

            string sql =
            "UPDATE Fornecedor SET " +
            "Nome_fornecedor = @nome, " +
            "CPF_fornecedor = @cpf, " +
            "Senha_fornecedor = @senha, " +
            "Email_fornecedor = @email " +
            "WHERE Id_fornecedor = @id";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nome", nomeFornecedor);
            cmd.Parameters.AddWithValue("@cpf", cpfFornecedor);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@email", email);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show(
                "DADOS DO FORNECEDOR ALTERADOS!\n\n" +
                "ID: " + id + "\n" +
                "Nome: " + nomeFornecedor + "\n" +
                "CPF: " + cpfFornecedor
                    );
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
