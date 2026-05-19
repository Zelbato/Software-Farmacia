using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Software_Farmacia
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            Panel sideMenu = new Panel();
            sideMenu.Width = 200;
            sideMenu.Dock = DockStyle.Left;
            sideMenu.BackColor = Color.FromArgb(177, 1, 10);
            this.Controls.Add(sideMenu);

            Button btnDashboard = new Button();
            btnDashboard.Text = "Dashboard";
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.Height = 50;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            sideMenu.Controls.Add(btnDashboard);

            Panel mainPanel = new Panel();
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.BackColor = Color.White;
            this.Controls.Add(mainPanel);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }
    }
}
