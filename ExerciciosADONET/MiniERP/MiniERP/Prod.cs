using System;
using System.Data;

namespace MiniERP
{
    public partial class Prod : Form
    {
        public Prod()
        {
            InitializeComponent();
        }

        private void Add(object sender, EventArgs e)
        {
            Produto prod = new();
            prod.nome = tbNome.Text;
            prod.forn = int.Parse(tbForn.Text);
            prod.preco = decimal.Parse(tbPreco.Text);
            prod.desc = tbDesc.Text;

            prod.Add();
            Read(null, null);
        }

        private void Read(object sender, EventArgs e)
        {
            BD bd = new();
            string sql = "SELECT Produtos.id AS 'CÓDIGO', " +
                "Produtos.nome AS 'Titulo', " +
                "Fornecedores.nome AS 'Fornecedor', " +
                "Produtos.preco AS 'Preço', " +
                "Produtos.descricao AS 'Descrição'" +
                "FROM Produtos " +
                "INNER JOIN Fornecedores ON Produtos.fk_forn = Fornecedores.id";
            DataTable dt = new();
            dt = bd.ConsultarTabela(sql);
            dgvTableProd.DataSource = dt;
        }

        private void Search(object sender, EventArgs e)
        {
            Produto prod = new();
            prod.Search(int.Parse(tbId.Text));
            MessageBox.Show("Fornecedor encotrado: \n" +
                $"{prod.nome}; {prod.preco}; {prod.desc}", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Update(object sender, EventArgs e)
        {
            Produto prod = new();
            prod.id = int.Parse(tbId.Text);
            prod.nome = tbNome.Text;
            prod.forn = int.Parse(tbForn.Text);
            prod.preco = decimal.Parse(tbPreco.Text);
            prod.desc = tbDesc.Text;

            if (prod.Update()) MessageBox.Show("Produto alterado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Erro ao alterar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Read(null, null);
        }

        private void Delete(object sender, EventArgs e)
        {
            Produto prod = new();
            prod.id = int.Parse(tbId.Text);

            if (prod.Delete()) MessageBox.Show("Produto excluido com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Erro ao excluir!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Read(null, null);
        }

        private void Decimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44)
                e.Handled = true;
        }
    }
}
