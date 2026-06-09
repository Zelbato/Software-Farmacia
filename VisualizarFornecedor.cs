using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Software_Farmacia
{
    public partial class VisualizarFornecedor : Form
    {
        private List<FornecedorDados> todosFornecedores = new List<FornecedorDados>();

        public VisualizarFornecedor()
        {
            InitializeComponent();
            GerarDadosIniciais();
            AtualizarTabela(todosFornecedores);
        }

        private void GerarDadosIniciais()
        {
            string sql = "SELECT Id_fornecedor, Nome_fornecedor, CPF_fornecedor, Email_fornecedor FROM Fornecedor";

            using (SqlConnection conn = new SqlConnection(Conexao.conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        todosFornecedores.Clear();

                        foreach (DataRow row in dt.Rows)
                        {

                            todosFornecedores.Add(new FornecedorDados(
                                row.Table.Columns.Contains("Id_fornecedor") ? row["Id_fornecedor"].ToString() : string.Empty,
                                row.Table.Columns.Contains("Nome_fornecedor") ? row["Nome_fornecedor"].ToString() : string.Empty,

                                row.Table.Columns.Contains("CPF_fornecedor") ? row["CPF_fornecedor"].ToString() : (row.Table.Columns.Contains("Cpf_fornecedor") ? row["Cpf_fornecedor"].ToString() : string.Empty),
                                row.Table.Columns.Contains("Email_fornecedor") ? row["Email_fornecedor"].ToString() : string.Empty
                            ));
                        }
                    }
                }
            }
        }

        private void AtualizarTabela(List<FornecedorDados> lista)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            foreach (var f in lista)
            {

                dataGridView1.Rows.Add(f.Id, f.Nome, f.CPF, f.Email);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string termo = textBox1.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(termo))
            {
                AtualizarTabela(todosFornecedores);
                return;
            }

            var resultados = new List<FornecedorDados>();
            foreach (var f in todosFornecedores)
            {
                if ((f.Nome ?? string.Empty).ToLower().Contains(termo) ||
                    (f.CPF ?? string.Empty).ToLower().Contains(termo) ||
                    (f.Email ?? string.Empty).ToLower().Contains(termo) ||
                    (f.Id ?? string.Empty).ToLower().Contains(termo))
                {
                    resultados.Add(f);
                }
            }

            AtualizarTabela(resultados);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
            string nome = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();

            if (colName == "btnEditar")
            {
                using (var editar = new EditarFornecedor())
                {
                    var txtNome = editar.Controls.Find("textBox1", true);
                    if (txtNome.Length > 0) ((TextBox)txtNome[0]).Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? string.Empty;
                    var txtCpf = editar.Controls.Find("textBox2", true);
                    if (txtCpf.Length > 0) ((TextBox)txtCpf[0]).Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? string.Empty;
                    var txtEmail = editar.Controls.Find("textBox4", true);
                    if (txtEmail.Length > 0) ((TextBox)txtEmail[0]).Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? string.Empty;

                    editar.ShowDialog();
                }

                GerarDadosIniciais();
                AtualizarTabela(todosFornecedores);
            }
            else if (colName == "btnVisualizar")
            {
                using (var editar = new EditarFornecedor())
                {
                    var txtNome = editar.Controls.Find("textBox1", true);
                    if (txtNome.Length > 0) ((TextBox)txtNome[0]).Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? string.Empty;
                    var txtCpf = editar.Controls.Find("textBox2", true);
                    if (txtCpf.Length > 0) ((TextBox)txtCpf[0]).Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? string.Empty;
                    var txtEmail = editar.Controls.Find("textBox4", true);
                    if (txtEmail.Length > 0) ((TextBox)txtEmail[0]).Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? string.Empty;

                    var btnSalvar = editar.Controls.Find("button1", true);
                    if (btnSalvar.Length > 0) ((Button)btnSalvar[0]).Enabled = false;

                    foreach (Control c in editar.Controls)
                    {
                        if (c is TextBox) c.Enabled = false;
                        if (c is ComboBox) c.Enabled = false;
                    }

                    editar.ShowDialog();
                }
            }
            else if (colName == "btnDeletar")
            {
                DialogResult res = MessageBox.Show($"Tem certeza que deseja excluir o fornecedor: {nome}?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(Conexao.conexao))
                        {
                            conn.Open();
                            using (SqlCommand cmd = conn.CreateCommand())
                            {
                                cmd.CommandText = "DELETE FROM Fornecedor WHERE Id_fornecedor = @id";
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    catch { }

                    todosFornecedores.RemoveAll(f => f.Id == id);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Fornecedor excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroFornecedor cadastro = new CadastroFornecedor(); cadastro.Show();
            this.Hide();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(); dashboard.Show();
            this.Hide();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto CadastroP = new CadastroProduto(); CadastroP.Show();
            this.Hide();
        }

        private void editarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarProduto editar = new EditarProduto();
            editar.Show();
            this.Hide();
        }

        private void visualizarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarProduto visualizar = new VisualizarProduto();
            visualizar.Show();
            this.Hide();
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedor cadastro = new CadastroFornecedor();
            cadastro.Show();
            this.Hide();
        }

        private void editarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarFornecedor editar = new EditarFornecedor();
            editar.Show();
            this.Hide();
        }

        private void visualizarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarFornecedor vis = new VisualizarFornecedor();
            vis.Show();
            this.Hide();
        }

        private void visualizarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarEstoque vis = new VisualizarEstoque();
            vis.Show();
            this.Hide();
        }

        private void cadastrarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarColaborador CadastrarC = new CadastrarColaborador(); CadastrarC.Show();
            this.Hide();
        }

        private void editarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarColaborador EditarC = new EditarColaborador(); EditarC.Show();
            this.Hide();
        }

        private void panelCardForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class FornecedorDados
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        public FornecedorDados(string id, string nome, string cpf, string email)
        {
            Id = id; Nome = nome; CPF = cpf; Email = email;
        }
    }
}

