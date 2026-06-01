using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Software_Farmacia
{
    public partial class VisualizarColaborador : Form
    {
        private List<ColaboradorDados> todosColaboradores = new List<ColaboradorDados>();

        public VisualizarColaborador()
        {
            InitializeComponent();
            GerarDadosIniciais();
            AtualizarTabela(todosColaboradores);
        }

        private void VisualizarColaborador_Load(object sender, EventArgs e)
        {

        }

        private void GerarDadosIniciais()
        {
            string sql = "SELECT Id_colaborador, Nome_colaborador, CPF_colaborador, Cargo_colaborador, Salario_colaborador, Email_colaborador FROM Colaborador";

            using (SqlConnection conn = new SqlConnection(Conexao.conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        todosColaboradores.Clear();

                        foreach (DataRow row in dt.Rows)
                        {
                            todosColaboradores.Add(new ColaboradorDados(
                                row["Id_colaborador"].ToString(),
                                row["Nome_colaborador"].ToString(),
                                row["CPF_colaborador"].ToString(),
                                row["Cargo_colaborador"].ToString(),
                                row["Salario_colaborador"].ToString(),
                                row["Email_colaborador"].ToString()
                            ));
                        }
                    }
                }
            }
        }

        private void AtualizarTabela(List<ColaboradorDados> listaParaExibir)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            foreach (var c in listaParaExibir)
            {
                dataGridView1.Rows.Add(c.Id, c.Nome, c.CPF, c.Cargo, c.Salario, c.Email);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string termo = textBox1.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(termo))
            {
                AtualizarTabela(todosColaboradores);
                return;
            }

            var resultados = new List<ColaboradorDados>();
            foreach (var c in todosColaboradores)
            {
                if ((c.Nome ?? string.Empty).ToLower().Contains(termo) ||
                    (c.CPF ?? string.Empty).ToLower().Contains(termo) ||
                    (c.Cargo ?? string.Empty).ToLower().Contains(termo) ||
                    (c.Email ?? string.Empty).ToLower().Contains(termo) ||
                    (c.Salario ?? string.Empty).ToLower().Contains(termo) ||
                    (c.Id ?? string.Empty).ToLower().Contains(termo))
                {
                    resultados.Add(c);
                }
            }

            AtualizarTabela(resultados);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nomeColuna = dataGridView1.Columns[e.ColumnIndex].Name;

            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
            string nome = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();

            if (nomeColuna == "btnEditar")
            {
                int idInt = 0; int.TryParse(id, out idInt);
                using (var editar = new EditarColaborador())
                {
                    // tenta preencher campos do form Editar caso existam
                    var txts = editar.Controls.Find("textBox1", true);
                    if (txts.Length > 0) ((TextBox)txts[0]).Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? string.Empty;
                    var txtCpf = editar.Controls.Find("textBox2", true);
                    if (txtCpf.Length > 0) ((TextBox)txtCpf[0]).Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? string.Empty;
                    var txtCargo = editar.Controls.Find("textBox5", true);
                    if (txtCargo.Length > 0) ((TextBox)txtCargo[0]).Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? string.Empty;
                    var txtSal = editar.Controls.Find("textBox6", true);
                    if (txtSal.Length > 0) ((TextBox)txtSal[0]).Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? string.Empty;
                    var txtEmail = editar.Controls.Find("textBox4", true);
                    if (txtEmail.Length > 0) ((TextBox)txtEmail[0]).Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? string.Empty;

                    editar.ShowDialog();
                }

                // Recarregar
                GerarDadosIniciais();
                AtualizarTabela(todosColaboradores);
            }
            else if (nomeColuna == "btnVisualizar")
            {
                // Reusar Cadastrar/Editar não existe tela de visualizar, abrir Editar em modo apenas leitura
                using (var editar = new EditarColaborador())
                {
                    var txts = editar.Controls.Find("textBox1", true);
                    if (txts.Length > 0) ((TextBox)txts[0]).Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? string.Empty;
                    var txtCpf = editar.Controls.Find("textBox2", true);
                    if (txtCpf.Length > 0) ((TextBox)txtCpf[0]).Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? string.Empty;
                    var txtCargo = editar.Controls.Find("textBox5", true);
                    if (txtCargo.Length > 0) ((TextBox)txtCargo[0]).Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? string.Empty;
                    var txtSal = editar.Controls.Find("textBox6", true);
                    if (txtSal.Length > 0) ((TextBox)txtSal[0]).Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? string.Empty;
                    var txtEmail = editar.Controls.Find("textBox4", true);
                    if (txtEmail.Length > 0) ((TextBox)txtEmail[0]).Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? string.Empty;

                    // desabilitar botões e campos
                    var btnSalvar = editar.Controls.Find("button1", true);
                    if (btnSalvar.Length > 0) ((Button)btnSalvar[0]).Enabled = false;
                    editar.ShowDialog();
                }
            }
            else if (nomeColuna == "btnDeletar")
            {
                DialogResult resultado = MessageBox.Show($"Tem certeza que deseja excluir o colaborador: {nome}?",
                                                        "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // tenta remover do BD
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(Conexao.conexao))
                        {
                            conn.Open();
                            using (SqlCommand cmd = conn.CreateCommand())
                            {
                                cmd.CommandText = "DELETE FROM Colaborador WHERE Id_colaborador = @id";
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    catch
                    {
                        // ignorar
                    }

                    todosColaboradores.RemoveAll(x => x.Id == id);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Colaborador excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarColaborador tela = new CadastrarColaborador();
            tela.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(); dashboard.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto CadastroP = new CadastroProduto(); CadastroP.Show();
        }

        private void visualizarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarEstoque visualizar = new VisualizarEstoque();
            visualizar.Show();
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedor CadastroF = new CadastroFornecedor(); CadastroF.Show();
        }

        private void editarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarFornecedor EditarF = new EditarFornecedor(); EditarF.Show();
        }

        private void cadastrarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarColaborador CadastrarC = new CadastrarColaborador(); CadastrarC.Show();
        }

        private void editarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarColaborador EditarC = new EditarColaborador(); EditarC.Show();
        }

        private void visualizarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarColaborador VisualizarC = new VisualizarColaborador(); VisualizarC.Show();
        }
    }

    public class ColaboradorDados
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Cargo { get; set; }
        public string Salario { get; set; }
        public string Email { get; set; }

        public ColaboradorDados(string id, string nome, string cpf, string cargo, string salario, string email)
        {
            Id = id; Nome = nome; CPF = cpf; Cargo = cargo; Salario = salario; Email = email;
        }
    }
}
