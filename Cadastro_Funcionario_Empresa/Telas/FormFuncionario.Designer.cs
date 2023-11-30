﻿
namespace Venda_Bovina
{
    partial class FormFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionario));
            panelCabecalho = new Panel();
            button1 = new Button();
            label12 = new Label();
            btnFechar = new Button();
            btnRestaurar = new Button();
            btnMaximizar = new Button();
            panelMenu = new Panel();
            panelConteudo = new Panel();
            textBox1 = new TextBox();
            label11 = new Label();
            btnVendas = new Button();
            txt_funcao = new TextBox();
            txt_salario = new TextBox();
            txt_endereco = new TextBox();
            txt_email = new TextBox();
            txt_telefone = new TextBox();
            txt_estadoCivil = new TextBox();
            txt_dataNascimento = new TextBox();
            txt_rg = new TextBox();
            txt_cpf = new TextBox();
            txt_nome = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panelCabecalho.SuspendLayout();
            panelConteudo.SuspendLayout();
            SuspendLayout();
            // 
            // panelCabecalho
            // 
            panelCabecalho.BackColor = Color.Goldenrod;
            panelCabecalho.Controls.Add(button1);
            panelCabecalho.Controls.Add(label12);
            panelCabecalho.Controls.Add(btnFechar);
            panelCabecalho.Controls.Add(btnRestaurar);
            panelCabecalho.Controls.Add(btnMaximizar);
            panelCabecalho.Dock = DockStyle.Top;
            panelCabecalho.Location = new Point(0, 0);
            panelCabecalho.Margin = new Padding(4, 3, 4, 3);
            panelCabecalho.Name = "panelCabecalho";
            panelCabecalho.Size = new Size(933, 46);
            panelCabecalho.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(721, 4);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(47, 39);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(128, 64, 0);
            label12.Location = new Point(13, 9);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(222, 30);
            label12.TabIndex = 27;
            label12.Text = "Cadastro Funcionario";
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.BackgroundImage = (Image)resources.GetObject("btnFechar.BackgroundImage");
            btnFechar.BackgroundImageLayout = ImageLayout.Center;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(883, 3);
            btnFechar.Margin = new Padding(4, 3, 4, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(47, 39);
            btnFechar.TabIndex = 0;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.BackgroundImage = (Image)resources.GetObject("btnRestaurar.BackgroundImage");
            btnRestaurar.BackgroundImageLayout = ImageLayout.Center;
            btnRestaurar.FlatAppearance.BorderSize = 0;
            btnRestaurar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnRestaurar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Location = new Point(776, 3);
            btnRestaurar.Margin = new Padding(4, 3, 4, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(47, 39);
            btnRestaurar.TabIndex = 0;
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackgroundImage = (Image)resources.GetObject("btnMaximizar.BackgroundImage");
            btnMaximizar.BackgroundImageLayout = ImageLayout.Center;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnMaximizar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Location = new Point(830, 3);
            btnMaximizar.Margin = new Padding(4, 3, 4, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(47, 39);
            btnMaximizar.TabIndex = 0;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(37, 46, 59);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 46);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(339, 567);
            panelMenu.TabIndex = 1;
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(textBox1);
            panelConteudo.Controls.Add(label11);
            panelConteudo.Controls.Add(btnVendas);
            panelConteudo.Controls.Add(txt_funcao);
            panelConteudo.Controls.Add(txt_salario);
            panelConteudo.Controls.Add(txt_endereco);
            panelConteudo.Controls.Add(txt_email);
            panelConteudo.Controls.Add(txt_telefone);
            panelConteudo.Controls.Add(txt_estadoCivil);
            panelConteudo.Controls.Add(txt_dataNascimento);
            panelConteudo.Controls.Add(txt_rg);
            panelConteudo.Controls.Add(txt_cpf);
            panelConteudo.Controls.Add(txt_nome);
            panelConteudo.Controls.Add(label10);
            panelConteudo.Controls.Add(label9);
            panelConteudo.Controls.Add(label8);
            panelConteudo.Controls.Add(label7);
            panelConteudo.Controls.Add(label6);
            panelConteudo.Controls.Add(label5);
            panelConteudo.Controls.Add(label4);
            panelConteudo.Controls.Add(label3);
            panelConteudo.Controls.Add(label1);
            panelConteudo.Controls.Add(label2);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(339, 46);
            panelConteudo.Margin = new Padding(4, 3, 4, 3);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(594, 567);
            panelConteudo.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(521, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(59, 23);
            textBox1.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(327, 109);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(187, 30);
            label11.TabIndex = 25;
            label11.Text = "Orgão Expedidor:";
            // 
            // btnVendas
            // 
            btnVendas.BackColor = SystemColors.AppWorkspace;
            btnVendas.FlatAppearance.BorderSize = 0;
            btnVendas.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVendas.ForeColor = Color.Black;
            btnVendas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVendas.Location = new Point(309, 438);
            btnVendas.Margin = new Padding(4, 3, 4, 3);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(152, 45);
            btnVendas.TabIndex = 24;
            btnVendas.Text = "Cadastrar";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // txt_funcao
            // 
            txt_funcao.Location = new Point(229, 376);
            txt_funcao.Name = "txt_funcao";
            txt_funcao.Size = new Size(351, 23);
            txt_funcao.TabIndex = 23;
            // 
            // txt_salario
            // 
            txt_salario.Location = new Point(229, 333);
            txt_salario.Name = "txt_salario";
            txt_salario.Size = new Size(351, 23);
            txt_salario.TabIndex = 22;
            // 
            // txt_endereco
            // 
            txt_endereco.Location = new Point(229, 296);
            txt_endereco.Name = "txt_endereco";
            txt_endereco.Size = new Size(351, 23);
            txt_endereco.TabIndex = 21;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(229, 257);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(351, 23);
            txt_email.TabIndex = 20;
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(229, 218);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(351, 23);
            txt_telefone.TabIndex = 19;
            // 
            // txt_estadoCivil
            // 
            txt_estadoCivil.Location = new Point(229, 179);
            txt_estadoCivil.Name = "txt_estadoCivil";
            txt_estadoCivil.Size = new Size(351, 23);
            txt_estadoCivil.TabIndex = 18;
            // 
            // txt_dataNascimento
            // 
            txt_dataNascimento.Location = new Point(229, 142);
            txt_dataNascimento.Name = "txt_dataNascimento";
            txt_dataNascimento.Size = new Size(351, 23);
            txt_dataNascimento.TabIndex = 17;
            // 
            // txt_rg
            // 
            txt_rg.Location = new Point(229, 110);
            txt_rg.Name = "txt_rg";
            txt_rg.Size = new Size(91, 23);
            txt_rg.TabIndex = 16;
            // 
            // txt_cpf
            // 
            txt_cpf.Location = new Point(229, 71);
            txt_cpf.Name = "txt_cpf";
            txt_cpf.Size = new Size(351, 23);
            txt_cpf.TabIndex = 15;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(229, 33);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(351, 23);
            txt_nome.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(105, 367);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(90, 30);
            label10.TabIndex = 13;
            label10.Text = "Função:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(107, 332);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 30);
            label9.TabIndex = 12;
            label9.Text = "Salario:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(84, 287);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(109, 30);
            label8.TabIndex = 11;
            label8.Text = "Endereço:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(121, 248);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 30);
            label7.TabIndex = 10;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(93, 211);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 30);
            label6.TabIndex = 9;
            label6.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(69, 172);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 30);
            label5.TabIndex = 8;
            label5.Text = "Estado Civil:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(8, 133);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(187, 30);
            label4.TabIndex = 7;
            label4.Text = "Data Nascimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(147, 103);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 30);
            label3.TabIndex = 6;
            label3.Text = "RG:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(139, 64);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 30);
            label1.TabIndex = 5;
            label1.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(122, 26);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 30);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            label2.Click += label2_Click;
            // 
            // FormFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 613);
            Controls.Add(panelConteudo);
            Controls.Add(panelMenu);
            Controls.Add(panelCabecalho);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelCabecalho.ResumeLayout(false);
            panelCabecalho.PerformLayout();
            panelConteudo.ResumeLayout(false);
            panelConteudo.PerformLayout();
            ResumeLayout(false);
        }


        #region Windows Form Designer generated code
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelConteudo;

        #endregion

        private Label label2;
        private Label label3;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnVendas;
        private TextBox txt_funcao;
        private TextBox txt_salario;
        private TextBox txt_endereco;
        private TextBox txt_email;
        private TextBox txt_telefone;
        private TextBox txt_estadoCivil;
        private TextBox txt_dataNascimento;
        private TextBox txt_rg;
        private TextBox txt_cpf;
        private TextBox txt_nome;
        private Label label11;
        private TextBox textBox1;
        private Label label12;
        private Button button1;
    }
}