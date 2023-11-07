using ExerciciosAulaAbstrata_e_Interfaces.Classes;
using ExerciciosAulaAbstrata_e_Interfaces.Interfaces;

namespace ExerciciosAulaAbstrata_e_Interfaces
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
                    "1 = Exercicio 1\n" +
                    "2 = Exercicio 2\n" +
                    "3 = Exercicio 3\n" +
                    "4 = Exercicio 4\n" +
                    "5 = Exercicio 5\n" +
                    "--------------------------");
                int input = int.Parse(Console.ReadLine());
                Console.Write("\n");
                switch (input)
                {
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                    case 1:
                        ex1();
                        break;
                    case 2:
                        ex2();
                        break;
                    case 3:
                        ex3();
                        break;
                    case 4:
                        ex4();
                        break;
                    case 5:
                        ex5();
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

        private static void ex5()
        {
            /*
             * 5 - Crie uma classe abstrata "Produto" com propriedades para "Nome", "Preço" e um método abstrato "CalcularDesconto". Crie classes derivadas para diferentes tipos de produtos, como "Livro" e "Eletrônico", que implementam o método "CalcularDesconto" de acordo com as regras específicas de desconto para cada tipo de produto.
             * Livro – 5% de desconto
             * Eletrônico  - 12.5% de desconto
             */
            // Calculo do Livro
            Livro li = new();
            li.Nome = "Extraordinario";
            li.Preco = 30.50;
            li.CalcularDesconto();

            Console.WriteLine("---------------------------");

            // Calculo do Eletronico
            Eletronico ele = new();
            ele.Nome = "Laptop Lenovo YOGA 520";
            ele.Preco = 580.00;
            ele.CalcularDesconto();
        }

        private static void ex4()
        {
            // 4 - Crie uma classe abstrata "ContaBancaria" com propriedades para "Saldo" e métodos abstratos "Depositar" e "Sacar". Crie classes derivadas, como "ContaCorrente" e "ContaPoupanca", que implementam os métodos de depósito e saque de acordo com as regras de cada tipo de conta.
            // Conta Corrente
            ContaCorrente cc = new();
            cc.Depositar();
            cc.Sacar();

            Console.WriteLine("--------------------------");

            // Conta Poupança
            ContaPoupanca cp = new();
            cp.Depositar();
            cp.Sacar();
        }

        private static void ex3()
        {
            /*
             * 3 - Crie uma interface chamada "IFormaGeometrica" com dois métodos abstratos: "CalcularArea()" e "CalcularPerimetro()". 
             * Em seguida, crie duas classes que implementam essa interface: "Retangulo" e "Circulo". 
             * Implemente os métodos "CalcularArea()" e "CalcularPerimetro()" para cada uma dessas classes, de forma que o "Retangulo" calcule a área e o perímetro de um retângulo e o "Circulo" calcule a área e o perímetro de um círculo. 
             */
            // Calculo do Circulo
            Circulo ci = new();
            ci.r = 4.5f;
            ci.CalcularPerimetro();
            ci.CalcularArea();

            Console.WriteLine("-------------------------");

            // Calculo do Retangulo
            Retangulo ret = new();
            ret.B = 4.5f;
            ret.H = 5.0f;
            ret.CalcularPerimetro();
            ret.CalcularArea();
            Console.WriteLine();
        }

        private static void ex2()
        {
            /*
             * 2 - Criar uma classe Veiculo que contém as propriedades Marca e Modelo.Criar um método abstrato chamado Dirigir.Criar duas classes derivadas, Carro e Moto, que herdam de Veiculo. 
             * A classe Carro deve ter uma propriedade adicional QuantidadeDePortas, enquanto a classe Moto deve ter uma propriedade adicional Cilindrada. 
             * Criar um método abstrato Dirigir na classe Veiculo. 
             * Em seguida, criar um método Dirigir na classe Carro que imprime "Dirigindo o <marca> <modelo> com <quantidadeDePortas> portas" e um método Dirigir na classe Moto que imprime "Dirigindo a <marca> <modelo> com <cilindrada> cilindradas"
             */
            // Mensagem do Carro
            Carro car = new();
            car.Marca = "Fusca";
            car.Modelo = 2000;
            car.QuantidadeDePortas = 4;
            car.Dirigir();
            
            Console.WriteLine("--------------------------");

            // Mensagem da Moto
            Moto moto = new();
            moto.Marca = "Yamaha";
            moto.Modelo = 2020;
            moto.Cilindrada = 160;
            moto.Dirigir();
        }

        private static void ex1()
        {
            /*
             * 1 - Criar uma classe Pessoa que contém as propriedades Nome e Idade. Criar duas classes derivadas, Aluno e Professor, que herdam de Pessoa.  
             * A classe Aluno deve ter uma propriedade adicional Matricula, enquanto a classe Professor deve ter uma propriedade adicional Disciplina.  
             * Criar um método abstrato Apresentar na classe Pessoa. 
             * Em seguida, criar um método Apresentar na classe Aluno que imprime o nome, a idade e a matrícula do aluno, e um método Apresentar na classe Professor que imprime o nome, a idade e a disciplina do professor. 
             */
            Aluno aluno = new();
            Professor prof = new();
            aluno.Nome = "Hugo André";
            aluno.Idade = 20;
            aluno.Matricula = "Academia UFN 2023";
            aluno.Apresentar();
            Console.WriteLine("--------------------------");
            prof.Nome = "Ricardo Frohlich da Silva";
            prof.Idade = 38;
            prof.Disciplina = "C#, POO, .NET MVC";
            prof.Apresentar();
        }
    }
}