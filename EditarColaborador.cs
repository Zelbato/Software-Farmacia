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
    public partial class EditarColaborador : Form
    {
        public EditarColaborador()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox7.Text;
            string nomeFuncionario = textBox1.Text;
            string cpf = textBox2.Text;
            string senha = textBox3.Text;
            string email = textBox4.Text;
            string cargo = textBox5.Text;
            string salario = textBox6.Text;

            SqlConnection conn =
            new SqlConnection(Conexao.conexao);

            conn.Open();

            string sql =
            "UPDATE Funcionario SET " +
            "Nome_funcionario = @nome, " +
            "CPF_funcionario = @cpf, " +
            "Senha_funcionario = @senha, " +
            "Email_funcionario = @email, " +
            "Cargo_funcionario = @cargo, " +
            "Salario_funcionario = @salario " +
            "WHERE Id_funcionario = @id";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nome", nomeFuncionario);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@cargo", cargo);
            cmd.Parameters.AddWithValue("@salario", salario);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show(
                "FUNCIONÁRIO EDITADO COM SUCESSO!\n\n" +
                "ID: " + id + "\n" +
                "Nome: " + nomeFuncionario
                    );
        }
    }
}
