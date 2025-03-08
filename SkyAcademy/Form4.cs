using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyAcademy
{
    public partial class Form4 : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter adaptador;
        DataTable tabela;
        string sql;
        string conexaoString = "Server=localhost; Port=3306; Database=db_skyacademy; Uid=root; Pwd='';";

        public Form4()
        {
            InitializeComponent();
        }

        private void CarregarAlunos()
        {
            try
            {
                // Conectar ao banco de dados
                conexao = new MySqlConnection(conexaoString);
                conexao.Open();

                // Consulta para trazer os dados do estoque
                sql = "SELECT matricula, nome_completo, data_nascimento, cpf, endereco, telefone, email, turma, data_matricula FROM alunos";
                comando = new MySqlCommand(sql, conexao);

                // Preencher o DataGridView
                adaptador = new MySqlDataAdapter(comando);
                tabela = new DataTable();
                adaptador.Fill(tabela);

                // Exibir os dados no DataGridView
                dataGridView1.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o painel dos alunos: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Chama o método para carregar o estoque
            CarregarAlunos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            
            Form2 form2 = new Form2();

            
            form2.Show();
        }
    }
}
