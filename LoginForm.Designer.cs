using System.Windows.Forms;
using System.Drawing;

namespace Software_Farmacia
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelLeft;
        private Label lblTitulo;
        private Label lblSub;
        private Panel panelRight;
        private Button btnFechar;
        private Label lblLogin;
        private Label lblUsuarioHint;
        private TextBox txtEmail;
        private Label lblSenhaHint;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Button btnCriarConta;
        private Label label1;
        private TextBox textBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelLeft = new Panel();
            lblTitulo = new Label();
            lblSub = new Label();
            panelRight = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            btnFechar = new Button();
            lblLogin = new Label();
            lblUsuarioHint = new Label();
            txtEmail = new TextBox();
            lblSenhaHint = new Label();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            btnCriarConta = new Button();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(218, 41, 28);
            panelLeft.Controls.Add(lblTitulo);
            panelLeft.Controls.Add(lblSub);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(389, 733);
            panelLeft.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(14, 260);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(360, 80);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "FARMÁCIA";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSub
            // 
            lblSub.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSub.ForeColor = Color.FromArgb(255, 210, 210);
            lblSub.Location = new Point(14, 347);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(360, 53);
            lblSub.TabIndex = 1;
            lblSub.Text = "Sistema profissional moderno";
            lblSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(textBox1);
            panelRight.Controls.Add(label1);
            panelRight.Controls.Add(btnFechar);
            panelRight.Controls.Add(lblLogin);
            panelRight.Controls.Add(lblUsuarioHint);
            panelRight.Controls.Add(txtEmail);
            panelRight.Controls.Add(lblSenhaHint);
            panelRight.Controls.Add(txtSenha);
            panelRight.Controls.Add(btnEntrar);
            panelRight.Controls.Add(btnCriarConta);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(389, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(582, 733);
            panelRight.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12.5F);
            textBox1.Location = new Point(74, 205);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(434, 35);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(74, 180);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // btnFechar
            // 
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnFechar.ForeColor = Color.DarkGray;
            btnFechar.Location = new Point(531, 11);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(40, 47);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "✕";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            lblLogin.ForeColor = Color.FromArgb(64, 64, 64);
            lblLogin.Location = new Point(69, 87);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(206, 50);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Fazer login";
            // 
            // lblUsuarioHint
            // 
            lblUsuarioHint.AutoSize = true;
            lblUsuarioHint.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblUsuarioHint.ForeColor = Color.Gray;
            lblUsuarioHint.Location = new Point(74, 258);
            lblUsuarioHint.Name = "lblUsuarioHint";
            lblUsuarioHint.Size = new Size(54, 21);
            lblUsuarioHint.TabIndex = 4;
            lblUsuarioHint.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12.5F);
            txtEmail.Location = new Point(74, 283);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(434, 35);
            txtEmail.TabIndex = 5;
            // 
            // lblSenhaHint
            // 
            lblSenhaHint.AutoSize = true;
            lblSenhaHint.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblSenhaHint.ForeColor = Color.Gray;
            lblSenhaHint.Location = new Point(74, 322);
            lblSenhaHint.Name = "lblSenhaHint";
            lblSenhaHint.Size = new Size(54, 21);
            lblSenhaHint.TabIndex = 6;
            lblSenhaHint.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12.5F);
            txtSenha.Location = new Point(74, 347);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.Size = new Size(434, 35);
            txtSenha.TabIndex = 7;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(218, 41, 28);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(69, 444);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(434, 61);
            btnEntrar.TabIndex = 8;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCriarConta
            // 
            btnCriarConta.BackColor = Color.White;
            btnCriarConta.Cursor = Cursors.Hand;
            btnCriarConta.FlatAppearance.BorderColor = Color.Silver;
            btnCriarConta.FlatStyle = FlatStyle.Flat;
            btnCriarConta.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCriarConta.ForeColor = Color.Gray;
            btnCriarConta.Location = new Point(69, 511);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(434, 56);
            btnCriarConta.TabIndex = 9;
            btnCriarConta.Text = "CRIAR UMA CONTA";
            btnCriarConta.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(971, 733);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Sistema de Farmácia";
            panelLeft.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}