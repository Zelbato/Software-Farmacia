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

        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void lblJaTemConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
             LoginForm login = new LoginForm();
             login.Show();
            

            MessageBox.Show("Voltando para a tela de Login...");
        }
    }
}
