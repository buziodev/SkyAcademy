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
    public partial class Form2: Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string sql;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textPassword.Text == "" || textEmail.Text == "")
            {
                MessageBox.Show("Preencha todos os campos corretamente");
                textEmail.Focus();
                return;
            }
            try
            {
                conexao = new MySqlConnection("Server=localhost; Port=3306; Database=db_skyacademy; Uid=root; Pwd='';");
                conexao.Open();

                // Verificar se o e-mail e a senha estão corretos
                sql = "SELECT COUNT(*) FROM CADASTRO WHERE email = @EMAIL AND senha = @SENHA";
                comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@EMAIL", textEmail.Text);
                comando.Parameters.AddWithValue("@SENHA", textPassword.Text);

                int count = Convert.ToInt32(comando.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Login realizado com sucesso!");

                    // Abre o próximo formulário
                    Form3 form3 = new Form3();
                    form3.Show();

                    // Fecha o formulário atual
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("E-mail ou senha incorretos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar o login: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }

                // Limpa campos
                textPassword.Text = string.Empty;
                textEmail.Text = string.Empty;
                textEmail.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Alterna entre texto visível e oculto no campo de senha.
            if (checkBox1.Checked)
            {
                textPassword.UseSystemPasswordChar = true; // Oculta a senha
            }
            else
            {
                
                textPassword.UseSystemPasswordChar = false; // Mostra a senha
            }
        }


        private void VoltarBtn(object sender, EventArgs e)
        {
            
            this.Hide();

            
            Form1 form1 = new Form1();

           
            form1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}