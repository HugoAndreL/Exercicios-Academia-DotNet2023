using System;
using System.ComponentModel;
using System.Numerics;

namespace Exercicios_Aula6
{
    internal class ExerciciosMatriz
    {
        static void Main()
        {
            while (true)
            {
                // Opção de escolha
                Console.WriteLine("Selecione um Exercicio: (Digite apenas o número do exercicio)\n" +
                    "-------------------------\n" +
                    "1 = Exercicio 1 - Aula 6\n" +
                    "2 = Exercicio 2 - Aula 6\n" +
                    "3 = Exercicio 3 - Aula 6\n" +
                    "4 = Exercicio 4 - Aula 6\n" +
                    "5 = Exercicio 5 - Aula 6\n" +
                    "6 = Exercicio 6 - Aula 6\n" +
                    "7 = Exercicio 7 - Aula 6\n" +
                    "8 = Exercicio 8 - Aula 6\n" +
                    "9 = Exercicio 9 - Aula 6\n" +
                    "10 = Exercicio 10 - Aula 6\n" +
                    "11 = Exercicio 11 - Aula 6\n" +
                    "12 = Exercicio 12 - Aula 6\n" +
                    "13 = Exercicio 13 - Aula 6\n" +
                    "14 = Exercicio 14 - Aula 6\n" +
                    "15 = Exercicio 15 - Aula 6\n" +
                    "16 = Exercicio 16 - Aula 6\n" +
                    "--------------------------");
                int input = int.Parse(Console.ReadLine());
                Console.Write("\n");
                switch (input)
                {
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                    case 1:
                        ex1(1);
                        break;
                    case 2:
                        ex2(2);
                        break;
                    case 3:
                        ex3(3);
                        break;
                    case 4:
                        ex4(4);
                        break;
                    case 5:
                        ex5(5);
                        break;
                    case 6:
                        ex6(6);
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

        static void ex1(int ex)
        {
            // 1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.
            Console.WriteLine($"***** Exercicio {ex} - Aula 6 *****");

            int[,] mat = new int[5, 3];

            for (int i = 0; i < mat.GetLength(0); i++) { }
            LerMatrizInt(mat, "mat");

            // Somando 10 + 1º coluna à 2º coluna da matriz
            for (int i = 0; i < mat.GetLength(0); i++)
                mat[i, 1] = mat[i, 0] + 10;

            // Duplicando o valor da 1º à 2º coluna da matriz
            for (int i = 0; i < mat.GetLength(0); i++)
                mat[i, 2] = mat[i, 0] * 2;

            MostrarMatrizInt(mat, "mat");
        }

        static void ex2(int ex)
        {
            /*
             * 2) Solicite ao usuário, preencher uma Matriz 3x3
             * 
             * Informe ao usuário:
             * *A soma dos elementos de cada linha
             * -Ex: Linha 1: 30
             * Linha 2: 17
             * *A soma dos elementos de cada coluna
             * -Ex: Coluna 1: 23
             * Coluna 2: 36
             */
            Console.WriteLine($"***** Exercicio {ex} - Aula 6 *****");

            int[,] mat = new int[3, 3];

            LerMatrizInt(mat, "mat");

            Console.WriteLine("----------------------------");

            Console.WriteLine("A soma dos elementos de cada linha ficou da seguinte maneira:");

            // Somando os elementos de cada linha
            for (int j = 0; j < mat.GetLength(0); j++)
            {
                int sumRow = 0;
                for (int i = 0; i < mat.GetLength(0); i++)
                    sumRow += mat[i, j];

                Console.WriteLine($"Linha {j + 1}: {sumRow}");
            }
            Console.WriteLine("----------------------------");

            Console.WriteLine("Soma dos elementos de cada coluna ficou da seguinte maneira:");

            // Somando os elementos de cada coluna
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                int sumCol = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                    sumCol += mat[i, j];

                Console.WriteLine($"Coluna {i + 1}: {sumCol}");
            }

            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex3(int ex)
        {
            // 3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
            Console.WriteLine($"***** Exercicio {ex} - Aula 7 *****");
            
            int[,] mat = new int[4, 4];

            LerMatrizInt(mat, "mat");

            Console.WriteLine($"Essa é a sua diagonal principal: {DiagonalPrincipal(mat)}");
        }

        static void ex4(int ex)
        {
            /*
             * 4) Popule uma matriz 5x5 e informe:
             * -Quantos números são pares
             * -Quantos números são impares
             * -Quantos números são positivos
             * -Quantos números são negativos
             * -Quantos zeros existem!
             */
            Console.WriteLine($"***** Exercicio {ex} - Aula 7 *****");

            int[,] mat = new int[5, 5];
            int par = 0, impar = 0, positivo = 0, negativo = 0, zero = 0;

            for (int i = 0; i < mat.GetLength(0); i++)
                LerMatrizInt(mat, "mat");


            
            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    _ = mat[i, j] % 2 == 0 ? 
                        par++ :
                        impar++; // Verificando se o valor digitado na posição do vetor é impar ou par
                    if (mat[i, j] > 0)
                        positivo++; // Verificando se o valor digitado na posição do vetor é maior que zero
                    else if (mat[i, j] < 0) 
                        negativo++; // Verificando se o valor digitado na posição do vetor é menor que zero
                    else if (mat[i, j] == 0)
                        zero++; // Verificando se o valor digitado na posição do vetor é igual à zero
                }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Esses são os resultados que foram inseridos no vetor:");
            Console.WriteLine($"Números pares: {par}");
            Console.WriteLine($"Números impares: {impar}");
            Console.WriteLine($"Números maiores que 0: {positivo}");
            Console.WriteLine($"Números menores que 0: {negativo}");
            Console.WriteLine($"Números 0: {zero}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex5(int ex)
        {
            /*
             * 5) Leia duas matrizes 2x3 de números double. 
             * Imprima a soma destas duas matrizes.
             */
            Console.WriteLine($"***** Exercicio {ex} - Aula 7 *****");

            double[,] mat1 = new double[2, 3], mat2 = new double[2, 3], sumMat = new double[2, 3];

            // Lendo a 1º matriz
            LerMatrizDouble(mat1, "mat1");

            // Lendo a 2º matriz
            LerMatrizDouble(mat2, "mat2");

            // Somando os valores
            for (int i = 0; i < sumMat.GetLength(0); i++)
                for (int j = 0; j < sumMat.GetLength(1); j++)
                    sumMat[i, j] = mat1[i, j] + mat2[i, j];

            MostrarMatrizDouble(sumMat, "sumMat");
        }

        static void ex6(int ex)
        {
            /*
             * 6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
             * Random random = new Random();
             * int randomNumber = random.Next(0, 100);
             */
            Console.WriteLine($"***** Exercicio {ex} - Aula 7 *****");

            int[,] mat = new int[4, 4];
            int maior = 0;
            Random rdm = new Random();

            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(1); j++)
                    mat[i, j] = rdm.Next(0, 9);

            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(0); j++)
                    _ = mat[i, j] > maior
                        ? maior = mat[i, j] 
                        : j++;
                

            Console.WriteLine("----------------------------");
            Console.WriteLine($"O maior número da mat é o: {maior}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void LerMatrizInt(int[,] matriz, string strMatriz)
        {
            // Lê os valores das linhas na matriz desejada
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                { 
                    Console.Write($"Insira um numero para {strMatriz}[{i}, {j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void MostrarMatrizInt(int[,] matriz, string strMatriz)
        {
            Console.WriteLine("----------------------------");

            // Mostra a Matriz desejada
            Console.WriteLine($"A matriz {strMatriz} ficou da seguinte maneira:");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"[ {matriz[i, j]} ]");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void LerMatrizDouble(double[,] matriz, string strMatriz)
        {
            // Lê os valores das linhas na matriz desejada
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Insira um numero para {strMatriz}[{i}, {j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void MostrarMatrizDouble(double[,] matriz, string strMatriz)
        {
            Console.WriteLine("----------------------------");

            // Mostra a Matriz desejada
            Console.WriteLine($"A matriz {strMatriz} ficou da seguinte maneira:");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                    Console.Write($"[ {matriz[i, j]} ]");
                Console.Write("\n");
            }

            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static string DiagonalPrincipal(int[,] matriz) 
        {
            string digPrincipal = "";
            // Mostra a diagonal principal
            for (int i = 0; i < matriz.GetLength(0); i++)
                digPrincipal += $"[{matriz[i, i]}]";

            return digPrincipal;
        }
    }
}