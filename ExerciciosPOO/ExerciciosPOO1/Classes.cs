using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Exercicio1POO
{
    internal class Pessoa
    {
        public string nome;
        public int idade;
        public string cpf;
        public DateOnly datNasc;
        public string rg;

        public void CasdastrarPessoa() 
        {
            Console.Write("Digite o nome da pessoa: ");
            nome = Console.ReadLine();

            Console.Write("Insira a idade da pessoa: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o CPF da pessoa: ");
            cpf = Console.ReadLine();

            Console.Write("Digite a data de nascimento da pessoa neste formato (AAAA, MM, DD): ");
            datNasc = DateOnly.Parse(Console.ReadLine());

            Console.Write("Digite o RG da pessoa: ");
            rg = Console.ReadLine();
        }

        public void MostrarPessoa()
        {
            Console.WriteLine("\n" +
                "Nome da pessoa: " + nome + ";\n" +
                "Idade da pessoa: " + idade + ";\n" +
                "CPF da pessoa: " + cpf + ";\n" +
                "Data de Nacimento da pessoa: " + datNasc + ";\n" +
                "RG da pessoa: " + rg + ".\n");
        }
    }

    internal class Aluno
    {
        public string nome;
        public string ensino;
        public string status;
        public string escola;

        public Aluno(string nome, string ensino, string status, string escola)
        {
            this.nome = nome;
            this.ensino = ensino;
            this.status = status;
            this.escola = escola;
        }

        public void MostrarAluno()
        {
            Console.WriteLine("\n" +
                "Nome do aluno: " + nome + ";\n" +
                "Ensino do aluno: " + ensino + ";\n" +
                "Status do aluno: " + status + ";\n" +
                "Escola do aluno: " + escola + ".\n");
        }
    }

    internal class Personagem
    {
        public string nome;
        public int vida;
        public int posicao;
        public int itemColetados;

        public Personagem(string nome, int vida, int posicao, int itemColetados)
        {
            this.nome = nome;
            this.vida = vida;
            this.posicao = posicao;
            this.itemColetados = itemColetados;
        }

        public void Atacar(double atkRecebido)
        {
            Console.WriteLine("Você foi atacado!");
            Console.WriteLine("O dano recebido foi de: " + atkRecebido + ".");
            Console.WriteLine("Você está agora com: " + (vida - atkRecebido) + ".\n");
        }

        public void Movimentar(int dir)
        {
            string moviment = "";
            if (dir == 1)
                moviment = "Frente";
            else if (dir == 2)
                moviment = "Trás";
            else if (dir == 3)
                moviment = "Direta";
            else if (dir == 4)
                moviment = "Esquerda";
            Console.WriteLine("\nO personagem irá se movimentar para a: " + moviment + ".");
        }
    }

    internal class Livro
    {
        public string title;
        public string autor;
        public int pages;
        public string cat;
        public bool emprestado = false;

        public Livro(string title, string autor, int pages, string cat)
        {
            this.title = title;
            this.autor = autor;
            this.pages = pages;
            this.cat = cat;
        }

        public void Emprestar()
        {
            emprestado = true;
        }

        public void Devolver()
        {
            emprestado = false;
        }
    }
}
