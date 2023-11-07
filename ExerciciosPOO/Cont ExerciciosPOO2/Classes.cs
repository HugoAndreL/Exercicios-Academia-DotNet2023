using System.ComponentModel;
using System.Runtime.InteropServices;
using static Cont_ExerciciosPOO2.Classes;

namespace Cont_ExerciciosPOO2
{
    internal class Classes
    {
        // Fabricante e Produto
        public class Fabricante
        {
            // Propriedades Nome, Endereco e Cidade
            public string Nome { get; set; }
            public string Endereco { get; set; }
            public string Cidade { get; set; }

            public Fabricante() {} // Lista para projeto futuro

            // Constructor para ficar mais facil
            public Fabricante(string Nome, string Endereco, string Cidade)
            {
                this.Nome = Nome;
                this.Endereco = Endereco;
                this.Cidade = Cidade;
            }

            // Método que sobrescreve o método to string para ficar mais facil
            public override string ToString()
            {
                return $"{Nome}, {Endereco}, {Cidade}";
            }
        }

        public class Produto
        {
            // Atibutos Nome e Preço
            private string _nome;
            private double _preco;

            // Encapsulamento Nome, Fabricante (objeto da classe Fabricante) e Preco
            public string Nome 
            {
                get { return _nome; }
                set 
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("Não foi possivel obter o nome");
                        _nome = "*";
                    }
                    else _nome = value;
                }
            }

            public Fabricante Fabricante { get; set; }

            public double Preco
            {
                get { return _preco; }
                set
                {
                    if (_preco < 0)
                    {
                        Console.WriteLine("O Preço deve ser maior que zero!");
                        _preco = 0.00;
                    }
                    else _preco = value;
                }
            }

            // Lista para projeto futuro
            public Produto() { } 

            // Método para ler o produto
            public void LerProd(Fabricante fabricante)
            {
                Console.Write("Digite um nome para o Produto: ");
                Nome = Console.ReadLine();
                Console.Write("Insira um preco para o Produto: ");
                Preco = double.Parse(Console.ReadLine());
                Fabricante = fabricante;
            }

            // Método para mostrar o produto
            public void MostrarProd()
            {
                Console.WriteLine("\n" +
                    $"[ {this} ]");
            }

            // Método que sobrescreve o método ToString para ficar mais facil exibir
            public override string ToString()
            {
                return $"{Nome} | {Fabricante} | {Preco}";
            }
        }

        // Livro
        public class Livro
        {
            // Atributos titulo e autor
            private string _titulo;
            private string _autor;

            // Propriedades Titulo e Autor
            public string Titulo {
                get { return _titulo; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value)) 
                    {
                        Console.WriteLine("Não foi possivel obter o titulo");
                        _titulo = "*";
                    }
                    else _titulo = value;
                }
            }

            public string Autor 
            {
                get { return _autor; }
                set 
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("Não foi possivel obter o autor");
                        _autor = "*";
                    }
                    else _autor = value;
                } 
            }

            // Método para ler os dados do livro
            public void LerLivro()
            {
                Console.Write("Digite o titulo do livro: ");
                Titulo = Console.ReadLine();
                Console.Write("Digite o autor do livro: ");
                Autor = Console.ReadLine();
            }

            // Método que sobrescreve o método ToString para ficar mais facil exibir
            public override string ToString()
            {
                return $"{Titulo}, {Autor}";
            }

        }

        // Animal
        public class Animal
        {
            // Propiedades Nome, Especie e Idade
            public string Nome { get; set; }
            public string Especie { get; set; }
            public int Idade { get; set; }

            // Constructor para ter o acesso mais facil
            public Animal(string nome, string especie, int idade)
            {
                Nome = nome;
                Especie = especie;
                Idade = idade;
            }

            // Método EmitirSom
            public void EmitirSom()
            {
                if (Especie == "Cachorro")
                    Console.WriteLine($"{Especie} faz: Auh!");
                else if (Especie == "Gato")
                    Console.WriteLine($"{Especie} faz: Miaû!");
                else if (Especie == "Passaro")
                    Console.WriteLine($"{Especie} faz: Pew!");
            }
        }

        // Carro
        public class Carro
        {
            // Atributos modelo, ano e velocidade
            public string modelo;
            public DateOnly year;
            public int veloc;

            // Método que acelera o carro
            public void AceleraCarro()
            {
                veloc += 10;
                Console.WriteLine("Voce está agora em " + veloc + "Km");
            }

            public void FrearCarro()
            {
                if (veloc == 0 || veloc == 10)
                    Console.WriteLine("Não é possivel frear o carro porque você já está em velocidade baixa!");
                else
                {
                    veloc -= 10;
                    Console.WriteLine("Voce está agora em " + veloc + "Km");
                }
            }

            // Método para ler o Carro
            public void LerCarro()
            {
                Console.Write("Digite o modelo do carro: ");
                modelo = Console.ReadLine();
                Console.Write("Insira a data do carro para pegarmos o ano (01, 01, YYYY): ");
                year = DateOnly.Parse(Console.ReadLine());
                Console.Write("Insira a velocidade do carro: ");
                veloc = int.Parse(Console.ReadLine());
            }

            // Método que sobrescreve o método ToString para ficar mais facil exibir
            public override string ToString()
            {
                return $"{modelo}, {year.Year}, {veloc}Km";
            }
        }

        // Agenda
        public class Agenda
        {
            private string _nome;
            private int _idade;
            private float _altura;
            private List<Agenda> _agenda;

            public Agenda() 
            {
                _agenda = new List<Agenda>();
            }

            public string Nome
            {
                get { return _nome; }
                set { _nome = value; }
            }

            public int Idade
            {
                get { return _idade; }
                set { _idade = value; }
            }

            public float Altura
            {
                get { return _altura; }
                set { _altura = value; }
            }

            // Método armazenaPessoa
            public void armazenaPessoa(string nome, int idade, float altura)
            {
                Console.WriteLine();
                Agenda agTmp = new();
                agTmp.Nome = nome;
                agTmp.Idade = idade;
                agTmp.Altura = altura;
                _agenda.Add(agTmp);
                Console.WriteLine("Armazenado com sucesso!");
                Console.WriteLine();
            }

            // Método removePessoa
            public void removePessoa(string nome)
            {
                Console.WriteLine();
                Agenda find = _agenda.Find(delegate (Agenda ag) { return ag.Nome == nome; });
                if (find != null)
                {
                    Console.WriteLine("Apagando Agenda de: " + find.Nome);
                    _agenda.Remove(find);
                    Console.WriteLine("Agenda deletado com sucesso!");
                }
                else Console.WriteLine("Agenda não encontrada!");
                Console.WriteLine();
            }

            // Método buscaPessoa
            public void buscaPessoa(string nome)
            {
                Console.WriteLine();
                Agenda find = _agenda.Find(delegate (Agenda ag) { return ag.Nome == nome; });
                if (find != null)
                    Console.WriteLine("Pessoa Encontrada: " + find);
                else Console.WriteLine("Agenda não encontrada!");
                Console.WriteLine();
            }
            
            // Método imprimeAgenda
            public void imprimeAgenda()
            {
                Console.WriteLine();
                if (_agenda.Count != 0) 
                {   
                    foreach(Agenda ag in _agenda)
                        Console.WriteLine(ag);
                }
                else Console.WriteLine("Lista não contem nada");
                Console.WriteLine();
            }

            internal void LerPessoa()
            {
                Console.WriteLine();
                Console.Write("Digite o seu nome: ");
                Nome = Console.ReadLine();

                Console.Write("Insira a sua idade: ");
                Idade = int.Parse(Console.ReadLine());

                Console.Write("Insira a sua altura: ");
                Altura = float.Parse(Console.ReadLine());
                
            }

            public override string ToString()
            {
                return $"[ {Nome}; {Idade}; {Altura} ]";
            }
        }

    }
}
