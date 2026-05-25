using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Software_Farmacia
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();

            panel2.BackColor = Color.Red;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 18, FontStyle.Bold);
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
            string nome = textBox1.Text;
            string quantidade = textBox2.Text;
            string preco = textBox3.Text;
            string descricao = textBox4.Text;

            MessageBox.Show(
                "Produto foi cadastrado com sucesso!\n\n" +
                "Nome: " + nome + "\n" +
                "Quantidade: " + quantidade + "\n" +
                "Preço: " + preco + "\n" +
                "Descrição: " + descricao
            );
        }

        private void editarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
