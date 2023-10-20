using System;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;

namespace Exercicios_Aula19
{
    internal class ExerciciosFuncoes2
    {
        static int[] vet = new int[10];

        static void Main()
        {
            while (true)
            {
                // Opção de escolha
                Console.WriteLine("Selecione um Exercicio (Digite apenas o número do exercicio):\n" +
                    "-------------------------\n" +
                    "1 = Exercicio 1 - Aula 19\n" +
                    "2 = Exercicio 2 - Aula 19\n" +
                    "3 = Exercicio 3 - Aula 19\n" +
                    "4 = Exercicio 4 - Aula 19\n" +
                    "5 = Exercicio 5 - Aula 19\n" +
                    "6 = Exercicio 6 - Aula 19\n" +
                    "7 = Exercicio 7 - Aula 19\n" +
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
            // 7 - Crie uma função chamada VerificarNumeroPrimo que recebe um vetor de números inteiros como parâmetro e retorna verdadeiro se pelo menos um número primo estiver presente no vetor, e falso caso contrário.
            int[] vet = { 17 /* (Primo) */, 10 /* (Não primo) */, 29 /* (Primo) */, 6 /* (Não primo) */, 11 /* (Primo) */, 4 /* (Não primo) */, 19 /* (Primo) */ };
    
            Console.WriteLine(VerificarNumeroPrimo(vet));
          
        }

        static bool VerificarNumeroPrimo(int[] numeros)
        {
            bool imparPar = false;
            foreach (int n in numeros)
            {
                if (n <= 1)
                    imparPar = false;
                if (n == 2)
                    imparPar = true;
                if (n % 2 == 0)
                    imparPar = false;

                for (int i = 3; i <= Math.Sqrt(n); i += 2)
                    /*
                     * Math.Sqrt(double d);
                     * Retorna a raiz quadrada de um número especificado.
                     */
                    if (n % i == 0)
                        imparPar = false;

                imparPar = true;
            }

            return imparPar;
        }

        private static void ex6()
        {
            // 6 - Escreva uma função chamada MediaColunaMatriz que recebe uma matriz e um número de coluna como parâmetros, e retorna a soma dos elementos nessa coluna.
            int[,] mat = new int[2, 2]
            {
                { 1, 2 },
                { 3, 4 }
            };

            Console.WriteLine(MediaColunaMatriz(mat, 0));
            Console.WriteLine(MediaColunaMatriz(mat, 1));
        }

        private static int MediaColunaMatriz(int[,] mat, int v)
        {
            int sum = 0;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                sum = mat[i, v] * mat[i, v]; 
            }

            return sum;
        }

        private static void ex5()
        {
            // 5 - Crie uma função chamada SomaDiagonalPrincipal que recebe uma matriz quadrada como parâmetro e retorna a soma dos elementos na diagonal principal.
            int[,] mat = new int[2, 2]
            {
                { 1, 2 },
                { 3, 4 }
            };

            Console.WriteLine(SomaDiagonalPrincipal(mat));
        }

        private static int SomaDiagonalPrincipal(int[,] matriz)
        {
            int sum = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
                sum += matriz[i, i];

            return sum;
        }

        private static void ex4()
        {
            // 4 - Escreva uma função chamada MultiplicarMatrizes que recebe duas matrizes como parâmetros e retorna a matriz resultante da multiplicação.
            int[,] mat1 = new int[2, 2], mat2 = new int[2, 2];

            LerMatriz(mat1);
            LerMatriz(mat2);

            MostrarMatriz(MultiplicarMatrizes(mat1, mat2));
        }

        private static int[,] MultiplicarMatrizes(int[,] matMult, int[,] mat2)
        {
            int[,] matRes = new int[2, 2];

            for (int i = 0; i < matMult.GetLength(0); i++)
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    matRes[i, j] = matMult[i, j] * mat2[i, j];
                }

            return matRes;
        }

        private static void LerMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Insira um numero para matriz desejada na linha {i + 1}, coluna {j + 1}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        private static void ex3()
        {
            // 3 - Escreva uma função chamada TransporMatriz que recebe uma matriz como parâmetro e retorna a matriz transposta.
            int[,] mat = new int[2, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            MostrarMatriz(TransporMatriz(mat));
        }

        static int[,] TransporMatriz(int[,] matriz)
        {
            int[,] matTransposta = new int[3, 2];

            for (int i = 0; i < matriz.GetLength(1); i++)
                for (int j = 0; j < matriz.GetLength(0); j++)
                    matTransposta[i, j] = matriz[j, i];


            return matTransposta;
        }

        static void MostrarMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                    Console.Write($"[ {matriz[i, j]} ]");
                Console.WriteLine();
            }
        }

        private static void ex2()
        {
            // 2 - Escreva uma função chamada CalcularMedia que recebe um vetor de números, a informação se o usuário deseja escolher os pares ou os impares, e retorna a média dos valores conforme a escolha do usuário.
            int[] vet = new int[3] { 1, 2, 5 };
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($"Insira o valor para o vet[{i}]: ");
                vet[i] = int.Parse(Console.ReadLine()); 
            }

            Console.Write("Agora insira o valor para pegar impares ou par (1 - Impar/2 - Par): ");
            int parImpar = int.Parse(Console.ReadLine());

            Console.WriteLine(CalcularMedia(vet, parImpar));
        }

        private static int CalcularMedia(int[] vetor, int parImpar)
        {
            int sum = 0, length = 0;

            if (parImpar == 1)
                for (int i = 0; i < vetor.Length; i++)
                    if (vetor[i] % 2 == (double)0)
                        sum++;
                    else continue;
            if (parImpar == 2)
                for (int i = 0; i < length; i++)
                    if (vetor[i] % 2 != (double)0)
                        sum++;
                    else continue;
                
            for (int i = 0; i < vetor.Length; i++)
                length++;

            int media = sum / length;
            return media;
        }

        private static void ex1()
        {
            // 1 - Na teoria dos Sistemas, define-se como elemento minimax de uma matriz, o menor elemento da linha em que se encontra o maior elemento da matriz. Escreva um programa que lê uma matriz [10 X 10] e em uma função encontre e mostre o elemento minimax e sua posição na matriz.
            int[,] mat = new int[10, 10];

            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"Insira o valor da mat[{i}, {j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }

            Minimax(mat);
        }

        private static void Minimax(int[,] matriz)
        {
            int minimax, row = 0, col = 0, maior = 0;

            // Determinando a linha com maior valor
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                        row = i;
                        col = j;
                    }

            // Determinando o menor valor desta linha
            minimax = matriz[row, 0];

            Console.WriteLine($"O menor elemento da matriz é {minimax}");
        }
    }
}