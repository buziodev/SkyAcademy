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
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string sql;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textNome.Text == "" || textPassword.Text == "" || textEmail.Text == "")
            {
                MessageBox.Show("Preencha todos os campos corretamente");
                textNome.Focus();
                return;
            }



            try
            {
                // Estabelece a conexão com o banco de dados
                conexao = new MySqlConnection("Server=localhost; Port=3306; Database=db_skyacademyt; Pwd='';");

                // SQL de inserção no banco
                sql = "INSERT INTO CADASTRO (nome, email, senha) VALUES (@NOME, @EMAIL, @SENHA)";
                comando = new MySqlCommand(sql, conexao);

                // Adiciona os parâmetros para a consulta
                comando.Parameters.AddWithValue("@NOME", textNome.Text);
                comando.Parameters.AddWithValue("@EMAIL", textEmail.Text);
                comando.Parameters.AddWithValue("@SENHA", textPassword.Text);

                // Abre a conexão e executa o comando
                conexao.Open();
                comando.ExecuteNonQuery();

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Seu registro foi um sucesso.");

                // Fecha o formulário atual
                this.Hide();

                // Cria uma nova instância do Form2
                Form2 form2 = new Form2();

                // Exibe o novo formulário
                form2.Show();
            }
            catch (Exception ex)
            {
                // Exibe a mensagem de erro, caso ocorra algum problema
                MessageBox.Show("Erro ao registrar." + ex.Message);
            }
            finally
            {
                // Garante que a conexão seja fechada corretamente
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }

                // Limpa as variáveis e campos de texto
                conexao = null;
                comando = null;
                textNome.Text = null;
                textPassword.Text = null;
                textEmail.Text = null;

                // Foca no campo de Nome para o próximo cadastro
                this.textNome.Focus();
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();


            Form2 form2 = new Form2();


            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
