using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
    }
}
