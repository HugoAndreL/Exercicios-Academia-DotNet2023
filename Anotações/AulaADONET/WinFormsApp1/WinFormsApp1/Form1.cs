using System.Data;

namespace Teste_ADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Consultar(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable table = new DataTable();

            table = bd.ConsultarTabela("SELECT * FROM Pessoas");

            dvPessoas.DataSource = table;
        }

        private void AddPessoa(object sender, EventArgs e)
        {
            Pessoa p = new();
            p.nome = tbNome.Text;
            p.idade = int.Parse(tbIdade.Text);
            if (p.Add())
            {
                MessageBox.Show("Cadastrado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Consultar(null, null);
            }
            else MessageBox.Show("Falha ao Cadastrar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
