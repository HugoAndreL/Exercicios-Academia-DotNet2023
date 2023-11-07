namespace ExerciciosAulaAbstrata_e_Interfaces.Classes
{
    // Classe abstrata Produto
    internal abstract class Produto
    {
        // Propriedades Nome, Preço
        public string Nome { get; set; }
        public double Preco { get; set; }

        // Método abstrato CalcularDesconto
        public abstract void CalcularDesconto();
    }

    // Classes Livro e Eletrônico
    class Livro : Produto
    {
        // Calcular Desconto com 5% de desconto
        public override void CalcularDesconto()
        {
            double desconto = Preco * 5 / 100;
            double valFinal = Preco - desconto;
            Console.WriteLine("Valor final do produto: " + valFinal);
        }
    }

    class Eletronico : Produto
    {
        // Calcular Desconto com 12.5% de desconto
        public override void CalcularDesconto()
        {
            double desconto = Preco * 12.5 / 100;
            double valFinal = Preco - desconto;
            Console.WriteLine("Valor final do produto: " + valFinal);
        }
    }
}
