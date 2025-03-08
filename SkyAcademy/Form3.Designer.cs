namespace SkyAcademy
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.dateNascimento = new System.Windows.Forms.DateTimePicker();
            this.textCPF = new System.Windows.Forms.MaskedTextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textTurma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Endereço:";
            // 
            // textNome
            // 
            this.textNome.BackColor = System.Drawing.Color.AliceBlue;
            this.textNome.Location = new System.Drawing.Point(82, 180);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(250, 32);
            this.textNome.TabIndex = 5;
            // 
            // dateNascimento
            // 
            this.dateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNascimento.Location = new System.Drawing.Point(79, 234);
            this.dateNascimento.Name = "dateNascimento";
            this.dateNascimento.Size = new System.Drawing.Size(150, 32);
            this.dateNascimento.TabIndex = 6;
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(82, 279);
            this.textCPF.Mask = "000.000.000-00";
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(150, 32);
            this.textCPF.TabIndex = 7;
            // 
            // textEndereco
            // 
            this.textEndereco.BackColor = System.Drawing.Color.AliceBlue;
            this.textEndereco.Location = new System.Drawing.Point(82, 332);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(250, 32);
            this.textEndereco.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(395, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Location = new System.Drawing.Point(499, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "ATUALIZAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Location = new System.Drawing.Point(395, 487);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 37);
            this.button3.TabIndex = 17;
            this.button3.Text = "EXCLUIR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textMatricula
            // 
            this.textMatricula.BackColor = System.Drawing.Color.AliceBlue;
            this.textMatricula.Location = new System.Drawing.Point(458, 397);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(100, 32);
            this.textMatricula.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Matrícula:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(625, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 557);
            this.dataGridView1.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "← Voltar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SkyAcademy.Properties.Resources.AzulSemFundo;
            this.pictureBox2.Location = new System.Drawing.Point(72, -73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 236);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(82, 384);
            this.textTelefone.Mask = "(00) 00000-0000";
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(150, 32);
            this.textTelefone.TabIndex = 9;
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.textEmail.Location = new System.Drawing.Point(82, 429);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(250, 32);
            this.textEmail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefone:";
            // 
            // textTurma
            // 
            this.textTurma.BackColor = System.Drawing.Color.AliceBlue;
            this.textTurma.Location = new System.Drawing.Point(82, 474);
            this.textTurma.Name = "textTurma";
            this.textTurma.Size = new System.Drawing.Size(100, 32);
            this.textTurma.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "E-mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Turma:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textMatricula);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textTurma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.dateNascimento);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Gestão de Alunos - Sky Academy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.DateTimePicker dateNascimento;
        private System.Windows.Forms.MaskedTextBox textCPF;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox textTelefone;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTurma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}