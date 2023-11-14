using Newtonsoft.Json;

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

        // Créditos o canal documentação plena e a documentação do github https://github.com/ricardosma/academia_DotNet_5/blob/main/02-conteudo-aula/Serializa%C3%A7%C3%A3o.pdf
        // Função para serializar/escrever um json
        public bool JsonSerializar(string path, List<Friend> lstFriends)
        {
            var strJson = JsonConvert.SerializeObject(lstFriends, Formatting.Indented);
            return SaveFileFriends(path, strJson);
        }

        // Função para desserializar/ler um json
        public List<Friend> JsonDesserializar(string path)
        {
            var strJson = OpenFileFriends(path);
            // Caso as cinco primeiras letras da variavel strJson não for Falha
            if (strJson.Substring(0, 5) != "Falha")
                return JsonConvert.DeserializeObject<List<Friend>>(strJson);
            else
            {
                List<Friend> lstFriends = new();
                Friend fTmp = new();
                fTmp.Name = strJson;
                lstFriends.Add(fTmp);
                fTmp.Name = strJson;
                return lstFriends;
            }
        }


        public bool SaveFileFriends(string path, string strJson)
        {
            // Try e Cath pois está mexendendo em arquivos, então pode dar errado
            try
            {
                using (StreamWriter sw = new(path))
                    sw.WriteLine(strJson);

                return true;
            } catch (Exception err)
            {
                MessageBox.Show("Falha: " + err.Message + ".\n Error Detalhado: " + err, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static string OpenFileFriends(string path)
        {
            // Try e Cath pois está mexendendo em arquivos, então pode dar errado
            try
            {
                string strJson = "";
                using (StreamReader sr = new(path))
                    strJson = sr.ReadToEnd();

                return strJson;
            }
            catch (Exception err)
            {
                return "Falha: " + err.Message + ".\n Error Detalhado: " + err;
            }
        }
    }
}
