namespace ExerciciosAulaAbstrata_e_Interfaces.Interfaces
{
    // Interface abstrata IFormaGeometrica
    internal interface IFormaGeografica
    {
        void CalcularArea();
        void CalcularPerimetro();
    }

    // Classes que implementam essa interface: "Retangulo" e "Circulo"
    public class Retangulo : IFormaGeografica
    {
        public float B { get; set; }
        public float H { get; set; }

        public void CalcularArea()
        {
            double area = B * H;
            Console.WriteLine($"A Area do retangulo é: {area}");
        }

        public void CalcularPerimetro()
        {
            double per = 2 * (B * H);
            Console.WriteLine($"O perimetro do retangulo é: {per}");
        }
    }

    public class Circulo : IFormaGeografica
    {
        public float r { get; set; }
        float pi = 3.14f;

        public void CalcularPerimetro() 
        {
            float per = (float)(2 * pi) * r;
            Console.WriteLine("O perimetro do Circulo é: " + per);
        }

        public void CalcularArea() 
        {
            float area = pi * (r * r);
            Console.WriteLine("A area do circulo é: " + area);
        }
        
    }




}
