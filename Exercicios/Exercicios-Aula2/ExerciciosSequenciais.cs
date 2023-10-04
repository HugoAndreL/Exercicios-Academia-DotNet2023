namespace Exercicios_Aula2
{
    internal class ExerciciosSequenciais
    {
        static void Main(string[] args)
        {
            
            ex1();
            ex2();
            ex3();
            ex4();
            ex5();
            ex8();
            ex9();
            //ex10();
            //ex11();
            //ex12();
            //ex13();
        }

        static void ex1()
        {
            // 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
            Console.WriteLine("***** Exercício 1 - Aula 2 *****");
            Console.WriteLine("");
            int val1Ex1, val2Ex1;
            float mediaEx1;
            Console.WriteLine("Digite o primeiro valor:");
            val1Ex1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            val2Ex1 = int.Parse(Console.ReadLine());
            mediaEx1 = (val1Ex1 + val2Ex1) / 2;
            Console.WriteLine($"O valor da média desejada é {mediaEx1}");
            Console.WriteLine("----- Fim do Exercício -----\n");
        }

        static void ex2()
        { 
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
            Console.WriteLine($"A média dos 4 valores desejados é {mediaEx2}");
            Console.WriteLine("----- Fim do Exercício -----\n");
        }

        static void ex3()
        {
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
        }

        static void ex4()
        {
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
        }

        static void ex5()
        {
            /*
             * 5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
             * (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
             * consumido para percorrê-la (medido em l).
             */
            Console.WriteLine("***** Exercicio 5 - Aula 2 *****");
            Console.WriteLine("Cacular o consumo médio de um automóvel pela distância total e volume de combustível");
            float disTotal, volComb, conMedio;
            Console.WriteLine("Insira o valor da distância total percorrida pelo veiculo:");
            disTotal = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do volume de combustivel:");
            volComb = float.Parse(Console.ReadLine());
            conMedio = disTotal / volComb;
            Console.WriteLine($"Esse é seu consumo médio: {conMedio}Km/l ");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }
        
        static void ex8()
        {
            /*
             * 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
             * isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem
             * de IPI(única) a ser acrescentada.
             */
            Console.WriteLine("***** Exercício 6 - Aula 2 *****");
            Console.WriteLine("Ler os dados de 2 parafusos");
            int codA, quantPecasA, codB, quantPecasB;
            double valA, valB;

            // Parafuso A
            Console.WriteLine("Insira o código do parafuso A:");
            codA = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de quantidade de peças para o parafuso A:");
            quantPecasA = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do parafuso A:");
            valA = double.Parse(Console.ReadLine());

            // Parafuso B
            Console.WriteLine("Insira o código do parafuso B:");
            codB = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de quantidade de peças para o parafuso B:");
            quantPecasB = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do parafuso B:");
            valB = double.Parse(Console.ReadLine());
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }
        
        static void ex9()
        {
            /*
             * 9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
             *   do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis. 
             *   Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
             *   se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
             *   Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
             *   da entrada e das duas prestações, de acordo com as regras acima. 
             *   Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
             *   conseqüente pagamento dos boletos das duas prestações.
             */
            Console.WriteLine("***** Exercício 9 - Aula 2 *****");
            Console.WriteLine("Pegar o valor total e fazer prestações de 3 vezes");
            double total, entrada, prestacao, resto;
            Console.WriteLine("Insira o valor total da mercadoria:");
            total = double.Parse(Console.ReadLine());
            resto = total % 3;
            prestacao = (total - resto) / 3;
            entrada = prestacao + resto;
            Console.WriteLine($"Valor de Entrada: {entrada}\n" +
                $"Valor das 3 Prestações: {prestacao}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }
    }
}