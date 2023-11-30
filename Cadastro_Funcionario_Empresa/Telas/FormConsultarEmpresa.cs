using AppGunaExemplo.Configuracao;
using TelaDesign;

namespace Venda_Bovina
{
    public partial class FormConsultarEmpresa : Form
    {
        public FormConsultarEmpresa()
        {
            InitializeComponent();
            Consultar();
            foreach (Empresa str in Program.empresasLista)
            {
                dataGridView1.Rows.Add(str.Cnpj, str.RazaoSocial, str.NomeFantasia, str.SituacaoCadastral, str.RegimeTributario, str.DataInicio, str.Telefone, str.CapitalSocial, str.Endereco, str.Tipo, str.PorteEmpresa, str.NaturezaJuridica, str.Proprietario, str.CPF);
            }
            Program.empresasLista.Clear();

        }


        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM Empresa");
                var leitor = comando.ExecuteReader();


                while (leitor.Read())
                {
                    Empresa conexao1 = new Empresa(DAOHelper.GetString(leitor, "cnpj_emp"),DAOHelper.GetString(leitor, "razaoSocial_emp"),DAOHelper.GetString(leitor, "nomeFantasia_emp"), DAOHelper.GetString(leitor, "situacaoCadastral_emp"), DAOHelper.GetString(leitor, "regimeTributario_emp"), Convert.ToDateTime(DAOHelper.GetString(leitor, "dataInicio_emp")), DAOHelper.GetString(leitor, "telefone_emp"), Convert.ToDouble(DAOHelper.GetString(leitor, "capitalSocial_emp")), DAOHelper.GetString(leitor, "endereco_emp"), DAOHelper.GetString(leitor, "tipo_emp"), DAOHelper.GetString(leitor, "porteEmpresa_emp"), DAOHelper.GetString(leitor, "naturezaJuridica_emp"), DAOHelper.GetString(leitor, "proprietario_emp"), DAOHelper.GetString(leitor, "cpf_emp"));
                    Program.empresasLista.Add(conexao1);
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
