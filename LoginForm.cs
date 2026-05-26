using System;
using System.Windows.Forms;

namespace Software_Farmacia
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard Dash = new Dashboard();
            Dash.Show();
        }
    }
}