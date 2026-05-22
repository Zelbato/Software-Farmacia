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
    public partial class CadastrarColaborador : Form
    {
        public CadastrarColaborador()
        {
            InitializeComponent();
        }

        private void CadastrarColaborador_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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
            "INSERT INTO Funcionario " +
            "(Nome_funcionario, CPF_funcionario, Senha_funcionario, " +
            "Email_funcionario, Cargo_funcionario, Salario_funcionario) " +
            "VALUES " +
            "(@nome, @cpf, @senha, @email, @cargo, @salario)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", nomeFuncionario);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@cargo", cargo);
            cmd.Parameters.AddWithValue("@salario", salario);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show(
                "FUNCIONÁRIO CADASTRADO COM SUCESSO!\n\n" +
                "Nome: " + nomeFuncionario + "\n" +
                "CPF: " + cpf + "\n" +
                "Cargo: " + cargo
                    );
        }
    }
}
