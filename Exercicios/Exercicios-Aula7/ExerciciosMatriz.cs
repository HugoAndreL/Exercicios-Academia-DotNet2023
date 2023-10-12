using System;

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
            Console.WriteLine($"Essa é a sua diagonal principal: {DiagonalPrincipal(mat)}");
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

            int[,] a = new int[4, 4], b = new int[4, 4], c = new int[4, 4];

            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex11(int ex) { }

        static void ex12(int ex) { }

        static void ex13(int ex) { }

        static void ex14(int ex) { }

        static void ex15(int ex) { }

        static void ex16(int ex) { }

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
                {
                    Console.Write($"[ {matriz[i, j]} ]");
                }
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