using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Exercicios_Aula2
{
    internal class ExerciciosSelecao
    {
        static void Main()
        {
            while (true)
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
                    case 14:
                        ex14();
                        break;
                    case 15:
                        ex15();
                        break;
                    case 16:
                        ex16();
                        break;
                    case 17:
                        ex17();
                        break;
                    case 18:
                        ex18();
                        break;
                    case 19:
                        ex19();
                        break;
                    case 20:
                        ex20();
                        break;
                    case 21:
                        ex21();
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

        static void ex1() 
        {
            /*
             * 1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
             * Área do triangulo = (base * altura) / 2; 
             * Teste se a base ou a altura digitada não foi igual a zero.
             */
            Console.WriteLine("***** Exercicio 1 - Aula 3 *****");

            float b, a, area;

            Console.WriteLine("Insira a base do triangulo:");
            b = float.Parse(Console.ReadLine());


            Console.WriteLine("Insira a altura do triangulo:");
            a = float.Parse(Console.ReadLine());

            if (b < 0 || a < 0)
                Console.WriteLine("Não foi possivel efetuar a area do trinagulo");
            
            area = (b * a) / 2;

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Area do triangulo: {area}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex2() 
        {
            // 2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.
            Console.WriteLine("***** Exercicio 2 - Aula 3 *****");

            int num;
            string verificar;

            Console.WriteLine("Insira um número:");
            num = int.Parse(Console.ReadLine());

            verificar = num % 2 == 0 ? "par" : "impar";

            Console.WriteLine("----------------------------");
            Console.WriteLine($"O seu número é {verificar}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex3() 
        {
            // 3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.
            Console.WriteLine("***** Exercicio 3 - Aula 3 *****");

            int n1, n2, n3, n4;
            float media;
            
            Console.WriteLine("Insira o primeiro número:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro número:");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o quarto número:");
            n4 = int.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Média dos valores desejados: {media}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex4() 
        {
            /*
             * 4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
             * Mostrar na tela qual dos professores tem o maior salário total.
             */
            Console.WriteLine("***** Exercicio 4 - Aula 3 *****");

            float time1, time2;
            double sal1, sal2, valHora1, valHora2;
            string maior;

            Console.WriteLine("Insira a hora neste formato (HH.MM.SS) dada pelo primeiro professor:");
            time1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor por hora recebido pelo primeiro professor:");
            valHora1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira a hora neste formato (HH.MM.SS) dada pelo segundo professor:");
            time2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor por hora recebido pelo segundo professor:");
            valHora2 = double.Parse(Console.ReadLine());

            sal1 = time1 * valHora1;
            sal2 = time2 * valHora2;

            if (sal1 > sal2)
                maior = "O primeiro tem maior salario";
            else maior = "O segundo tem o maior salario";
            Console.WriteLine("----------------------------");
            Console.WriteLine(maior);
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex5() 
        {
            /*
             * 5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
             * se a média das duas notas for maior ou igual a 7,0.
             * 
             * Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
             * é a média entre a nota do exame e a média das 2 notas. 
             * Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
             * escrever “Reprovado”.
             */
            Console.WriteLine("***** Exercicio 5 - Aula 3 *****");

            float nota1, nota2, notaF, media, mediaF;
            string status;

            Console.WriteLine("Insira a primeira nota do aluno:");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota do aluno:");
            nota2 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media >= 7.0)
                status = "Aprovado";
            else
            {
                status = "Recuperação";

                Console.WriteLine("Insira a nota do exame final do aluno:");
                notaF = float.Parse(Console.ReadLine());

                mediaF = notaF + media;
                if (mediaF >= 5.0)
                {
                    status = "Aprovado";
                } 
                else
                {
                    status = "Reprovado";
                }
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"O aluno está {status}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex6() 
        {
            /*
             * 6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
             * O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
             * O cálculo do imc = peso / (altura * altura)
             *
             * IMC 
             * menor que 18                -> baixo peso
             * maior que 18 e menor que 25 -> peso normal
             * maior que 25 e menor que 30 -> sobrepeso
             * maior que 30 e menor que 35 -> obesidade
             * maior que 35                -> obesidade grau sério
             */
            Console.WriteLine("***** Exercicio 6 - Aula 3 *****");

            string nome, status, imcStatus;
            float altura, peso, imc;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            nome = nome.ToUpper();

            Console.WriteLine("Insira a sua altura:");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o seu peso:");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18)
                status = "Baixo peso";
            else if (imc > 18 && imc < 25)
                status = "Peso normal";
            else if (imc > 25 && imc < 30)
                status = "Sobrepeso";
            else if (imc > 30 && imc < 35)
                status = "Obesidade";
            else status = "Obesidade grau sério";


            Console.WriteLine("----------------------------");
            Console.WriteLine($"O peso de {nome} é: {imc} => {status}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex7() 
        {
            /*
             * 7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
             * O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
             * exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.
             */
            Console.WriteLine("***** Exercicio 7 - Aula 3 *****");

            string txt, search;

            Console.WriteLine("Digite um texto qualquer");
            txt = Console.ReadLine();

            Console.WriteLine("Digite uma palavra para pesquisa");
            search = Console.ReadLine();

            Console.WriteLine("----------------------------");
            if (txt.Contains(search))
                Console.WriteLine("A palavra encontra-se na frase.");
            else Console.WriteLine("A palavra não se encontra na frase.");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex8() 
        {
            /*
             * 8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
             * Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
             * Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
             * E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
             * total de vendas.
             */
            Console.WriteLine("***** Exercicio 8 - Aula 3 *****");

            int cod, vend;
            string nome;
            double salBase, salFinal;

            Console.WriteLine("Insira o código de um funcionario:");
            cod = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do funcionario:");
            nome = Console.ReadLine();

            Console.WriteLine("Insira o salario do funcionario:");
            salBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o total de vendas desse funcionario:");
            vend = int.Parse(Console.ReadLine());

            salFinal = salBase;
            if (vend > 500)
                salFinal += vend * 0.5;
            else if (vend > 1000)
                salFinal += vend * 0.7;
            else if (vend > 5000)
                salFinal += vend * 0.10;

            Console.WriteLine("---------------------------");
            Console.WriteLine($"Código do funcionário: {cod}\n" +
                $"Nome do funcionário: {nome}\n" +
                $"Salário base: R$ {salBase},00" +
                $"Salário final: R$ {salFinal},00");
            Console.WriteLine("----- Fim do Programa -----\n");
        }

        static void ex9() 
        {
            /*
             * 9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
             * diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
             * Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
             * Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.
             * 
             * 
             * Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
             * menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
             * 150, avisá-lo que será necessário adicionar 2 unidades de insulina.
             */
            Console.WriteLine("***** Exercicios 9 - Aula 3 *****");

            float jejum1, jejum2, jejum3;
            string risco;

            Console.WriteLine("Insira a primeira glicemia em jejum:");
            jejum1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insura a segunda glicemia em jejum:");
            jejum2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira a terceira glicemia em jejum:");
            jejum3 = float.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------");
            if (jejum1 < 65)
                Console.WriteLine("1º dia: Risco de hipoglicemia");
            else if (jejum1 > 250)
                Console.WriteLine("1º dia: Risco de hiperglicemia");
            
            Console.WriteLine("----------------------------");
            if (jejum2 < 65)
                Console.WriteLine("2º dia: Risco de hipoglicemia");
            else if (jejum2 > 250)
                Console.WriteLine("2º dia: Risco de hiperglicemia");

            Console.WriteLine("----------------------------");
            if (jejum3 < 65)
                Console.WriteLine("2º dia: Risco de hipoglicemia");
            else if (jejum3 > 250)
                Console.WriteLine("2º dia: Risco de hiperglicemia");

            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex10() 
        {
            /*
             * 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
             * O programa deve mostrar os dados do atleta mais novo e mais alto.
             */
            Console.WriteLine("***** Exercicio 10 - Aula 3 *****");

            string nome1, nome2;
            int idade1, idade2;
            float altura1, altura2;

            Console.WriteLine("Digite o nome do 1º atleta:");
            nome1 = Console.ReadLine();

            Console.WriteLine("insira a idade do 1º atleta:");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a altura do 1º atleta:");
            altura1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o nome do 2º atleta:");
            nome2 = Console.ReadLine();

            Console.WriteLine("Insira a idade do 2º atleta:");
            idade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a altura do 1º atleta:");
            altura2 = float.Parse(Console.ReadLine());

            if (idade1 < idade2)
                Console.WriteLine($"Atleta mais novo: {nome1}, Idade: {idade1} anos");
            else if (idade2 < idade1)
                Console.WriteLine($"Atleta mais novo: {nome2}, Idade: {idade2} anos");
            else
                Console.WriteLine("Os dois atletas têm a mesma idade.");

            if (altura1 > altura2)
                Console.WriteLine($"Atleta mais alto: {nome1}, Altura: {altura1} metros");
            else if (altura2 > altura1)
                Console.WriteLine($"Atleta mais alto: {nome2}, Altura: {altura2} metros");
            else
                Console.WriteLine("Os dois atletas têm a mesma altura.");

            Console.WriteLine("----- Fim do Programa -----\n");
        }

        static void ex11()
        {
            /*
             * 11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
             * O programa deve exibir se a hora digitada está ou não válida. 
             * Lembre que usaremos o padrão de hora com 24h, de 0 a 23.
             */
            Console.WriteLine("***** Exercicio 11 - Aula 3 *****");

            int h, m;
            bool validaHora, validaMinutos;

            Console.WriteLine("Digite a hora (0 a 23):");
            h = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os minutos (0 a 59):");
            m = int.Parse(Console.ReadLine());

            validaHora = h >= 0 && h <= 23;
            validaMinutos = m >= 0 && m <= 59;

            if (validaHora && validaMinutos)
                Console.WriteLine("Hora válida.");
            else
                Console.WriteLine("Hora inválida.");

            Console.WriteLine("----- Fim do Programa -----\n");
        }

        static void ex12() 
        {
            /*
             * 12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
             * número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
             * R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
             * armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
             * No final do processamento, exibir o salário total e o salário excedente do operário.
             */
            Console.WriteLine("***** Exercicio 12 - Aula 3 *****");
            
            int codigo;
            float numeroHoras;
            double salHora = 10.0, salTotal, extra = 0;

            Console.WriteLine("Insira o código do operário:");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número de horas trabalhadas:");
            numeroHoras = float.Parse(Console.ReadLine());

            salTotal = numeroHoras * salHora;
            if (numeroHoras > 50)
            {
                extra = (numeroHoras - 50) * 20.0;
                numeroHoras = 50;
            }

            salTotal += extra;

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Código do operário: {codigo}");
            Console.WriteLine($"Salário total: R$ {salTotal:F2}");
            Console.WriteLine($"Salário excedente: R$ {extra:F2}");
            Console.WriteLine("----- Fim do Programa -----\n");
        }

        static void ex13()
        {

        }

        static void ex14()
        {

        }

        static void ex15()
        {

        }

        static void ex16()
        {

        }

        static void ex17()
        {

        }

        static void ex18()
        {

        }

        static void ex19()
        {

        }

        static void ex20()
        {

        }

        static void ex21()
        {

        }
    }
}
