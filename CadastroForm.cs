using System;
using System.Windows.Forms;

namespace Software_Farmacia
{
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }

        // Ação do Botão Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Link para voltar para a tela de Login
        private void lblJaTemConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Aqui você esconde essa tela e mostra o Login
            // Exemplo:
            // this.Hide();
            // LoginForm login = new LoginForm();
            // login.Show();
            MessageBox.Show("Voltando para a tela de Login...");
        }
    }
}