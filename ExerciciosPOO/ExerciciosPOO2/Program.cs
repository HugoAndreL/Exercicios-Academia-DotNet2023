namespace ExerciciosPOO2
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
                    "1 = Exercicio 1 - Aula 2\n" +
                    "2 = Exercicio 2 - Aula 2\n" +
                    "3 = Exercicio 3 - Aula 2\n" +
                    "4 = Exercicio 4 - Aula 2\n" +
                    "5 = Exercicio 5 - Aula 2\n" +
                    "6 = Exercicio 6 - Aula 2\n" +
                    "7 = Exercicio 7 - Aula 2\n" +
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
                    case 6:
                        ex6();
                        break;
                    case 7:
                        ex7();
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

        private static void ex7()
        {
            // Cria uma playlist para usar no loop
            Playlist playlist = new();
            Musica music1 = new Musica("Followers", "Area21", "Holywood Records");
            Musica music2 = new Musica("Roaylty", "Egzod, Maestro Chives, Neoni", "NGS");
            Musica music3 = new Musica("Not Over Yet", "KSI", "Warner Chapell Music");
            playlist.AddMusica(music1);
            playlist.AddMusica(music2);
            playlist.AddMusica(music3);
            playlist.TocarMusica();
        }

        private static void ex6()
        {
            // Cria uma Lista e uma Classe temporaria para o métodos do produto
            Produto Prod = new();
            List<Produto> Stock = new();

            while (true)
            {
                Console.WriteLine("Selecione uma opçao (Digite apenas o número):\n" +
                    "--------------------------\n" +
                    "1 = Inserir produto\n" +
                    "2 = Deletar produto\n" +
                    "3 = Mostrar produto\n" +
                    "4 = Buscar produto\n" +
                    "--------------------------");
                int op = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (op)
                {
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                    case 1:
                        Prod.AddProd(Stock);
                        break;
                    case 2:
                        Prod.DelProd(Stock);
                        break;
                    case 3:
                        Prod.MostrarProd(Stock);
                        break;
                    case 4:
                        Prod.BuscarProd(Stock);
                        break;
                }
                Console.Write("Deseja limpar o console (S - Sim; N - Não): ");
                char cls = char.Parse(Console.ReadLine());
                if (cls == 'S' || cls == 's')
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.Write("Opção cancelada\n");
                    Console.WriteLine($"Retornando à pagina de navegação.\n");
                    continue;
                }

            }

        }

        private static void ex5()
        {
            List<GerenciadorTarefas> gT = new();
            GerenciadorTarefas Tarefa = new();
            while (true)
            {
                // Opção de escolha
                Console.WriteLine("Selecione uma opção (Digite apenas o número do exercicio):\n" +
                    "-------------------------\n" +
                    "1 = Inserir tarefa\n" +
                    "2 = Remover tarefa\n" +
                    "3 = Mostrar tarefa\n" +
                    "--------------------------");
                int input = int.Parse(Console.ReadLine());
                Console.Write("\n");

                switch (input)
                {
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                    case 1:
                        Tarefa.AddTarefa(gT);
                        break;
                    case 2:
                        Tarefa.DelTarefa(gT);
                        break;
                    case 3:
                        Tarefa.MostrarTarefas(gT);
                        break;
                }
                Console.Write("Deseja limpar o console (S - Sim; N - Não): ");
                char cls = char.Parse(Console.ReadLine());
                if (cls != 'S' || cls != 's')
                    Console.Clear();
                else
                {
                    Console.Write("Opção cancelada\n");
                    Console.WriteLine($"Retornando à pagina de navegação.\n");
                }
            }
        }

        private static void ex4()
        {
            List<AgendaTelefonica> ATel = new List<AgendaTelefonica>();
            AgendaTelefonica Tel = new AgendaTelefonica();
            while (true)
            {
                // Opção de escolha
                Console.WriteLine("Selecione uma opção (Digite apenas o número do exercicio):\n" +
                    "-------------------------\n" +
                    "1 = Inserir telefone\n" +
                    "2 = Buscar telefone\n" +
                    "3 = Remover telefone\n" +
                    "--------------------------");
                int input = int.Parse(Console.ReadLine());
                Console.Write("\n");

                switch (input)
                {
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                    case 1:
                        Tel.AddTel(ATel);
                        break;
                    case 2:
                        Tel.BuscarTel(ATel);
                        break;
                    case 3:
                        Tel.DelTel(ATel);
                        break;
                    case 4:
                        Tel.MostrarContato(ATel);
                        break;
                }
                Console.Write("Deseja limpar o console (S - Sim; N - Não): ");
                char cls = char.Parse(Console.ReadLine());
                if (cls != 'S' || cls != 's')
                    Console.Clear();
                else
                {
                    Console.Write("Opção cancelada\n");
                    Console.WriteLine($"Retornando à pagina de navegação.\n");
                }
            }
        }

        private static void ex3()
        {
            List<CorretoraImoveis> corretoraImoveis = new();
            CorretoraImoveis corretora = new();
            while (true)
            {
                // Opção de escolha
                Console.WriteLine("Selecione um opção (Digite apenas o número do exercicio):\n" +
                    "-------------------------\n" +
                    "1 = Inserir imóveis\n" +
                    "2 = Alterar preço do imóvel\n" +
                    "3 = Apresentar imóveis\n" +
                    "4 = Apresentar média\n" +
                    "--------------------------");
                int input = int.Parse(Console.ReadLine());
                Console.Write("\n");


                switch (input)
                {
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                    case 1:
                        corretora.ListarImoveis(corretoraImoveis);
                        break;
                    case 2:
                        corretora.AlterarPreco(corretoraImoveis);
                        break;
                    case 3:
                        corretora.ApresentarImoveis(corretoraImoveis);
                        break;
                    case 4:
                        corretora.Calcular(corretoraImoveis);
                        break;
                }
                Console.Write("Deseja limpar o console (S - Sim; N - Não): ");
                char cls = char.Parse(Console.ReadLine());
                if (cls != 'S' || cls != 's')
                    Console.Clear();
                else
                {
                    Console.Write("Opção cancelada\n");
                    Console.WriteLine($"Retornando à pagina de navegação.\n");
                }
            }
        }

        private static void ex2()
        {
            List<RegistroCompras> regs = new();
            RegistroCompras reg = new();
            reg.AddCompra(regs);
            reg.ListarCompra(regs);
        }

        private static void ex1()
        {
            List<Produto> Stock = new();
            Produto Prod = new();
            while (true)
            {
                // Opção de escolha
                Console.WriteLine("Selecione uma opção (Digite apenas o número da opção):\n" +
                    "-------------------------\n" +
                    "1 = Inserir produto\n" +
                    "2 = Deletar produto\n" +
                    "3 = Mostrar produto\n" +
                    "--------------------------");
                int input = int.Parse(Console.ReadLine());
                Console.Write("\n");

                switch (input)
                {
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                    case 1:
                        Prod.AddProd(Stock);
                        break;
                    case 2:
                        Prod.DelProd(Stock);
                        break;
                    case 3:
                        Prod.MostrarProd(Stock);
                        break;
                }
                Console.Write("Deseja limpar o console (S - Sim; N - Não): ");
                char cls = char.Parse(Console.ReadLine());
                if (cls == 'S' || cls == 's')
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.Write("Opção cancelada\n");
                    Console.WriteLine($"Retornando à pagina de navegação.\n");
                    continue;
                }
            }
        }
    }
}