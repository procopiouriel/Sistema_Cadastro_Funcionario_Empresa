using AppGunaExemplo.Configuracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaDesign;

namespace Venda_Bovina
{
    public partial class FormConsultarFuncionario : Form
    {
        public FormConsultarFuncionario()
        {
            InitializeComponent();
            Consultar();
            foreach (Funcionario str in Program.funcionariosLista)
            {
                dataGridView1.Rows.Add(str.Nome, str.Cpf, str.Rg, str.DataNascimento, str.EstadoCivil, str.Telefone, str.Email, str.Endereco, str.Salario, str.Funcao);
            }
            Program.funcionariosLista.Clear();

        }
        

        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM Funcionario");
                var leitor = comando.ExecuteReader();


                while (leitor.Read())
                {
                    Funcionario conexao1 = new Funcionario(DAOHelper.GetString(leitor, "nome_fun"), DAOHelper.GetString(leitor, "cpf_fun"), DAOHelper.GetString(leitor, "rg_fun"), Convert.ToDateTime(DAOHelper.GetString(leitor, "dataNascimento_fun")), DAOHelper.GetString(leitor, "estadoCivil_fun"), DAOHelper.GetString(leitor, "telefone_fun"), DAOHelper.GetString(leitor, "email_fun"), DAOHelper.GetString(leitor, "endereco_fun"), Convert.ToDouble(DAOHelper.GetString(leitor, "salario_fun")), DAOHelper.GetString(leitor, "funcao_fun"));
                    Program.funcionariosLista.Add(conexao1);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormInicial tela = new FormInicial();
            this.Visible = false;
            tela.ShowDialog();
        }
    }
}
