using System;
using System.Diagnostics;

namespace Exercicios_Aula5
{
    internal class ExerciciosRepeticao2
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Selecione um Exercicio: (Digite apenas o número do exercicio)\n" +
                "-------------------------\n" +
                "1 = Exercicio 1 - Aula 2\n" +
                "2 = Exercicio 2 - Aula 2\n" +
                "3 = Exercicio 3 - Aula 2\n" +
                "4 = Exercicio 4 - Aula 2\n" +
                "5 = Exercicio 5 - Aula 2\n" +
                "6 = Exercicio 6 - Aula 2\n" +
                "7 = Exercicio 7 - Aula 2\n" +
                "8 = Exercicio 7 - Aula 2\n" +
                "9 = Exercicio 7 - Aula 2\n" +
                "10 = Exercicio 7 - Aula 2\n" +
                "11 = Exercicio 7 - Aula 2\n" +
                "12 = Exercicio 7 - Aula 2\n" +
                "13 = Exercicio 7 - Aula 2\n" +
                "14 = Exercicio 7 - Aula 2\n" +
                "15 = Exercicio 7 - Aula 2\n" +
                "16 = Exercicio 7 - Aula 2\n" +
                "17 = Exercicio 7 - Aula 2\n" +
                "--------------------------");
                int input = int.Parse(Console.ReadLine());
                Console.Write("\n");

                switch (input)
                {
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                    case 1:
                        ex1("***** Exercicio 1 - Aula 5 *****");
                        break;
                    case 2:
                        ex2("***** Exercicio 2 - Aula 5 *****");
                        break;
                    case 3:
                        ex3("***** Exercicio 3 - Aula 5 *****");
                        break;
                    case 4:
                        ex4("***** Exercicio 4 - Aula 5 *****");
                        break;
                    case 5:
                        ex5("***** Exercicio 5 - Aula 5 *****");
                        break;
                    case 6:
                        ex6("***** Exercicio 6 - Aula 5 *****");
                        break;
                    case 7:
                        ex7("***** Exercicio 7 - Aula 5 *****");
                        break;
                    case 8:
                        ex8("***** Exercicio 7 - Aula 5 *****");
                        break;
                        //case 9:
                        //    ex9();
                        //    break;
                        //case 10:
                        //    ex10();
                        //    break;
                        //case 11:
                        //    ex11();
                        //    break;
                        //case 12:
                        //    ex12();
                        //    break;
                }
                Console.WriteLine("Deseja limpar o console: (S - Sim; N - Não)");
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

        static void ex1(string? msg) 
        {
            /*
             * 1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
             * (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
             * Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.
             */
            Console.WriteLine(msg);

            int n = -1; // Inicialize com um valor inválido

            while (n <= 0)
            {
                Console.Write("Digite um número inteiro positivo: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out n) && n > 0)
                    break; 
                else
                    Console.WriteLine("Número inválido. Por favor, digite um número inteiro positivo.");
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine($"Números pares entre 1 e {n}:");

            for (int i = 2; i <= n; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----- Fim do Programa -----\n");
        }

        static void ex2(string msg)
        {
            /*
             * 2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
             * informar um outro número. Caso positivo, o programa em VS deve ser repetido.
             */
            ex1(msg);

            char input;

            while (true)
            {
                Console.WriteLine("Gostaria de Informar outro número (s/n)?");
                input = char.Parse(Console.ReadLine());

                if (input == 'S' || input == 's')
                    ex1(null);
                else break;
            }
        }

        static void ex3(string msg)
        {
            /*
             * 3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
             * Se o usuário digitar 0 o programa em VS deve parar. 
             * Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.
             */
            Console.WriteLine(msg);

            int n;
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Insira um numero de usuário (Insira 0 para sair):");
                n = int.Parse(Console.ReadLine());

                if (n == 0)
                    sair = true;
                else continue;
            }

            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex4(string msg)
        {
            /* 4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
             * Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
             * Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
             * Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
             * escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
             * de votos em branco.
             */
            Console.WriteLine(msg);

            int zeca = 0, joao = 0, white = 0;
            string input;
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Digite o canditado à prefeito:\n" +
                    "JOAO\n" +
                    "ZECA\n" +
                    "BRANCO\n" +
                    "FIM para ver os resultados");
                input = Console.ReadLine();

                switch (input)
                {
                    case "ZECA":
                        zeca += 1;
                        break;
                    case "JOAO":
                        joao += 1;
                        break;
                    case "BRANCO":
                        white += 1;
                        break;
                    case "FIM":
                        sair = true;
                        break;
                }

                Console.Write("\n");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Resultados da Eleição:\n" +
                $"Votos Brancos: {white}\n" +
                $"Votos para Joao: {joao}\n" +
                $"Votos para Zeca: {zeca}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }
        
        static void ex5(string msg)
        {
            /*
             * 5.Modifique o programa em VS anterior para aceitar votos nulos
             * (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO).
             * Ao final, informe o nome do candidato vencedor, o número de votos nulos
             * e o número de pessoas que votaram.
             */
            Console.WriteLine(msg);

            int zeca = 0, joao = 0, white = 0, nulo = 0, maior = 0;
            string input, vencedor = "";
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Digite o canditado à prefeito:\n" +
                    "JOAO\n" +
                    "ZECA\n" +
                    "BRANCO\n" +
                    "FIM para ver os resultados");
                input = Console.ReadLine();

                switch (input)
                {
                    case "ZECA":
                        zeca += 1;
                        break;
                    case "JOAO":
                        joao += 1;
                        break;
                    case "BRANCO":
                        white += 1;
                        break;
                    case "FIM":
                        sair = true;
                        break;
                }
                if (input != "ZECA" && input != "JOAO" && input != "BRANCO" && input != "FIM")
                    nulo += 1;
                
                Console.Write("\n");
            }

            if (zeca > maior)
                vencedor = "Zeca";
            if (joao > maior)
                vencedor = "Joao";

            Console.WriteLine("----------------------------");
            Console.WriteLine("Resultados da Eleição:\n" +
                $"Votos Brancos: {white}\n" +
                $"Votos Nulos: {nulo}\n" +
                $"Votos para Joao: {joao}\n" +
                $"Votos para Zeca: {zeca}\n" +
                $"Cadidato Vencedor: {vencedor}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex6(string msg)
        {
            /*
             * 6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
             * ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
             * Ao final, mostre a idade digitada.
             */
            Console.WriteLine(msg);

            int idade = -1;

            while (idade <= 0)
            {
                Console.Write("Insira a sua idade:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out idade) && idade > 0)
                    break;
                else Console.WriteLine("Idade inválida. Por favor, insira uma idade válida maior do que zero.");
            }

            Console.WriteLine($"Idade válida digitada: {idade}");
        }

        static void ex7(string msg)
        {
            /*
             * 7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
             * A cada solicitação, teste se o usuário informou um valor válido. 
             * Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
             * informe que ele está incorreto e saia do programa em VS. 
             * Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
             * informe que está errada e saia. Se estiver correta, solicite o salário. 
             * Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
             * Se estiver correto, mostre todos os valores lidos.
             */
            Console.WriteLine(msg);

            string nome;
            int idade;
            double sal;


            while (true)
            {
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nome) || int.TryParse(nome, out _))
                {
                    Console.WriteLine("Nome incorreto. Por favor, digite um nome válido.");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.Write("Digite a idade: ");
                if (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
                {
                    Console.WriteLine("Idade incorreta. Por favor, digite uma idade válida maior que zero.");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.Write("Digite o salário: ");
                if (!double.TryParse(Console.ReadLine(), out sal) || sal <= 0)
                {
                    Console.WriteLine("Salário incorreto. Por favor, digite um salário válido maior que zero.");
                    continue;
                }

                break;
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Nome: {nome}\n" +
                $"Idade: {idade}\n" +
                $"Salário: R$ {sal},00");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex8(string msg)
        {
            /* 
             * 8. Faça um programa em VS que solicite um numero inteiro. 
             * Se o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
             * Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
             */
            Console.WriteLine(msg);


        }

        //static void ex9(string msg)
        //{

        //}

        //static void ex10(string msg)
        //{

        //}
        //static void ex11(string msg)
        //{

        //}
        //static void ex12(string msg) 
        //{
        //}
        //static void ex13(string msg) 
        //{ 
        //}
        //static void ex14(string msg) 
        //{
        //}
        //static void ex15(string msg)
        //{ 
        //}
        //static void ex16(string msg) 
        //{ 
        //}
        //static void ex17(string msg) 
        //{
        //}
        //static void ex18(string msg) 
        //{
        //}
        //static void ex19(string msg) 
        //{
        //}
        //static void ex20(string msg) 
        //{
        //}
    }
}