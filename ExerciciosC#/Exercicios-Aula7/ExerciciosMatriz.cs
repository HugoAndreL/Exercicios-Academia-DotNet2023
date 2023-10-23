using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace Exercicios_Aula7
{
    internal class ExerciciosMatriz
    {
        static void Main()
        {
            while (true)
            {
                // Opção de escolha
                Console.WriteLine("Selecione um Exercicio (Digite apenas o número do exercicio):\n" +
                    "-------------------------\n" +
                    "1 = Exercicio 1 - Aula 7\n" +
                    "2 = Exercicio 2 - Aula 7\n" +
                    "3 = Exercicio 3 - Aula 7\n" +
                    "4 = Exercicio 4 - Aula 7\n" +
                    "5 = Exercicio 5 - Aula 7\n" +
                    "6 = Exercicio 6 - Aula 7\n" +
                    "7 = Exercicio 7 - Aula 7\n" +
                    "8 = Exercicio 8 - Aula 7\n" +
                    "9 = Exercicio 9 - Aula 7\n" +
                    "10 = Exercicio 10 - Aula 7\n" +
                    "11 = Exercicio 11 - Aula 7\n" +
                    "12 = Exercicio 12 - Aula 7\n" +
                    "13 = Exercicio 13 - Aula 7\n" +
                    "14 = Exercicio 14 - Aula 7\n" +
                    "15 = Exercicio 15 - Aula 7\n" +
                    "16 = Exercicio 16 - Aula 7\n" +
                    "17 = Exercicio 17 - Aula 7\n" +
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
                    case 7:
                        ex7(7);
                        break;
                    case 8:
                        ex8(8);
                        break; 
                    case 9:
                        ex9(9);
                        break;
                    case 10:
                        ex10(10);
                        break;
                    case 11:
                        ex11(11);
                        break;
                    case 12:
                        ex12(12);
                        break;
                    case 13:
                        ex13(13);
                        break;
                    case 14:
                        ex14(14);
                        break;
                    case 15:
                        ex15(15);
                        break;
                    case 16:
                        ex16(16);
                        break;
                    case 17:
                        ex17(17);
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
            Console.WriteLine($"***** Exercicio {ex} - Aula 7 *****");

            int[,] mat = new int[5, 3];

            LerMatrizInt(mat);

            // Somando 10 + 1º coluna à 2º coluna da matriz
            for (int i = 0; i < mat.GetLength(0); i++)
                mat[i, 1] = mat[i, 0] + 10;

            // Duplicando o valor da 1º à 2º coluna da matriz
            for (int i = 0; i < mat.GetLength(0); i++)
                mat[i, 2] = mat[i, 0] * 2;

            MostrarMatrizInt(mat);
            Console.WriteLine("----- Fim do Exercicio -----\n");
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
            Console.WriteLine($"***** Exercicio {ex} - Aula 7 *****");

            int[,] mat = new int[3, 3];

            LerMatrizInt(mat);

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

            MostrarMatrizInt(mat);

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

            LerMatrizInt(mat);

            MostrarMatrizInt(mat);
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Essa é a sua diagonal principal: {DigPrincipal(mat)}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
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
                LerMatrizInt(mat);



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
            LerMatrizDouble(mat1);

            // Lendo a 2º matriz
            LerMatrizDouble(mat2);

            // Somando os valores
            for (int i = 0; i < sumMat.GetLength(0); i++)
                for (int j = 0; j < sumMat.GetLength(1); j++)
                    sumMat[i, j] = mat1[i, j] + mat2[i, j];

            MostrarMatrizDouble(sumMat);
            Console.WriteLine("----- Fim do Exercicio -----\n");
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

            MostrarMatrizInt(mat);
            Console.WriteLine("----------------------------");
            Console.WriteLine($"O maior número da mat é o: {maior}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex7(int ex)
        {
            // 7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.
            Console.WriteLine($"***** Execicio {ex} - Aula 7 *****");

            int[,] a = new int[3, 3], b = new int[3, 3], c = new int[3, 3];

            LerMatrizInt(a);
            LerMatrizInt(b);

            for (int i = 0; i < c.GetLength(0); i++)
                for (int j = 0; j < c.GetLength(1); j++)
                    c[i, j] = a[i, j] - a[i, j];

            MostrarMatrizInt(a);
            MostrarMatrizInt(b);
            MostrarMatrizInt(c);
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex8(int ex)
        {
            // 8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
            Console.WriteLine($"***** Exercicio {ex} - Aula 7 *****");

            int[,] mat = new int[4, 4];

            LerMatrizInt(mat);

            Console.WriteLine("----------------------------");

            MostrarMatrizInt(mat);

            Console.WriteLine("----------------------------");

            Console.WriteLine("Matriz na ordem inversa:");
            for (int i = mat.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = mat.GetLength(1) - 1; j >= 0; j--)
                    Console.Write($"[ {mat[i, j]} ]");
                Console.WriteLine();
            }

            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex9(int ex)
        {
            /*
             * 9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
             * Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.
             */ 
            Console.WriteLine($"***** Exercicio {ex} - Aula 7 *****");

            int[,] mat = new int[3, 3];
            int n;
            bool swth = false;

            LerMatrizInt(mat);

            Console.WriteLine("----------------------------");
            
            Console.Write("Insira um numero para verficar na matriz: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(1); j++)
                    _ = mat[i, j] == n 
                        ? swth = true
                        : swth = false;

            MostrarMatrizInt(mat);

            Console.WriteLine("Resultados:");
            Console.WriteLine((swth == true ? "O número existe no vetor" : "Número inesistente"));
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex10(int ex)
        {
            // 10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.
            Console.WriteLine($"***** Exercicio {ex} - Aula 7 *****");

            int[,] a = new int[4, 4], b = new int[4, 4];
            int mediaA, mediaB, sumA = 0, sumB = 0, acima = 0, abaixo = 0, mediano = 0;

            LerMatrizInt(a);
            Console.WriteLine("----------------------------");
            LerMatrizInt(b);

            // Calcular a soma do A
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sumA += a[i, j];
                }

            // Calculando a média do A
            mediaA = sumA / (a.GetLength(0) * a.GetLength(1));
            
            // Dizer se o A está abaixo, acima ou na média
            if (mediaA > 7.00 && mediaA < 11.00)
                acima++;
            else if (mediaA < 5.00)
                abaixo++;
            else mediano++;

            // Calcular a soma do B
            for (int i = 0; i < b.GetLength(0); i++)
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    sumB += b[i, j];
                }
            
            // Calculando a média do A
            mediaB = sumB / (b.GetLength(0) * b.GetLength(1));
            
            // Dizer se o B está abaixo, acima ou na média
            if (mediaB > 7.00) 
                acima++;
            else if (mediaB == 5.00)
                abaixo++;
            else mediano++;

            Console.WriteLine("----------------------------");
            Console.WriteLine("Resultados\n");
            Console.WriteLine($"Quantidade de elementos acima da média: {acima}");
            Console.WriteLine($"Quantidade de elementos abaixo da média: {abaixo}");
            Console.WriteLine($"Quantidade de elementos medianos: {mediano}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex11(int ex) 
        {
            // 11) Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.
            Console.WriteLine($"***** Exercicio {ex} - Aula 7 *****");

            double[,] mat = new double[3, 3], matRes = new double[3, 3];

            LerMatrizDouble(mat);

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                int sum = (mat.GetLength(0) + mat.GetLength(1));
                for (int j = 0; j < mat.GetLength(1); j++)
                    matRes[i, j] = mat[i, j] / sum;
            }

            Console.WriteLine("----------------------------");
            MostrarMatrizDouble(matRes);
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex12(int ex)
        {
            // 12) Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na tela apenas os valores cuja soma dos índices(i + j) seja um número par.
            Console.WriteLine($"***** Exercicio {ex} - Aula 7 *****");

            int[,] mat = new int[4, 3];

            LerMatrizInt(mat);

            Console.WriteLine("----------------------------");
            // Verificando se a soma é um numero par
            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                        Console.WriteLine($"A soma dos índices {i} + {j} é um numero par");
                }
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex13(int ex)
        {
            /* 
             * 13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da 
             * diagonal secundária.
             */
            Console.WriteLine($"***** Exercicio {ex} - Aula 7 *****");

            int[,] mat = new int[5, 5];
            int sumDigP = 0, sumDigS = 0;
            int size = mat.GetLength(0);

            LerMatrizInt(mat);

            // Calculando a soma das diagonais
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                sumDigP += mat[i, i];
                sumDigS += mat[i, size - 1 - i];
            }

            Console.WriteLine("----------------------------");
            
            // Verificando se as diagonais são igual usando if padrão
            if (sumDigP == sumDigS)
                Console.WriteLine("A soma das diagonais é igual.");
            else Console.WriteLine("A soma das diagonais não é igual.");

            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex14(int ex)
        {
            /*
             * 14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal (da esquerda para a direita)
             * são os mesmos da diagonal 
             * secundária (direita pra esquerda).
             */
            Console.WriteLine($"***** Exercicio {ex} - Aula 7 *****");

            int[,] mat = new int[5, 5];

            LerMatrizInt(mat);

            Console.WriteLine("----------------------------");

            // Verificando se as diagonais são iguais usando if ternário
            Console.WriteLine(DigPrincipal(mat) == DigSecundaria(mat) ? "As diagonais são iguais" : "As diagonais não são iguais");

            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex15(int ex)
        {
            // 15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.
            Console.WriteLine($"***** Exercicio {ex} - Aula 7 *****");

            int[,] mat1 = new int[4, 4], mat2 = new int[4, 4], matRes = new int[4, 4];

            LerMatrizInt(mat1);
            Console.WriteLine("---------------------------");
            LerMatrizInt(mat2);
            
            for (int i = 0; i < matRes.GetLength(0); i++)
                for (int j = 0; j < matRes.GetLength(1); j++)
                    matRes[i, j] = mat1[i, j] + mat2[i, j];

            MostrarMatrizInt(matRes);

            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex16(int ex)
        {
            // 16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3.Transpor uma matriz significa transformar suas linhas em colunas e vice - versa.
            Console.WriteLine($"***** Exercicio {ex} - Aula 7 *****");

            int[,] mat1 = new int[3, 4], mat2 = new int[4, 3];

            PrencherMatriz(mat1);

            // Transpondo a matriz
            for (int i = 0; i < mat1.GetLength(1); i++)
                for (int j = 0; j < mat1.GetLength(0); j++)
                    mat2[i, j] = mat1[j, i];

            MostrarMatrizInt(mat1);
            MostrarMatrizInt(mat2);
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }
        
        static void ex17(int ex)
        {
            /*
             * 17) Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax, ou seja,o menor elemento da linha onde se encontra o 
             * maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.
             */
            Console.WriteLine($"***** Exercicio {ex} - Aula 7 *****");

            int[,] mat = new int[5, 5];
            int maior = mat[0, 0], minimax, row = 0, col = 0;

            LerMatrizInt(mat);

            // Determinando a linha com maior valor
            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(1); j++)
                    if (mat[i, j] > maior)
                    {
                        maior = mat[i, j];
                        row = i;
                        col = j;
                    }

            // Determinando o menor valor desta linha
            minimax = mat[row, 0];

            for (int j = 0; j < mat.GetLength(1); j++)
                if (mat[row, j] < minimax)
                    minimax = mat[row, j];

            Console.WriteLine("----------------------------");
            Console.WriteLine($"O maior elemento da matriz é o: {maior} e o minimax desta linha é o: {minimax}, encontrado na linha: {row + 1} e coluna: {col + 1}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void LerMatrizInt(int[,] matriz)
        {
            // Lê os valores das linhas na matriz desejada
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Insira um numero para matriz desejada na linha {i + 1}, coluna {j + 1}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void MostrarMatrizInt(int[,] matriz)
        {
            Console.WriteLine("----------------------------");

            // Mostra a Matriz desejada
            Console.WriteLine($"A matriz desejada ficou da seguinte maneira:");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                    Console.Write($"[ {matriz[i, j]} ]");
                Console.WriteLine();
            }
        }

        static void LerMatrizDouble(double[,] matriz)
        {
            // Lê os valores das linhas na matriz desejada
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Insira um numero para matriz desejada na linha {i + 1}, coluna {j + 1}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void MostrarMatrizDouble(double[,] matriz)
        {
            Console.WriteLine("----------------------------");

            // Mostra a Matriz desejada
            Console.WriteLine($"A matriz desejada ficou da seguinte maneira:");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                    Console.Write($"[ {matriz[i, j]} ]");
                Console.Write("\n");
            }
        }

        static string DigPrincipal(int[,] matriz)
        {
            string digPrincipal = "";

            // Mostra a diagonal principal
            for (int i = 0; i < matriz.GetLength(0); i++)
                digPrincipal += $"[ {matriz[i, i]} ]";

            return digPrincipal;
        }

        static string DigSecundaria(int[,] matriz)
        {
            string digSecudaria = "";

            // Mostra a diagonal secundaria
            for (int i = matriz.GetLength(0) - 1; i >= 0; i--)
                digSecudaria += $"[ {matriz[i, ((matriz.GetLength(0) - 1) - i)]} ]";

            return digSecudaria;
        }
        
        static void PrencherMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Random rdm = new Random();
                    matriz[i, j] = rdm.Next(0, 100);
                }
                
        }
    }
}