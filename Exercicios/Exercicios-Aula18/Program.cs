namespace Exercicios_Aula18
{
    internal class Program
    {
        static int[] vet = new int[10];

        static void Main(string[] args)
        {
            while (true)
            {
                // Opção de escolha
                Console.WriteLine("Selecione um Exercicio (Digite apenas o número do exercicio):\n" +
                    "-------------------------\n" +
                    "1 = Exercicio 1 - Aula 18\n" +
                    "2 = Exercicio 2 - Aula 18\n" +
                    "3 = Exercicio 3 - Aula 18\n" +
                    "4 = Exercicio 4 - Aula 18\n" +
                    "5 = Exercicio 5 - Aula 18\n" +
                    "6 = Exercicio 6 - Aula 18\n" +
                    "7 = Exercicio 7 - Aula 18\n" +
                    "8 = Exercicio 8 - Aula 18\n" +
                    "9 = Exercicio 9 - Aula 18\n" +
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
            // 1) Fazer uma calculadora das 4 operações (soma, subtração, multiplicação e divisão) Para isso, precisaremos aceitar números com vírgula.
            Console.WriteLine($"***** Exercicio {ex} - Aula 18 *****");

            Console.Write("Escolha o sua opreação (+: Soma, -: Subtração, *: Multiplicação, / - Divisão): ");
            char op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"O resultado da soma é: {CalcularSum()}");
                    break;
                case '-':
                    Console.WriteLine($"O resultado da subtração é: {CalcularSub()}");
                    break;
                case '*':
                    Console.WriteLine($"O resultado da multiplicação é: {CalcularMult()}");
                    break;
                case '/':
                    Console.WriteLine($"O resultado da divisão é: {CalcularDiv()}");
                    break;
            }
        }

        static double CalcularSum()
        {
            double n1, n2, res;
            
            Console.Write("Insira o valor de 1º número: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor de 2º número: ");
            n2 = double.Parse(Console.ReadLine());

            res = n1 + n2;

            return res;
        }

        static double CalcularSub()
        {
            double n1, n2, res;
            
            Console.Write("Insira o valor de 1º número: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor de 2º número: ");
            n2 = double.Parse(Console.ReadLine());

            res = n1 - n2;

            return res;
        }

        static double CalcularMult()
        {
            double n1, n2, res;
            
            Console.Write("Insira o valor de 1º número: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor de 2º número: ");
            n2 = double.Parse(Console.ReadLine());

            res = n1 * n2;

            return res;
        }

        static double CalcularDiv()
        {
            double n1, n2, res;
            
            Console.Write("Insira o valor de 1º número: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor de 2º número: ");
            n2 = double.Parse(Console.ReadLine());

            res = n1 / n2;

            return res;
        }

        static void ex2(int ex)
        {
            // 2) Fazer programa que tenha duas funções. i) para ler um vetor de 10 elementos (variável global) e ii) para verificar e apresentar a quantidade de elementos pares que este vetor possui.
            Console.WriteLine($"***** Exercicio {ex} - Aula 18 *****");
            LerVet();
            Console.WriteLine($"Quantos numeros pares encontrado neste vetor: {éPar()}");
        }

        static void LerVet()
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($"Insira um valor para o vetor[{i}]: ");
                vet[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------");
            }
        }

        static int éPar()
        {
            int par = 0;

            for (int i = 0; i < vet.Length; i++)
                if (vet[i] % 2 == 0)
                    par++;

            return par;
        }

        static void ex3(int ex)
        {
            // 3) Desenvolva uma função que calcule a média de três números fornecidos como argumentos.
            Console.WriteLine($"***** Exercicio {ex} - Aula 18 *****");
            double n1 = 0, n2 = 0, n3 = 0;

            Console.Write("Insira o 1º valor: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Insira o 2º valor: ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Insira o 3º valor: ");
            n3 = double.Parse(Console.ReadLine());

            Media3Elementos(n1, n2, n3);
        }

        static void Media3Elementos(double n1, double n2, double n3)
        {
            double res;

            res = (n1 + n2 + n3) / 3;
            Console.WriteLine($"Média dos 3 valores: {res}");
        }

        static void ex4(int ex)
        {
            // 4) Escreva uma função que calcule o fatorial de um número inteiro positivo.
            Console.WriteLine($"***** Exercicio {ex} - Aula 18 *****");
            Fatorial();
        }

        static void Fatorial()
        {
            int fat = 1;
            Console.WriteLine("Insira o número para ser fatorado:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                fat *= i;
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"O fatorial de {n} é {fat}");
        }

        static void ex5(int ex)
        {
            // 5) Desenvolva uma função que converta uma temperatura em graus Celsius para Fahrenheit.
            Console.WriteLine($"***** Exercicio {ex} - Aula 18 *****");
            CelsiusFahrenheit();
        }

        static void CelsiusFahrenheit()
        {
            double celcius, convert;
            Console.Write("Digite o valor em Fahrenheit: ");
            celcius = double.Parse(Console.ReadLine());
            convert = (celcius * 5 / 9) + 32;
            Console.WriteLine($"A conversão é: {convert}º");
        }

        static void ex6(int ex)
        {
            // 6) Escreva uma função que calcule a média de um vetor de 10 números.
            Console.WriteLine($"***** Exercicio {ex} - Aula 18 *****");
            Media10Elementos();
        }

        static void Media10Elementos()
        {
            double[] vet = new double[10];
            double res, sum = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($"Insira o {i + 1}º Valor: ");
                vet[i] = double.Parse(Console.ReadLine());
                sum += vet[i];
                Console.WriteLine("---------------------------------");
            }

            res = sum / vet.Length;

            Console.WriteLine($"A média dos 10 elementos escolhidos é: {res}");
        }

        static void ex7(int ex)
        {
            // 7) Crie uma função que determine se um número é primo ou não.
            Console.WriteLine($"***** Exercicio {ex} - Aula 18 *****");
            Console.WriteLine(NumeroPrimo());
        }

        static string NumeroPrimo()
        {
            Console.Write("Insira um número: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 1)
                return "Não é primo.";

            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return "Não é primo.";

            return "É primo.";
        }

        static void ex8(int ex)
        {
            // 8) Ler um número inteiro e passar por parâmetro para uma função e retornar 0, se o número é par, ou 1, se o número é ímpar.
            Console.WriteLine($"***** Exercicio {ex} - Aula 18 *****");

            Console.Write("Insira um número: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(ParImpar(n));
        }

        static string ParImpar(int numero)
        {
            string retorno = numero % 2 == (double)0 ? "É Par." : "É impar.";
            return retorno;
        }

        static void ex9(int ex)
        {
            // 9) Escrever um programa com uma função que receba por parâmetro dois números (n1 e n2) e retorna a soma dos números inteiros que existem entre n1 e n2 (inclusive ambos). Apresente o resultado na main.
            Console.WriteLine($"***** Exercicio {ex} - Aula 18 *****");

            Console.Write("Escreva o 1º numero: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Escreva o 2º numero: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Sum(n1, n2));
        }

        static string Sum(int n1, int n2)
        {
            double res = n1 + n2;
            return $"A soma entre {n1} e {n2} é: {res}";
        }

        static void Desafio()
        {
            // Desafio: Ler um vetor de inteiros com 10 elementos e passar por parâmetro para uma função que verifica e retorna o menor elemento do vetor.

        }
    }
}