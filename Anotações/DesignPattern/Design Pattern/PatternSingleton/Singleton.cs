namespace Design_Pattern.PatternSingleton
{
    /*
     * O padrão Singleton resolve dois problemas de uma só vez, violando o princípio de responsabilidade única:
     * 
     * 1. Garantir que uma classe tenha apenas uma única instância. Por que alguém iria querer controlar quantas instâncias uma classe tem? A razão mais comum para isso é para controlar o acesso a algum recurso compartilhado—por exemplo, uma base de dados ou um arquivo.
     * Funciona assim: imagine que você criou um objeto, mas depois de um tempo você decidiu criar um novo. Ao invés de receber um objeto fresco, você obterá um que já foi criado.
     * Observe que esse comportamento é impossível implementar com um construtor regular uma vez que uma chamada do construtor deve sempre retornar um novo objeto por design.
     * 
     * 2. Fornece um ponto de acesso global para aquela instância. Se lembra daquelas variáveis globais que você (tá bom, eu) usou para guardar alguns objetos essenciais? Embora sejam muito úteis, elas também são muito inseguras uma vez que qualquer código pode potencialmente sobrescrever os conteúdos daquelas variáveis e quebrar a aplicação.
     * Assim como uma variável global, o padrão Singleton permite que você acesse algum objeto de qualquer lugar no programa. Contudo, ele também protege aquela instância de ser sobrescrita por outro código.
     * Há outro lado para esse problema: você não quer que o código que resolve o problema #1 fique espalhado por todo seu programa. É muito melhor tê-lo dentro de uma classe, especialmente se o resto do seu código já depende dela.
     */
    internal class Singleton
    {
        // Adicione um atributo privado estático na classe para o armazenamento da instância singleton.
        private static Singleton instance;

        // Campo para contar o número de instancia. está sendo declarado como privado para que o usuário não possa muda-lo
        private int contIns = 0;

        // O construtor é declarado como privado para que somente a classe possa declara-lo. O método getInstance deve ser o único modo de obter o objeto singleton.
        private Singleton()
        {
            // Aumenta o contador de 1 em 1
            contIns++;
            // Mostra na tela o contador
            Console.WriteLine("Número de Instancias: " + contIns);
            Console.WriteLine("Instancia sendo declarada.");
        }

        // Declare um método de criação público estático para obter a instância singleton.
        // A classe Singleton declara o método estático getInstance que retorna a mesma instância de sua própria classe.
        public static Singleton GetInstance()
        {
            // Só permite que uma instancia seja criada
            if (instance == null)
            {
                // Atenção: se você está criando uma aplicação com apoio multithreading (varios processos/aplicaçãoes), você deve colocar um thread lock aqui.
                instance = new Singleton();
            }
            return instance;
        }
    }
}
