using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            CarregarDados(); // Chama o método ao iniciar o formulário
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Estabelece a conexão com o banco de dados
                conexao = new MySqlConnection("Server=localhost; Port=3306; Database=db_skyacademy; Uid=root; Pwd='';");

                // SQL de inserção no banco
                sql = "INSERT INTO produtos (ProdutoID, Nome, Descricao, Preco, Quantidade) VALUES (@ProdutoID, @Nome, @Descricao, @Preco, @Quantidade)";

                // Inicializa o comando com a conexão e o SQL
                comando = new MySqlCommand(sql, conexao);

                // Adiciona os parâmetros para a consulta
                comando.Parameters.AddWithValue("@ProdutoID", textCodigo.Text);
                comando.Parameters.AddWithValue("@Nome", textNome.Text);
                comando.Parameters.AddWithValue("@Descricao", textDescricao.Text);
                comando.Parameters.AddWithValue("@Preco", textPreco.Text);
                comando.Parameters.AddWithValue("@Quantidade", textQuantidade.Text);

                // Abre a conexão e executa o comando
                conexao.Open();
                comando.ExecuteNonQuery();

                CarregarDados(); // Atualiza os dados na tela automaticamente
            }
            catch (Exception ex)
            {
                // Exibe a mensagem de erro, caso ocorra algum problema
                MessageBox.Show("Erro ao realizar o cadastro: " + ex.Message);
            }
            finally
            {
                // Garante que a conexão seja fechada corretamente
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }

                // Limpa as variáveis e campos de texto
                conexao = null;
                comando = null;
                textNome.Clear();
                textDescricao.Clear();
                textPreco.Clear();
                textQuantidade.Clear();

                // Foca no campo de Nome para o próximo cadastro
                this.textNome.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost; Port=3306; Database=db_skyacademy; Uid=root; Pwd='';");

                sql = "UPDATE Produtos SET Nome = @Nome, Descricao = @Descricao, Preco = @Preco, Quantidade = @Quantidade WHERE ProdutoID = @ProdutoID";

                comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@Nome", textNome.Text);
                comando.Parameters.AddWithValue("@Descricao", textDescricao.Text);
                comando.Parameters.AddWithValue("@Preco", textPreco.Text);
                comando.Parameters.AddWithValue("@Quantidade", textQuantidade.Text);
                comando.Parameters.AddWithValue("@ProdutoID", textCodigo.Text); // Adicionado

                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro atualizado com sucesso!");

                CarregarDados(); // Atualiza os dados na tela automaticamente
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar o cadastro: " + ex.Message);
            }
            finally
            {
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }

                conexao = null;
                comando = null;
                textNome.Clear();
                textDescricao.Clear();
                textPreco.Clear();
                textQuantidade.Clear();
                textCodigo.Clear(); // Adicionado para limpar o campo ProdutoID também

                this.textNome.Focus();

              
            }

            
        }



        private void CarregarDados()
        {
            try
            {
                // Conectar ao banco de dados
                conexao = new MySqlConnection("Server=localhost; Port=3306; Database=db_skyacademy; Uid=root; Pwd='';");
                conexao.Open();

                // Consulta SQL para selecionar os dados da tabela CLIENT
                string sql = "SELECT * FROM produtos";
                comando = new MySqlCommand(sql, conexao);

                // Adaptador para preencher o DataGridView
                adaptador = new MySqlDataAdapter(comando);
                tabela = new DataTable();
                adaptador.Fill(tabela);

                // Exibir os dados no DataGridView
                
                dataGridView1.DataSource = tabela; // Atualiza a DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexao != null && conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Caso precise adicionar alguma funcionalidade ao clicar em uma célula do DataGridView
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar se o campo ProdutoID está preenchido e contém apenas números
                if (string.IsNullOrEmpty(textCodigo.Text) || !int.TryParse(textCodigo.Text, out int produtoID))
                {
                    MessageBox.Show("Por favor, informe um código de produto válido para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar com o usuário antes de excluir
                var resultado = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return; // Se o usuário escolher "Não", cancela a exclusão
                }

                // Estabelece a conexão com o banco de dados
                using (MySqlConnection conexao = new MySqlConnection("Server=localhost; Port=3306; Database=db_skyacademy; Uid=root; Pwd='';"))
                {
                    conexao.Open();

                    // SQL para excluir o produto com base no ProdutoID
                    string sql = "DELETE FROM produtos WHERE ProdutoID = @ProdutoID";

                    // Inicializa o comando com a conexão e o SQL
                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        // Adiciona o parâmetro ProdutoID
                        comando.Parameters.AddWithValue("@ProdutoID", produtoID);

                        // Executa o comando e verifica se algum registro foi excluído
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Aluno removido com sucesso!","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhum aluno encontrado com esse código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                // Atualiza os dados na tela automaticamente após a exclusão
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o aluno:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Limpa os campos de texto após a exclusão
                textNome.Clear();
                textDescricao.Clear();
                textPreco.Clear();
                textQuantidade.Clear();
                textCodigo.Clear();

                // Foca novamente no campo de código do produto
                this.textCodigo.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            
            Form2 form2 = new Form2();

            
            form2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}





    