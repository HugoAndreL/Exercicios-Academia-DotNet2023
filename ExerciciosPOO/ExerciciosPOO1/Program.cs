namespace ExercicioPOO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Opção de escolha
                Console.WriteLine("Selecione um Exercicio (Digite apenas o número do exercicio):\n" +
                    "-------------------------\n" +
                    "1 = Exercicio 1 - Aula 1\n" +
                    "2 = Exercicio 2 - Aula 1\n" +
                    "3 = Exercicio 3 - Aula 1\n" +
                    "4 = Exercicio 4 - Aula 1\n" +
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

        private static void ex4()
        {
            Livro li = new Livro("O Codificador Limpo | Clean Coder", "Robert C. Martin", 209, "Progamação");
            li.Emprestar();
            li.Devolver();
        }

        private static void ex3()
        {
            Random rdn = new Random();
            Personagem p = new Personagem("Mago", 100, 0, rdn.Next(1, 4));
            p.Atacar(50);
            p.Movimentar(rdn.Next(1, 4));
        }

        private static void ex2()
        {
            Aluno a = new Aluno("Hugo André", "Superior", "Concluído", "Cruzeiro do Sul");

            a.MostrarAluno();
        }

        static void ex1()
        {
            Pessoa p = new Pessoa();

            p.CasdastrarPessoa();
            p.MostrarPessoa();
        }
    }
}