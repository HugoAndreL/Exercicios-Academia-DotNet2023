namespace Exercicios_Aula4
{
    internal class ExerciciosRepeticao
    {
        static void Main()
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
                Console.WriteLine("Deseja limpar o console: (true - Sim; false - Não)");
                bool cls = bool.Parse(Console.ReadLine());
                if (cls == true)
                    Console.Clear();
                else
                {
                    Console.Write("\n");
                    Console.WriteLine($"Retornando à pagina de navegação.\n");
                }
            }
        }

        static void ex1()
        {
            /*
             * 1.Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n
             * pessoas e calcular a média das idades.
             */
            Console.WriteLine("***** Exercicio 1 - Aula 4 *****");

            int n, nIdades = 0;
            float mediaIdades;

            Console.Write("Digite o número de pessoas (n): ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Digite a idade da pessoa {i}: ");
                int idade = int.Parse(Console.ReadLine());

                nIdades += idade;
            }

            mediaIdades = (float)nIdades / n;

            Console.WriteLine("----------------------------");
            Console.WriteLine($"A média das idades é: {mediaIdades}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex2()
        {
            // 2.Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.
            Console.WriteLine("***** Exercicio 2 - Aula 4 *****");

            int num, numMaior = int.MinValue;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Insira o {i}º número:");
                num = int.Parse(Console.ReadLine());

                if (num > numMaior)
                    numMaior = num;
                else continue;
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Maior Número: {numMaior}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex3()
        {
            /*
             * 3. Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número
             * x lido utilizando laços de repetição, e mostre na tela.
             */
            Console.WriteLine("***** Exercicio 3 - Aula 4 *****");

            int x, result;

            Console.Write("Insira um número para calcular a tabuada:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------");
            for (int i = 1; i <= 10; i++)
            {
                result = x * i;
                Console.WriteLine($"{x} X {i} = {result}");
            }
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }
        
        static void ex4()
        {
            /*
             * 4.Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x
             * elevado na y sem utilizar a função pow.
             */
            Console.WriteLine("***** Exercicio 4 - Aula 4 *****");

            int x, y, result;

            Console.Write("Insira o valor de X:");
            x = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor de Y:");
            y = int.Parse(Console.ReadLine());

            result = 1;

            for (int i = 0; i < y; i++)
                result *= x;

            Console.WriteLine("----------------------------");
            Console.WriteLine($"O resultado de {x} elevado a {y} é: {result}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex5()
        {
            // 5. Escreva um algoritmo para calcular o fatorial de um número.
            Console.WriteLine("***** Exercicio 5 - Aula 4 *****");

            int num, fat;

            Console.WriteLine("Insira o número para ser fatorado:");
            num = int.Parse(Console.ReadLine());

            fat = 1;
            for (int i = 1; i <= num; i++)
            {
                fat *= i;
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"O fatorial de {num} é {fat}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex6()
        {
            /* 
             * 6. Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações 
             * aplicadas para aquela turma. Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final 
             * (média das notas das avaliações).
             */
            Console.WriteLine("***** Exercicio 6 - Aula 4 *****");

            int numAlunos, quantAvaliacoes;
            double nota, sumNotas, media;

            Console.Write("Digite o número de alunos na turma: ");
            numAlunos = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de avaliações aplicadas: ");
            quantAvaliacoes = int.Parse(Console.ReadLine());

            for (int aluno = 1; aluno <= numAlunos; aluno++)
            {
                sumNotas = 0;

                for (int avaliacao = 1; avaliacao <= quantAvaliacoes; avaliacao++)
                {
                    Console.Write($"Digite a nota da avaliação {avaliacao} para o aluno {aluno}: ");
                    nota = double.Parse(Console.ReadLine());
                    sumNotas += nota;
                }

                media = sumNotas / quantAvaliacoes;

                Console.WriteLine("----------------------------");
                Console.WriteLine($"A média das notas do aluno {aluno} é: {media}");
                Console.WriteLine("----- Fim do Exercicio -----\n");
            }

        }

        static void ex7()
        {
            /*
             * 7. Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por 
             * um usuário. Apresente o resultado.
             */
            Console.WriteLine("***** Exercicio 7 - Aula 4 *****");

            int numPar = 0, numImpar = 0, num;

            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    numPar++;
                }
                else
                {
                    numImpar++;
                }
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Quantidade de números pares: {numPar}\n" +
                $"Quantidade de números ímpares: {numImpar}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }
    }
}