using System;
using System.Data;
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

        private void Form1_Load(object sender, EventArgs e) { }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNome.Text) || string.IsNullOrEmpty(textPassword.Text) || string.IsNullOrEmpty(textEmail.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conexao = new MySqlConnection(
                    "Server=localhost; Port=3306; Database=db_skyacademy;  Pwd=;"
                );

                sql = "INSERT INTO CADASTRO (nome, email, senha) VALUES (@NOME, @EMAIL, @SENHA)";
                comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@NOME", textNome.Text);
                comando.Parameters.AddWithValue("@EMAIL", textEmail.Text);
                comando.Parameters.AddWithValue("@SENHA", textPassword.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                new Form2().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexao != null && conexao.State == ConnectionState.Open)
                    conexao.Close();

                textNome.Clear();
                textPassword.Clear();
                textEmail.Clear();
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
