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
                        MultiMusic();
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

        private static void MultiMusic()
        {
            //// Logo do Console Aplicativo
            //Color(ConsoleColor.Green, "'  ___  ___        _  _    _ ___  ___             _           _____                            _       \r\n'  |  \\/  |       | || |  (_)|  \\/  |            (_)         /  __ \\                          | |      \r\n'  | .  . | _   _ | || |_  _ | .  . | _   _  ___  _   ___    | /  \\/  ___   _ __   ___   ___  | |  ___ \r\n'  | |\\/| || | | || || __|| || |\\/| || | | |/ __|| | / __|   | |     / _ \\ | '_ \\ / __| / _ \\ | | / _ \\\r\n'  | |  | || |_| || || |_ | || |  | || |_| |\\__ \\| || (__  _ | \\__/\\| (_) || | | |\\__ \\| (_) || ||  __/\r\n'  \\_|  |_/ \\__,_||_| \\__||_|\\_|  |_/ \\__,_||___/|_| \\___|(_) \\____/ \\___/ |_| |_||___/ \\___/ |_| \\___|\r\n' ");
            //Console.WriteLine();
            //// Cria uma playlist para usar no loop
            //Playlist playlist = new();

            //// Faz o loop verificando a opção
            //while (true)
            //{
            //    Console.WriteLine("O que gostaria de fazer:\n" +
            //        "1 = Adicionar Música na Playlist \n" +
            //        "2 = Criar nova Playlist \n" +
            //        "3 = Tocar Música \n");
            //    int op = int.Parse(Console.ReadLine());
            //    switch (op)
            //    {
            //        case 1:
            //            playlist.AddMusic()
            //    }
            //    break;
            //}
        }

        private static void ex6()
        {
            

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
            // Organizar
            List<Produto> Stock = new();
            Produto Prod = new();
            while (true)
            {
                // Opção de escolha
                Console.WriteLine("Selecione uma opção (Digite apenas o número do exercicio):\n" +
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
                }
            }
        }
    }
}