namespace Amigo_Secreto
{
    public partial class frmAmigoSecreto : Form
    {
        string path = "C:\\workspace\\Exercicios-Academia-DotNet2023-master\\ExerciciosWindowsForms\\ex1";
        string file = "pessoas.json";
        List<Friend> lstFriends = new();
        Friend fMet = new();
        int i = 0;

        public frmAmigoSecreto()
        {
            InitializeComponent();
            lstFriends = fMet.JsonDesserializar(@$"{path}\\{file}");
            dgvLst.DataSource = lstFriends;
            lblCounter.Text = $"Contador: {i}";
        }


        private void Clear(object sender, EventArgs e)
        {
            //tbName.Clear();
            //dgvLst.Rows.Remove(dgvLst.CurrentRow);

            //// Atualiza a tabela
            //dgvLst.DataSource = null;
            //dgvLst.DataSource = lstFriends;

            //// Renicia o Contador
            //i = 0;
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

                dgvLst.DataSource = null;
                dgvLst.DataSource = lstFriends;

                // @ Permite caractéres especiais
                f.JsonSerializar(@$"{path}\\{file}", lstFriends);

                // Limpa o input
                tbName.Clear();

                // Aumenta o contador
                i++;
            }
        }

        private void About(object sender, EventArgs e)
        {
            MessageBox.Show("Projeto feito por Hugo André para a Academia DotNet2023", "SOBRE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GerarEmail()
        {
            // Separando os elementos do nome para colocar o primeiro e o utimo nome no email 
            string nome = tbName.Text.ToLower();
            string[] email = nome.Split();
            // Retornando o email
            return $"{email[0]}.{email[email.Length - 1]}@ufn.edu.br";

        }
    }
}