using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Exercicios_Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
            Console.WriteLine("***** Exercício 1 - Aula 2 *****");
            int val1Ex1, val2Ex1;
            float mediaEx1;
            Console.WriteLine("Digite o primeiro valor:");
            val1Ex1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            val2Ex1 = int.Parse(Console.ReadLine());
            mediaEx1 = (val1Ex1 + val2Ex1) / 2;
            Console.WriteLine($"O valor da média desejada é {mediaEx1}");
            Console.WriteLine("----- Fim do Exercício -----\n");

            // 2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.
            Console.WriteLine("***** Exercício 2 - Aula 2 *****");
            int val1Ex2, val2Ex2, val3Ex2, val4Ex2;
            float mediaEx2;
            Console.WriteLine("Digite o primeiro valor:");
            val1Ex2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            val2Ex2 = int.Parse(Console.ReadLine()); ;
            Console.WriteLine("Digite o terceiro valor:");
            val3Ex2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto valor:");
            val4Ex2 = int.Parse(Console.ReadLine());
            mediaEx2 = (val1Ex2 + val2Ex2 + val3Ex2 + val4Ex2) / 4;
            Console.WriteLine($"A média dos 4 valores é {mediaEx2}");
            Console.WriteLine("----- Fim do Exercício -----\n");

            /*
             * 3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
             * si os valores de duas variáveis A e B.
             */
            Console.WriteLine("***** Exercício 3 - Aula 2 *****");
            string A, B, tempA, tempB;
            Console.WriteLine("Digite a primeira sequencia para ser amarzenada na variável A");
            A = Console.ReadLine();
            Console.WriteLine("Digite a segunda sequencia para ser amarzenada na variavel B");
            B = Console.ReadLine();
            tempA = A;
            tempB = B;
            A = tempB;
            B = tempA;
            Console.WriteLine($"Variavel A: {A} e Variavel B: {B}");
            Console.WriteLine("----- Fim do Exercício -----\n");

            /*
             * 4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
             * forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.
             */
            Console.WriteLine("***** Exercício 4 - Aula 2 *****");
            DateOnly dat = new(2023, 10, 03);
            string convert = $"{dat.Year.ToString().Substring(2)}/{dat.Month.ToString()}/{dat.Day.ToString("00")}";
            Console.WriteLine($"Data padrão: {dat}; \n" +
                $"Data convertida: {convert}");
            Console.WriteLine("----- Fim do Exercício -----\n");

            /*
             * 5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
             * (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
             * consumido para percorrê-la (medido em l).
             */
            Console.WriteLine("***** Exercício 5 - Aula 2 *****");

            /*
             * 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
             * isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem
             * de IPI(única) a ser acrescentada.
             */
            Console.WriteLine("***** Exercício 6 - Aula 2 *****");
            Console.WriteLine("***** Exercício 7 - Aula 2 *****");
            Console.WriteLine("***** Exercício 8 - Aula 2 *****");
            Console.WriteLine("***** Exercício 9 - Aula 2 *****");
            Console.WriteLine("***** Exercício 10 - Aula 2 *****");




        }
    }
}