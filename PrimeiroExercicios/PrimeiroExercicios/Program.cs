namespace PrimeiroExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Comentário //
            // 1. Exercício
            Console.WriteLine("***** 1. Primeiro Exercício *****");
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
            Console.WriteLine("Especifique o operador.");
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
            Console.WriteLine("---------------------------");
            Console.WriteLine($"A operação do número {num1} com o operador {op} ao número {num2} equivale à: {math}");
            Console.WriteLine("----- Fim do Exercício 1 -----");

            // 2. Exercício
            Console.WriteLine("***** 2. Segundo Exercício *****");
            float fahrenheit, convert;
            Console.WriteLine("Digite o valor em Fahrenheit:");
            fahrenheit = float.Parse(Console.ReadLine());
            convert = (fahrenheit - 32) / 1.8f;
            Console.WriteLine($"A conversão do número {fahrenheit} de Fahrenheit para Celsius é: {convert}");
        }
    }
}