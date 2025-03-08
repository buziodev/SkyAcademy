using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SkyAcademy
{
    public partial class Form3 : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter adaptador;
        DataTable tabela;
        string sql;

        public Form3()
        {
            InitializeComponent();
            CarregarDados();
        }

        // CADASTRAR ALUNO
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNome.Text) || string.IsNullOrEmpty(textMatricula.Text))
            {
                MessageBox.Show("Preencha Nome e Matrícula!");
                return;
            }

            try
            {
                conexao = new MySqlConnection("Server=localhost; Port=3306; Database=db_skyacademy; Uid=root; Pwd='';");

                sql = @"INSERT INTO Alunos 
                        (matricula, nome_completo, data_nascimento, cpf, endereco, telefone, email, turma, data_matricula, situacao) 
                        VALUES 
                        (@Matricula, @Nome, @Nascimento, @CPF, @Endereco, @Telefone, @Email, @Turma, @DataMatricula, @Situacao)";

                comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Matricula", textMatricula.Text);
                comando.Parameters.AddWithValue("@Nome", textNome.Text);
                comando.Parameters.AddWithValue("@Nascimento", dateNascimento.Value.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@CPF", textCPF.Text);
                comando.Parameters.AddWithValue("@Endereco", textEndereco.Text);
                comando.Parameters.AddWithValue("@Telefone", textTelefone.Text);
                comando.Parameters.AddWithValue("@Email", textEmail.Text);
                comando.Parameters.AddWithValue("@Turma", textTurma.Text);
                comando.Parameters.AddWithValue("@DataMatricula", DateTime.Now.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@Situacao", "Ativo");

                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Aluno cadastrado!");
                CarregarDados();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                if (conexao != null && conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        // ATUALIZAR ALUNO
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textMatricula.Text))
            {
                MessageBox.Show("Informe a Matrícula!");
                return;
            }

            try
            {
                conexao = new MySqlConnection("Server=localhost; Port=3306; Database=db_skyacademy; Uid=root; Pwd='';");

                sql = @"UPDATE Alunos SET 
                        nome_completo = @Nome, 
                        data_nascimento = @Nascimento, 
                        cpf = @CPF, 
                        endereco = @Endereco, 
                        telefone = @Telefone, 
                        email = @Email, 
                        turma = @Turma 
                        WHERE matricula = @Matricula";

                comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Nome", textNome.Text);
                comando.Parameters.AddWithValue("@Nascimento", dateNascimento.Value.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@CPF", textCPF.Text);
                comando.Parameters.AddWithValue("@Endereco", textEndereco.Text);
                comando.Parameters.AddWithValue("@Telefone", textTelefone.Text);
                comando.Parameters.AddWithValue("@Email", textEmail.Text);
                comando.Parameters.AddWithValue("@Turma", textTurma.Text);
                comando.Parameters.AddWithValue("@Matricula", textMatricula.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados atualizados!");
                CarregarDados();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                if (conexao != null && conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        // EXCLUIR ALUNO
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textMatricula.Text))
            {
                MessageBox.Show("Informe a Matrícula!");
                return;
            }

            var confirm = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No) return;

            try
            {
                conexao = new MySqlConnection("Server=localhost; Port=3306; Database=db_skyacademy; Uid=root; Pwd='';");
                sql = "DELETE FROM Alunos WHERE matricula = @Matricula";

                comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Matricula", textMatricula.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Aluno excluído!");
                CarregarDados();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                if (conexao != null && conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        // CARREGAR DADOS
        private void CarregarDados()
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost; Port=3306; Database=db_skyacademy; Uid=root; Pwd='';");
                sql = "SELECT * FROM Alunos";
                comando = new MySqlCommand(sql, conexao);

                adaptador = new MySqlDataAdapter(comando);
                tabela = new DataTable();
                adaptador.Fill(tabela);

                dataGridView1.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // PREENCHER CAMPOS AO CLICAR NO DATAGRID
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textMatricula.Text = row.Cells["matricula"].Value.ToString();
                textNome.Text = row.Cells["nome_completo"].Value.ToString();
                dateNascimento.Value = Convert.ToDateTime(row.Cells["data_nascimento"].Value);
                textCPF.Text = row.Cells["cpf"].Value.ToString();
                textEndereco.Text = row.Cells["endereco"].Value.ToString();
                textTelefone.Text = row.Cells["telefone"].Value.ToString();
                textEmail.Text = row.Cells["email"].Value.ToString();
                textTurma.Text = row.Cells["turma"].Value.ToString();
            }
        }

        // VOLTAR AO MENU
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        // LIMPAR CAMPOS
        private void LimparCampos()
        {
            textMatricula.Clear();
            textNome.Clear();
            dateNascimento.Value = DateTime.Now;
            textCPF.Clear();
            textEndereco.Clear();
            textTelefone.Clear();
            textEmail.Clear();
            textTurma.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}