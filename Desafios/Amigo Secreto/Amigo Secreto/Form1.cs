namespace Amigo_Secreto
{
    public partial class frmAmigoSecreto : Form
    {
        List<Friend> lstFriends = new();
        Friend fMet = new();
        int i = 0;

        public frmAmigoSecreto()
        {
            InitializeComponent();
            lstFriends = fMet.Ler(lstFriends);
            dgvLst.DataSource = lstFriends;

            // Atualiza o contador
            foreach (Friend f in lstFriends)
                i++;
            lblCounter.Text = $"Contador: {i}";
        }


        private void Clear(object sender, EventArgs e)
        {
            tbName.Clear();
            lstFriends.Clear();
            fMet.Desserializar(lstFriends);

            // Atualiza a tabela
            dgvLst.DataSource = null;
            dgvLst.DataSource = lstFriends;

            // Renicia o Contador
            i = 0;
            lblCounter.Text = $"Contador: {i}";
        }

        // Adiciona um item na lista
        private void Add(object sender, EventArgs e)
        {
            Friend f = new(tbName.Text, GerarEmail());
            if (string.IsNullOrWhiteSpace(tbName.Text.Trim()))
                MessageBox.Show("Um nome deve ser verificado!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                lstFriends.Add(f);

                // Atualiza a tabela
                dgvLst.DataSource = null;
                dgvLst.DataSource = lstFriends;

                f.Escrever($"{tbName.Text};{GerarEmail()}");

                // Limpa o input
                tbName.Clear();

                // Aumenta o contador
                i++;
                lblCounter.Text = $"Contador: {i}";
            }
        }

        private void About(object sender, EventArgs e)
        {
            MessageBox.Show("Projeto feito por Hugo André para a Academia DotNet2023", "SOBRE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GerarEmail()
        {
            // Separando os elementos do nome para colocar o primeiro e o utimo nome no email 
            string[] nome = tbName.Text.ToLower().Split();

            // Retornando o email
            return $"{nome[0]}.{nome[nome.Length - 1]}@ufn.edu.br";
        }
    }
}
