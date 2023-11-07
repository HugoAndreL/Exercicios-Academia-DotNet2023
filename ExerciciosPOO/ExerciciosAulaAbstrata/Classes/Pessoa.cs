namespace ExerciciosAulaAbstrata_e_Interfaces.Classes
{
    // Classe abstrata Pessoa
    internal abstract class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public abstract void Apresentar();
    }

    // Classe Aluno que herda de Pessoa
    class Aluno : Pessoa
    {
        public string Matricula { get; set; }

        public override void Apresentar() 
        {
            Console.WriteLine($"{Nome}, {Idade}, {Matricula}");
        }
    }

    // Classe Professor que herda de Pessoa
    class Professor : Pessoa 
    {
        public string Disciplina { get; set; }

        public override void Apresentar() {
            Console.WriteLine($"{Nome}, {Idade}, {Disciplina}");
        }
    }
}
