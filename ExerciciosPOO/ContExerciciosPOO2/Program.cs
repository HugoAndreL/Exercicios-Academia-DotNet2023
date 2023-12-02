using static Cont_ExerciciosPOO2.Classes;

namespace Cont_ExerciciosPOO2
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                // Opção de escolha
                Console.WriteLine("Selecione um Exercicio (Digite apenas o número do exercicio):\n" +
                    "-------------------------\n" +
                    "8 = Exercicio 8\n" +
                    "9 = Exercicio 9\n" +
                    "10 = Exercicio 10\n" +
                    "11 = Exercicio 11\n" +
                    "12 = Exercicio 12\n" +
                    "--------------------------");
                int input = int.Parse(Console.ReadLine());
                Console.Write("\n");
                switch (input)
                {
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                    case 8:
                        ex8();
                        break;
                    case 9:
                        ex9();
                        break;
                    case 10:
                        ex10();
                        break;
                    case 11:
                        ex11();
                        break;
                    case 12:
                        ex12();
                        break;
                }
                Console.Write("Deseja limpar o console (S - Sim; N - Não): ");
                char cls = char.Parse(Console.ReadLine());
                if (cls == 'S' || cls == 's')
                    Console.Clear();
                else
                {
                    Console.Write("\n");
                    Console.WriteLine($"Retornando à pagina de navegação.\n");
                }
            }
        }

        private static void ex12()
        {
            /*
             * 12 - Crie uma classe Agenda que pode armazenar inúmeras pessoas e que seja capaz de realizar as seguintes operações:
             * void armazenaPessoa(String nome, int idade, float altura);
             * void removePessoa(String nome);
             * Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
             * void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda
             * Faça um menu para navegar entre as opções infinitamente.
             */
            Agenda ag = new();
            List<Agenda> agLst = new();
            // Pergutando os valores da agenda
            // Menu de Navegação
            while (true)
            { 
                Console.WriteLine("O que gostaria de fazer:\n" +
                    "1 = Armazenar Pessoa\n" +
                    "2 = Remover Pessoa\n" +
                    "3 = Buscar Pessoa\n" +
                    "4 = Imprime Agenda");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    default:
                        Console.WriteLine("\nValor Invalido! Tente novamente");
                        break;
                    case 1:
                        ag.LerPessoa();
                        ag.armazenaPessoa(ag.Nome, ag.Idade, ag.Altura);
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.Write("Digite seu nome da qual será removida: ");
                        ag.Nome = Console.ReadLine();
                        ag.removePessoa(ag.Nome);
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.Write("Digite seu nome da qual será buscada: ");
                        ag.Nome = Console.ReadLine();
                        ag.buscaPessoa(ag.Nome);
                        break;
                    case 4:
                        ag.imprimeAgenda();
                        break;
                }
            }
        }

        private static void ex11()
        {
            // 11 - Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade". Em seguida, crie um método para acelerar o carro (aumentando a velocidade em 10) e outro para frear o carro (diminuindo a velocidade em 10, mas nunca deixando a  velocidade negativa).
            Carro car = new();
            car.LerCarro();
            while (true)
            {
                Console.WriteLine("O que gostaria de fazer:\n" +
                    "1 = Acelera o carro\n" +
                    "2 = Frea o carro\n" +
                    "3 = Parar");
                int op = int.Parse(Console.ReadLine());
                Console.Write("\n");
                switch(op)
                {
                    case 1:
                        car.AceleraCarro();
                        break;
                    case 2:
                        car.FrearCarro();
                        break;
                    case 3:
                        break;
                }
                if (op == 3)
                {
                    break;
                }
            }
            Console.WriteLine(car);
        }

        private static void ex10()
        {
            // 10 - Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade. Crie também um método chamado EmitirSom, que imprime na tela o som do animal.
            Animal gato = new("Mingau", "Gato", 6);
            Animal cachoro = new("Rock", "Cachorro", 5);
            Animal passaro = new("Speary", "Passaro", 3);

            gato.EmitirSom();
            Console.WriteLine();
            cachoro.EmitirSom();
            Console.WriteLine();
            passaro.EmitirSom();
        }

        private static void ex9()
        {
            // 9 - Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor. Utilize o encapsulamento  para garantir que o título e o autor não sejam vazios.
            Livro liv = new();
            liv.LerLivro();
            Console.WriteLine(liv);
        }

        private static void ex8()
        {
            // 8 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade.  Produto que tenha as propriedades Nome, Fabricante (objeto da classe Fabricante) e Preco. Utilize o encapsulamento para garantir que o nome não seja vazio e que o preço seja positivo. 
            Fabricante fab = new("Nestle", "São Paulo", "Suzano");
            Produto prod = new();
            prod.LerProd(fab);
            prod.MostrarProd();
        }
    }
}