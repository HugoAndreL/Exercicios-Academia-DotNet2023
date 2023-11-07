namespace ExerciciosAulaAbstrata_e_Interfaces.Classes
{
    // Classe abstrata Veiculo
    internal abstract class Veiculo
    {
        public string Marca { get; set; }
        public int Modelo { get; set; }

        // Método abstrato Dirigir
        public abstract void Dirigir();
    }

    // Classes derivadas, Carro e Moto, que herdam de Veiculo
    class Carro : Veiculo
    {
        // Propriedade adicional QuantidadeDePortas
        public int QuantidadeDePortas { get; set; }

        // Método Dirigir na classe Carro
        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo o {Marca} {Modelo} com {QuantidadeDePortas} portas");
        }
    }

    class Moto : Veiculo
    {
        // Propriedade adicional Cilindrada
        public int Cilindrada { get; set; }

        // Método Dirigir na classe Moto
        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo a {Marca} {Modelo} com {Cilindrada} cilindradas");
        }
    }
}
