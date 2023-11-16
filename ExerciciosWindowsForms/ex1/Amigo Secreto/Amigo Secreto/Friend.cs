namespace Amigo_Secreto
{
    public class Friend
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Friend() {}

        public Friend(string Name, string Email)
        {
            this.Name = Name;
            this.Email = Email;
        }

        // Créditos ao canal Alexandre Zamberlan. Video https://www.youtube.com/watch?v=JgBqsIffWdU&list=LL&index=3
        // Função para serializar/escrever um json
        public void Serializar(string dados)
        {
            StreamWriter writter = new("pessoas.csv", true);
            writter.WriteLine(dados);
            writter.Close();
        }

        // Função para desserializar/ler um json
        public List<Friend> Desserializar(List<Friend> lstF)
        {
            StreamReader readder = new("pessoas.csv");
            while (!readder.EndOfStream)
            {
                string[] nameEmail = readder.ReadLine().Split(";");
                lstF.Add(new Friend(nameEmail[1], nameEmail[2]));
            }
            return lstF;
        }
    }
}
