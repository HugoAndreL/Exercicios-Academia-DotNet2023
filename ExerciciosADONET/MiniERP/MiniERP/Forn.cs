using System.Data;

namespace MiniERP
{
    public partial class Forn : Form
    {
        public Forn()
        {
            InitializeComponent();
        }

        private void AddForn(object sender, EventArgs e)
        {
            Fornecedores forn = new();
            forn.nome = tbNome.Text;
            forn.cnpj = int.Parse(tbCNPJ.Text);
            forn.desc = tbDesc.Text;
            forn.datCriacao = tbDatCriacao.Text;

            forn.Add();
            Read(null, null);
        }

        private void Read(object sender, EventArgs e)
        {
            BD bd = new();
            string sql = "SELECT id AS 'ID', nome AS 'Nome', cnpj AS 'CNPJ', descricao AS 'Descrição', datCriacao AS 'Data de Criação' FROM Fornecedores";
            DataTable dt = new();
            dt = bd.ConsultarTabela(sql);
            dgvTableForn.DataSource = dt;
        }

        private void Search(object sender, EventArgs e)
        {
            Fornecedores forn = new();
            forn.Search(int.Parse(tbId.Text));
            MessageBox.Show("Fornecedor encotrado: \n" +
                $"{forn.nome}, {forn.cnpj}, {forn.desc}, {forn.datCriacao}", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Update(object sender, EventArgs e)
        {
            Fornecedores forn = new();
            forn.id = int.Parse(tbId.Text);
            forn.nome = tbNome.Text;
            forn.cnpj = int.Parse(tbCNPJ.Text);
            forn.desc = tbDesc.Text;
            forn.datCriacao = tbDatCriacao.Text;

            if (forn.Update()) MessageBox.Show("Fornecerdor alterado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Erro ao alterar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Read(null, null);
        }

        private void Delete(object sender, EventArgs e)
        {
            Fornecedores forn = new();
            forn.id = int.Parse(tbId.Text);

            if (forn.Delete()) MessageBox.Show("Fornecerdor excluido com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Erro ao alterar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Read(null, null);
        }
    }
}
