using Design_Pattern.PatternSingleton;

namespace Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual padrão você gostaria de comecar:\n" +
                "1 - Padrão Sigleton\n" +
                "2 - Padrão Factory Method\n" +
                "3 - Padrão Abstract Factory Method\n" +
                "4 - Padrão Facade\n" +
                "5 - Padrão Chain of Responsability\n" +
                "6 - Padrão Template Method\n" +
                "7 - Padrão Observer");
            int op = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;

            switch (op)
            {
                case 1:
                    Console.WriteLine("##### Padrão Sigleton #####");
                    Console.ResetColor();
                    PatternSingleton();
                    break;
                case 2:
                    Console.WriteLine("##### Padrão Factory Method #####");
                    Console.ResetColor();
                    PatternFactoryMethod();
                    break;
                case 3:
                    Console.WriteLine("##### Padrão Abstract Factory Method #####");
                    Console.ResetColor();
                    PatternAbstractFactoryMethod();
                    break;
                case 4:
                    Console.WriteLine("##### Padrão Facade #####");
                    Console.ResetColor();
                    PatternFacade();
                    break;
                case 5:
                    Console.WriteLine("##### Padrão Chain of Responsability #####");
                    Console.ResetColor();
                    PatternChainResponsability();
                    break;
                case 6:
                    Console.WriteLine("##### Padrão Template Method #####");
                    Console.ResetColor();
                    PatternTemplateMethod();
                    break;
                case 7:
                    Console.WriteLine("##### Padrão Observer #####");
                    Console.ResetColor();
                    PatternObserver();
                    break;
            }
        }

        private static void PatternObserver()
        {
            throw new NotImplementedException();
        }

        private static void PatternTemplateMethod()
        {
            throw new NotImplementedException();
        }

        private static void PatternChainResponsability()
        {
            throw new NotImplementedException();
        }

        private static void PatternFacade()
        {
            throw new NotImplementedException();
        }

        private static void PatternAbstractFactoryMethod()
        {
            throw new NotImplementedException();
        }

        private static void PatternFactoryMethod()
        {
            throw new NotImplementedException();
        }

        private static void PatternSingleton()
        {
            Console.WriteLine();
            /* O Singleton é um padrão de projeto criacional que permite a você garantir que uma classe tenha apenas uma instância, enquanto provê um ponto de acesso global para essa instância.
             * Ex: O governo é um excelente exemplo de um padrão Singleton. Um país pode ter apenas um governo oficial. Independentemente das identidades pessoais dos indivíduos que formam governos, o título, “O Governo de X”, é um ponto de acesso global que identifica o grupo de pessoas no command. 
             */
            // Tentando criar uma instancia
            Console.WriteLine("Criando a primeira instancia.");
            Singleton s1 = Singleton.GetInstance();

            Console.WriteLine();

            // Tentando criar outra instancia
            // Como não é possivel criar outra instancia, essa instancia não é criada
            Console.WriteLine("Criando a segunda instancia.");
            Singleton s2 = Singleton.GetInstance();

            // Como os dois singleton são sempre iguais, sempre cairá no if
            if (s1 == s2) Console.WriteLine("Existem somente uma instancia.");
            else Console.WriteLine("Existem instancias diferentes");
        }
    }
}
