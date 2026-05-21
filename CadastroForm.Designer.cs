    using System.Windows.Forms;
    using System.Drawing;

    namespace Software_Farmacia
    {
        partial class CadastroForm
        {
            private System.ComponentModel.IContainer components = null;

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
            btnFechar = new Button();
            lblCadastro = new Label();
            lblNomeHint = new Label();
            txtNome = new TextBox();
            lblCPFHint = new Label();
            txtCPF = new TextBox();
            lblEmailHint = new Label();
            txtEmail = new TextBox();
            lblSenhaHint = new Label();
            txtSenha = new TextBox();
            btnCadastrar = new Button();
            lblJaTemConta = new LinkLabel();
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
            panelLeft.Size = new Size(352, 600);
            panelLeft.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(4, 225);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(348, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "FARMÁCIA";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSub
            // 
            lblSub.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSub.ForeColor = Color.FromArgb(255, 210, 210);
            lblSub.Location = new Point(12, 285);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(315, 40);
            lblSub.TabIndex = 1;
            lblSub.Text = "Crie sua conta em segundos";
            lblSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(btnFechar);
            panelRight.Controls.Add(lblCadastro);
            panelRight.Controls.Add(lblNomeHint);
            panelRight.Controls.Add(txtNome);
            panelRight.Controls.Add(lblCPFHint);
            panelRight.Controls.Add(txtCPF);
            panelRight.Controls.Add(lblEmailHint);
            panelRight.Controls.Add(txtEmail);
            panelRight.Controls.Add(lblSenhaHint);
            panelRight.Controls.Add(txtSenha);
            panelRight.Controls.Add(btnCadastrar);
            panelRight.Controls.Add(lblJaTemConta);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(352, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(498, 600);
            panelRight.TabIndex = 0;
            // 
            // btnFechar
            // 
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnFechar.ForeColor = Color.DarkGray;
            btnFechar.Location = new Point(465, 8);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(35, 35);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "✕";
            btnFechar.Click += btnFechar_Click;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            lblCadastro.ForeColor = Color.FromArgb(64, 64, 64);
            lblCadastro.Location = new Point(60, 40);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(205, 50);
            lblCadastro.TabIndex = 1;
            lblCadastro.Text = "Criar conta";
            // 
            // lblNomeHint
            // 
            lblNomeHint.AutoSize = true;
            lblNomeHint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNomeHint.ForeColor = Color.Gray;
            lblNomeHint.Location = new Point(65, 110);
            lblNomeHint.Name = "lblNomeHint";
            lblNomeHint.Size = new Size(121, 20);
            lblNomeHint.TabIndex = 2;
            lblNomeHint.Text = "Nome Completo";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(63, 130);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(380, 34);
            txtNome.TabIndex = 3;
            // 
            // lblCPFHint
            // 
            lblCPFHint.AutoSize = true;
            lblCPFHint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCPFHint.ForeColor = Color.Gray;
            lblCPFHint.Location = new Point(65, 175);
            lblCPFHint.Name = "lblCPFHint";
            lblCPFHint.Size = new Size(35, 20);
            lblCPFHint.TabIndex = 4;
            lblCPFHint.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Segoe UI", 12F);
            txtCPF.Location = new Point(63, 195);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(380, 34);
            txtCPF.TabIndex = 5;
            // 
            // lblEmailHint
            // 
            lblEmailHint.AutoSize = true;
            lblEmailHint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEmailHint.ForeColor = Color.Gray;
            lblEmailHint.Location = new Point(65, 240);
            lblEmailHint.Name = "lblEmailHint";
            lblEmailHint.Size = new Size(52, 20);
            lblEmailHint.TabIndex = 6;
            lblEmailHint.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(63, 260);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(380, 34);
            txtEmail.TabIndex = 7;
            // 
            // lblSenhaHint
            // 
            lblSenhaHint.AutoSize = true;
            lblSenhaHint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSenhaHint.ForeColor = Color.Gray;
            lblSenhaHint.Location = new Point(65, 305);
            lblSenhaHint.Name = "lblSenhaHint";
            lblSenhaHint.Size = new Size(132, 20);
            lblSenhaHint.TabIndex = 8;
            lblSenhaHint.Text = "Defina uma senha";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(63, 325);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.Size = new Size(380, 34);
            txtSenha.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(218, 41, 28);
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(63, 390);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(380, 46);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar Agora";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // lblJaTemConta
            // 
            lblJaTemConta.ActiveLinkColor = Color.FromArgb(218, 41, 28);
            lblJaTemConta.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblJaTemConta.LinkBehavior = LinkBehavior.NeverUnderline;
            lblJaTemConta.LinkColor = Color.FromArgb(0, 120, 215);
            lblJaTemConta.Location = new Point(63, 460);
            lblJaTemConta.Name = "lblJaTemConta";
            lblJaTemConta.Size = new Size(380, 23);
            lblJaTemConta.TabIndex = 11;
            lblJaTemConta.TabStop = true;
            lblJaTemConta.Text = "Já possui uma conta? Faça login";
            lblJaTemConta.TextAlign = ContentAlignment.MiddleCenter;
            lblJaTemConta.LinkClicked += lblJaTemConta_LinkClicked;
            // 
            // CadastroForm
            // 
            ClientSize = new Size(850, 600);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            panelLeft.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
            private System.Windows.Forms.Label lblTitulo;
            private System.Windows.Forms.Label lblSub;
            private System.Windows.Forms.Panel panelRight;
            private System.Windows.Forms.Button btnFechar;
            private System.Windows.Forms.Label lblCadastro;
            private System.Windows.Forms.Label lblNomeHint;
            private System.Windows.Forms.TextBox txtNome;
            private System.Windows.Forms.Label lblCPFHint;
            private System.Windows.Forms.TextBox txtCPF;
            private System.Windows.Forms.Label lblEmailHint;
            private System.Windows.Forms.TextBox txtEmail;
            private System.Windows.Forms.Label lblSenhaHint;
            private System.Windows.Forms.TextBox txtSenha;
            private System.Windows.Forms.Button btnCadastrar;
            private System.Windows.Forms.LinkLabel lblJaTemConta;
        }
    }