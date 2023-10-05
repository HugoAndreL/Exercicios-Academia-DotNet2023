namespace Exercicios_Aula1
{
    internal class Program
    {
        static void Main()
        {
            // Comentário //
            // 1) Faça um cálculo entre 2 valores com soma, subtração, multiplicação e divisão 
            Console.WriteLine("***** Exercício 1 - Aula 1 *****");
            // Declaração
            double num1, num2;
            // Comando
            Console.WriteLine("Digite o primeiro valor:");
            // Atribuição
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(
                "Digite o operador:" + // Concatenação 1
                "\nObs: + = Soma;" + // Pulo de Linha \n
                "\n - = Subtração" +
                "\n * = Multiplicação" +
                "\n / = Divisão"
            );
            // Declaração + Atribuição + Comando
            char op = char.Parse(Console.ReadLine());
            double math = 0;
            // Controle de Fluxo | Swicth
            switch (op)
            {
                case '+':
                    math = num1 + num2;
                    break;
                case '-':
                    math = num1 - num2;
                    break;
                case '*':
                    math = num1 * num2;
                    break;
                case '/':
                    math = num1 / num2;
                    break;
            };
            Console.WriteLine("------------------------------");
            Console.WriteLine($"A operação do número {num1} com o operador {op} ao número {num2} equivale à: {math}"); // Concatenação 2
            Console.WriteLine("----- Fim do Exercício -----\n");

            // 2) Converta um valor de Fahrenheit para Celsius
            Console.WriteLine("***** Exercício 2 - Aula 1 *****");
            float fahrenheit, convert;
            Console.WriteLine("Digite o valor em Fahrenheit:");
            fahrenheit = float.Parse(Console.ReadLine());
            convert = (fahrenheit - 32) / 1.8f;
            Console.WriteLine($"A conversão do número {fahrenheit} de Fahrenheit para Celsius é: {convert}");
            Console.WriteLine("----- Fim do Exercício -----");
        }
    }
}
