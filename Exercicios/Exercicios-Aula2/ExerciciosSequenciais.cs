using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace Exercicios_Aula2
{
    internal class ExerciciosSequenciais
    {
        static void Main(string[] args)
        {
            bool exit = false;
            
            while (!exit)
            {
                Console.WriteLine("Selecione um Exercicio: (Digite apenas o número do exercicio)\n" +
                "-------------------------\n" +
                "1 = Exercicio 1 - Aula 2\n" +
                "2 = Exercicio 2 - Aula 2\n" +
                "3 = Exercicio 3 - Aula 2\n" +
                "4 = Exercicio 4 - Aula 2\n" +
                "5 = Exercicio 5 - Aula 2\n" +
                "6 = Exercicio 6 - Aula 2\n" +
                "7 = Exercicio 7 - Aula 2\n" +
                "8 = Exercicio 8 - Aula 2\n" +
                "9 = Exercicio 9 - Aula 2\n" +
                "10 = Exercicio 10 - Aula 2\n" +
                "11 = Exercicio 11 - Aula 2\n" +
                "12 = Exercicio 12 - Aula 2\n" +
                "13 = Exercicio 13 - Aula 2\n" +
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
                    case 8:
                        ex8();
                        break;
                    case 9:
                        ex9();
                        break;
                    case 10:
                        ex10();
                        break;
                    case 11:
                        ex11();
                        break;
                    case 12:
                        ex12();
                        break;
                    case 13:
                        ex13();
                        break;
                }
                Console.WriteLine("Deseja limpar o console: (true - Sim; false - Não)");
                bool cls = bool.Parse(Console.ReadLine());
                if (cls == true)
                    Console.Clear();
                else
                {
                    Console.Write("\n");
                    Console.WriteLine($"Retornando à pagina de navegação.\n");
                }
            }
        }

        static void ex1()
        {
            // 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
            Console.WriteLine("***** Exercício 1 - Aula 2 *****");
            Console.WriteLine("Efetuar a média de 2 valores");

            int val1Ex1, val2Ex1;
            float mediaEx1;

            Console.WriteLine("Insira o primeiro valor:");
            val1Ex1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            val2Ex1 = int.Parse(Console.ReadLine());

            mediaEx1 = (val1Ex1 + val2Ex1) / 2;

            Console.WriteLine("----------------------------");
            Console.WriteLine($"O valor da média desejada é {mediaEx1}");
            Console.WriteLine("----- Fim do Exercício -----\n");
        }

        static void ex2()
        { 
            // 2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.
            Console.WriteLine("***** Exercício 2 - Aula 2 *****");
            Console.WriteLine("Efetuar a média de 4 valores");

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

            Console.WriteLine("----------------------------");
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
            Console.WriteLine("Troque o valores de A e B");

            string A, B, tempA, tempB;

            Console.WriteLine("Digite a primeira sequencia para ser amarzenada na variável A");
            A = Console.ReadLine();

            Console.WriteLine("Digite a segunda sequencia para ser amarzenada na variavel B");
            B = Console.ReadLine();

            tempA = A;
            tempB = B;

            A = tempB;
            B = tempA;

            Console.WriteLine("----------------------------");
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
            Console.WriteLine("Converter a data em formato AAAA/MM/DD em AA/MM/DD");

            DateOnly dat = new(2023, 10, 03);

            string convert = $"{dat.Year.ToString().Substring(2)}/{dat.Month.ToString()}/{dat.Day.ToString("00")}";

            Console.WriteLine("----------------------------");
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

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Esse é seu consumo médio: {conMedio}Km/l");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }
        
        static void ex6()
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

            Console.WriteLine("----------------------------");
            // Parafuso B
            Console.WriteLine("Insira o código do parafuso B:");
            codB = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de quantidade de peças para o parafuso B:");
            quantPecasB = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do parafuso B:");
            valB = double.Parse(Console.ReadLine());
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }
        
        static void ex7()
        {
            /*
             * 7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
             * o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
             * Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.
             */
            Console.WriteLine("***** Exercicio 7 - Aula 2 *****");
            Console.WriteLine("Ler um vendedor e Calcular o salario total do vendedor");

            int numVend, totalVend;
            double salVend, salTotal;
            float percent, comissao;

            Console.WriteLine("Insira o numero do vendedor:");
            numVend = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o numero do salario do vendedor:");
            salVend = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o numero de total de vendas efetuados pelos vendedor:");
            totalVend = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do percentual (em %) do vendedor:");
            percent = int.Parse(Console.ReadLine());

            comissao = (percent / 100) * totalVend;
            salTotal = salVend + comissao;

            Console.WriteLine("----------------------------");
            Console.WriteLine("Vendedor\n" +
                $"Número do Vendedor: {numVend}\n" +
                $"Salario total: R${salTotal},00");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex8()
        {
            /*
             * 8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
             * A fórmula da conversão é F=(9*C+160)/5.
             */
            Console.WriteLine("***** Exercicio 8 - Aula 2 *****");
            Console.WriteLine("Conversão de celsius para fahrenheit");

            float celsius, convert;

            Console.WriteLine("Digite o valor em Celsius:");
            celsius = float.Parse(Console.ReadLine());

            convert = (9 * celsius + 160) / 5;

            Console.WriteLine("----------------------------");
            Console.WriteLine($"A conversão do número {celsius} de celsius para Fahrenheit é: {convert}");
            Console.WriteLine("----- Fim do Exercício -----\n");
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

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Valor de Entrada: {entrada}\n" +
                $"Valor das 3 Prestações: {prestacao}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex10()
        {
            /*
             * 10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo
             * para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que
             * realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as
             * notas de menor valor fossem distribuídas em número mínimo possível.
             * Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
             * uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00.
             * Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas
             * de acordo com o critério da “distribuição ótima”.
             */
            Console.WriteLine("***** Exercicio 10 - Aula 2 *****");
            Console.WriteLine("Distribuição Ótima");

            int valTotal;

            Console.WriteLine("Insira o valor ao qual deseja retirar:");
            valTotal = int.Parse(Console.ReadLine());

            int[] notas = { 200, 100, 50, 20, 10, 5, 2, 1 }, quantNotas = new int[notas.Length];

            for (int i = 0; i < notas.Length; i++)
            {
                quantNotas[i] = valTotal / notas[i];
                valTotal %= notas[i];
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("A Distribuição de notas ficará da seguinte forma:");
            for (int i = 0; i < quantNotas.Length; i++)
                if (quantNotas[i] > 0) Console.WriteLine($"{quantNotas[i]} Nota(s) de {notas[i]} reais");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex11()
        {
            /*
             * 11) Escreva um algoritmo para ler o número de eleitores de um município,
             * o número de votos brancos, nulos e válidos. 
             * Calcule e escreva o percentual que cada um representa em relação ao total de eleitores.
             */
            Console.WriteLine("***** Exercicio 11 - Aula 2 *****");
            Console.WriteLine("Calculo de percentuais em uma votação");

            int numEleitores, numWhite, numNull, numValid;
            float percentNull, percentWhite, percentValid;
            
            Console.WriteLine("Insira o número de eleitores:");
            numEleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número de votos brancos:");
            numWhite = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número de votos nulos:");
            numNull = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número de votos validos:");
            numValid = int.Parse(Console.ReadLine());

            percentWhite = (float)numWhite / numEleitores * 100;
            percentNull = (float)numNull / numEleitores * 100;
            percentValid = (float)numValid / numEleitores * 100;

            Console.WriteLine("----------------------------");
            Console.WriteLine("Resultados da Eleição:\n" +
                $"Número de eleitores: {numEleitores}\n" +
                $"Votos em branco: {numWhite} ({percentWhite}%)\n" +
                $"Votos nulos: {numNull}  ({percentNull}%)\n" +
                $"Votos válidos: {numValid}  ({percentValid}%)");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex12()
        {
            /*
             * 12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
             * marcação do odômetro(marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total(R$) recebido
             * dos passageiros.Calcule e escreva a média do consumo em Km / l e o lucro líquido do dia.
             * 
             * Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 
             *
             * Média do consumo = Total quilometragem/ quantidade de combustível gasto
             *
             * Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)
             */
            Console.WriteLine("***** Exercicio 12 - Aula 2 *****");
            Console.WriteLine("Calculo de média de combustivel");

            float kmInicio, kmFinal,
                l;
            double val, valComb = 6.90,
                media, lucro;

            Console.WriteLine("Insira o valor do odômetro, no início do dia:");
            kmInicio = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do odômetro, no final do dia:");
            kmFinal = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de litros do combustivel:");
            l = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor total recebido pelo passageiro:");
            val = float.Parse(Console.ReadLine());

            media = (float)(kmFinal - kmInicio) / l;
            lucro = (float)val - l * valComb;

            Console.WriteLine("------------------------------");
            Console.WriteLine("Rendimento de seu Carro:\n" +
                $"Média do consumo em Km/l: {media}Km/l\n" +
                $"Lucro líquido do dia: R${lucro},00");
            Console.WriteLine($"----- Fim do Exercicio -----\n");
        }

        static void ex13()
        {
            /*
             * 13) Uma loja vende bicicletas com um acréscimo de 50 % sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15 % sobre o
             * preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas
             * vendidas pelo vendedor, calcule e mostre: o salário do empregado
             */
            Console.WriteLine("***** Exercicio 13 - Aula 2 *****");
            Console.WriteLine("Calculo de Salario");

            double salMinimo, valBike, comissao = 0.15,
                salEmp;
            int numVend;

            Console.WriteLine("Insira o valor do salário mínimo:");
            salMinimo = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o preço de custo de cada bicicleta:");
            valBike = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número de bicicletas vendidas pelo vendedor");
            numVend = int.Parse(Console.ReadLine());

            salEmp = (2 * salMinimo) + (numVend * comissao);

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Salário do Vendedor: {salEmp}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }
    }
}