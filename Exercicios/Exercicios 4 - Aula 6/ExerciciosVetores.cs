using System.Net;

namespace Exercicios_Aula_6
{
    internal class ExerciciosVetores
    {
        static void Main(string[] args)
        {
            while (true)
            {
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
                        ex1("***** Exercicio 1 - Aula 6 *****");
                        break;
                    case 2:
                        ex2("***** Exercicio 2 - Aula 6 *****");
                        break;
                    case 3:
                        ex3("***** Exercicio 3 - Aula 6 *****");
                        break;
                    case 4:
                        ex4("***** Exercicio 4 - Aula 6 *****");
                        break;
                    case 5:
                        ex5("***** Exercicio 5 - Aula 6 *****");
                        break;
                    case 6:
                        ex6("***** Exercicio 6 - Aula 6 *****");
                        break;
                    case 7:
                        ex7("***** Exercicio 7 - Aula 6 *****");
                        break;
                    case 8:
                        ex8("***** Exercicio 8 - Aula 6 *****");
                        break;
                    case 9:
                        ex9("***** Exercicio 9 - Aula 6 *****");
                        break;
                    case 10:
                        ex10("***** Exercicio 10 - Aula 6 *****");
                        break;
                    case 11:
                        ex11("***** Exercicio 11 - Aula 6 *****");
                        break;
                    case 12:
                        ex12("***** Exercicio 12 - Aula 6 *****");
                        break;
                    case 13:
                        ex13("***** Exercicio 13 - Aula 6 *****");
                        break;
                    case 14:
                        ex14("***** Exercicio 14 - Aula 6 *****");
                        break;
                    case 15:
                        ex15("***** Exercicio 15 - Aula 6 *****");
                        break;
                    case 16:
                        ex16("***** Exercicio 16 - Aula 6 *****");
                        break;
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

        static void ex1(string msg)
        {
            // 1.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.
            Console.WriteLine(msg);

            int[] v = new int[10];
            int n, par = 0, impar = 0;

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine($"Insira o valor para o vetor[{i}]:");
                n = int.Parse(Console.ReadLine());
                v[i] = n;

                if (v[i] % 2 == 0)
                    par++;
                else impar++;
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine($"Quantidade de números pares: {par}\n" +
                $"Quantidade de números impares: {impar}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex2(string msg)
        {
            // 2.	Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.
            Console.WriteLine(msg);

            int sum = 0;
            int[] v1 = new int[20], v2 = new int[20], v3 = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Insira um valor para o v1[{i}]:");
                v1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Insira um valor para o v2[{i}]:");
                v2[i] = int.Parse(Console.ReadLine());

                sum = v1[i] + v2[i];
                v3[i] = sum;

                Console.WriteLine($"A soma do valores de {v1[i]} e {v2[i]} é: {v3[i]}");
            }

            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex3(string msg)
        {
            // 4.	Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.
            Console.WriteLine(msg);

            int mult;
            int[] v1 = new int[10], v2 = new int[10], v3 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Insira um valor para o v1[{i}]:");
                v1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Insira um valor para o v2[{i}]:");
                v2[i] = int.Parse(Console.ReadLine());

                mult = v1[i] * v2[i];
                v3[i] = mult;

                Console.WriteLine($"A multiplicação do valores de {v1[i]} e {v2[i]} é: {v3[i]}");
            }

            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex4(string msg)
        {
            // 4.	Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.
            Console.WriteLine(msg);

            int mult;
            int[] v1 = new int[10], v2 = new int[10], v3 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Insira um valor para o v1[{i}]:");
                v1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Insira um valor para o v1[{i + 1}]:");
                v1[i + 1] = int.Parse(Console.ReadLine());

                mult = v1[i] * v1[i + 1];
                v3[i] = mult;

                Console.WriteLine($"A multiplicação do valores de {v1[i]} e {v2[i]} é: {v3[i]}");
            }

            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex5(string msg)
        {
            // 5.Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.
            Console.WriteLine(msg);

            int[] v = new int[80];
            int menor = int.MaxValue;

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine($"Insira o valor para o v[{i}]:");
                v[i] = int.Parse(Console.ReadLine());

                if (v[i] < menor)
                    menor = v[i];
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Menor valor: {menor}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }
        
        static void ex6(string msg)
        {
            /*
             * 6.	Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
             * a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
             * b.	escreve: 	|22|7|31|63|0|21|9|3|40|7|
             * |2|4|6|8|10|12|14|16|18|20|
             * |20|18|16|14|12|10|8|6|4|2|
             */
            Console.WriteLine(msg);

            int[] v = new int[10];
            string str = "|", strInversa = "|";

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine($"Insira o valor para v[{i}]:");
                v[i] = int.Parse(Console.ReadLine());

                str += $"{v[i]}|";
            }

            for (int j = 9; j > -1; j--)
                strInversa += $"{v[j]}|";

            Console.WriteLine("----------------------------");
            Console.WriteLine($"{str}\n" +
                $"{strInversa}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }
        
        static void ex7(string msg)
        {
            /*
             * 7.	Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
             * a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
             * b.	escreve: 	|40|0|22|7|3|9|21|63|31|7|
             */
            Console.WriteLine(msg);

            int[] n = new int[10];
            string par = "", impar = "|", order;

            for (int i = 0; i < n.Length; i++)
            {
                Console.Write($"Insira o {i + 1}º valor: ");
                n[i] = int.Parse(Console.ReadLine());

                if (n[i] % 2 == 0)
                    par += $"|{n[i]}";
                else
                    impar += $"{n[i]}|";
            }

            order = par + impar;

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Ordem em par e impar: {order}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }
        
        static void ex8(string msg)
        {
            /*
             * 8.	Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor. Exemplo:
             * a.	lê:          	|5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
             * b.	escreve: 	|3|5|6|7|9|10|14|. . .
             */
            Console.WriteLine(msg);

            double[] v = new double[30];

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"Insira o {i + 1} número: ");
                v[i] = double.Parse(Console.ReadLine());
            }
            // Fazer
        }
        
        static void ex9(string msg)
        {
            // 9.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.
            Console.WriteLine(msg);

            int[] v = new int[10];

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"Insira o {i + 1} número: ");
                v[i] = int.Parse(Console.ReadLine());
            }
            // Fazer
        }

        static void ex10(string msg)
        {
            // 10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.
            Console.WriteLine(msg);

            /* 
             * ?
             * Permite Nulo
             */
            int[]? v = new int[20], v2 = new int[20];
            string order = "|", order2 = "|";

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"Insira o {i + 1}º número: ");
                v[i] = int.Parse(Console.ReadLine());

                if (v[i] == 0)
                    v2[i] = 2;
                else v2[i] = v[i];

                order += $"{v[i]}|";
                order2 += $"{v2[i]}|";
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Vetor Lido: {order}\n" +
                $"Vetor Resultado: {order2}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex11(string msg)
        {
            // Escreva um programa que leia valores em um vetor de 5 posições. Escrever os elementos do vetor e após escrever os elementos na ordem inversa.
            Console.WriteLine(msg);

            int[] v = new int[5];
            string str = "|", strInversa = "|";

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine($"Insira o valor para v[{i}]:");
                v[i] = int.Parse(Console.ReadLine());

                str += $"{v[i]}|";
            }

            for (int j = 4; j > -1; j--)
                strInversa += $"{v[j]}|";

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Elementos digitados: {str}\n" +
                $"Elementos na ordem inversa: {strInversa}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex12(string msg)
        {
            // 12.	Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor. Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".
            Console.WriteLine(msg);

            int[] v = new int[10];
            int nVerificar;
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o valor do vetor v[{i}]: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("----------------------------");

            Console.Write("Digite um número para verificar se existe no vetor: ");
            nVerificar = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (v[i] != nVerificar)
                    Console.WriteLine($"O número {nVerificar} não existe no vetor!");
                else
                    Console.WriteLine($"O número {nVerificar} foi encontrado na(s) posição(s) {i} do vetor.");
            }

            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex13(string msg)
        {
            // 13.	Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2, 4 e 8. O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1 ou quando atingir o máximo de posições do vetor.
            Console.WriteLine(msg);

            int[] v = new int[5];
            int contador2 = 0, contador4 = 0, contador8 = 0;

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"Número {i + 1}: ");
                v[i] = int.Parse(Console.ReadLine());

                if (v[i] == -1)
                    break;

                if (v[i] == 2)
                    contador2++;
                else if (v[i] == 4)
                    contador4++;
                else if (v[i] == 8)
                    contador8++;
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Resultados:");
            Console.WriteLine($"Quantidade de vezes que o número 2 aparece: {contador2}");
            Console.WriteLine($"Quantidade de vezes que o número 4 aparece: {contador4}");
            Console.WriteLine($"Quantidade de vezes que o número 8 aparece: {contador8}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex14(string msg)
        {
            // 14.	Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números. Se o código for zero, termine o algoritmo. Se o código for 1, mostre o vetor na ordem em que foi lido. Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.
            Console.WriteLine(msg);

            int cod;
            int[] v = new int[50];
            string str = "|", strInversa = "|";

            Console.Write("Insira o código (0 - para sair; 1 - Ordem que foi lido; 2 - Ordem inversa): ");
            cod = int.Parse(Console.ReadLine());

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"Insira o valor para v[{i}]: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            if (cod == 0)
                return;
            else if (cod == 2)
                for (int j = 4; j > -1; j--)
                    strInversa += $"{v[j]}|";
            else if (cod == 1)
                for (int i = 0; i < v.Length; i++)
                    str += $"{v[i]}|";

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Ordem desejada: {(cod == 2 ? strInversa : str)}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex15(string msg)
        {
            // 15.	Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, e copie estes conteúdos para outro vetor, invertendo sua ordem. Assim, o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo. Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.
            Console.WriteLine(msg);

            int[] v1 = new int[20], v2 = new int[20];
            string str = "|", strInversa = "|";

            for (int i = 0; i < v1.Length; i++)
            {
                Console.Write($"Insira o valor para v[{i}]: ");
                v1[i] = int.Parse(Console.ReadLine());
            }

            // Copia os conteúdos invertendo a ordem
            for (int i = 0; i < 20; i++)
                v2[i] = v1[v2.Length - i];

            for (int i = 0; i < v1.Length; i++)
                str += $"{v1[i]}|";

            for (int i = 0; i < v2.Length; i++)
                strInversa += $"{v2[i]}|";

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Vetor Normal: {str}\n" +
                $"Vetor em ordem inversa: {strInversa}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex16(string msg)
        {
            /*
             * 16.	Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um vetor para cada uma das operações:
             * •	A união de X com Y
             * •	A diferença entre X e Y
             * •	A interseção entre X e Y
             * Escreva o vetor resultado de cada uma das operações.
             */
            Console.WriteLine(msg);

            int[] x = new int[10], y = new int[10],
                uniao = new int[20], dif = new int[10], inter = new int[10];
            string strUniao = "|", strDif = "|", strInter = "|";

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Insira um valor para x[{i}]: ");
                x[i] = int.Parse(Console.ReadLine());

                Console.Write($"Insira um valor para y[{i}]: ");
                y[i] = int.Parse(Console.ReadLine());

                uniao[i] = x[i];
                uniao[i + 10] = y[i];

                for (int j = 0; j < 10; j++)
                {
                    if (x[i] != y[j])
                        dif[i] = x[i];
                    else
                    {
                        inter[i] = x[i];
                        break;
                    }
                }

                strUniao += $"{uniao[i]}|";
                strDif += $"{dif[i]}|";
                strInter += $"{inter[i]}|";
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Vetor União: {strUniao}\n" +
                $"Vetor Diferença: {strDif}\n" +
                $"Vetor Interceção: {strInter}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }
    }
}