namespace ExerciciosAulaAbstrata_e_Interfaces.Classes
{
    // Classe abstrata ContaBancaria
    internal abstract class ContaBanc
    {
        // Propriedades Saldo
        public double Saldo { get; set; }

        // Métodos abstratos Depositar e Sacar
        public abstract void Depositar();

        public abstract void Sacar();
    }

    // Classe ContaCorrente que herda de ContaBancaria
    class ContaCorrente : ContaBanc
    {
        public override void Depositar()
        {
            Console.WriteLine("Qual o valor que deseja depositar na Conta Corrente: ");
            double valor = double.Parse(Console.ReadLine());
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R${valor} realizado na sua conta corrente!");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido!");
            }
        }

        public override void Sacar()
        {
            Console.WriteLine("Qual o valor que deseja sacar na Conta Corrente: ");
            double valor = double.Parse(Console.ReadLine());
            if (valor > 0 && Saldo - valor >= 0)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado na conta corrente!");
            }
            else
            {
                Console.WriteLine("Valor de saque inválido ou saldo insuficiente!");
            }
        }
    }

    // Classe ContaPoupanca que herda de ContaBanc
    class ContaPoupanca : ContaBanc
    {
        public override void Depositar()
        {
            Console.WriteLine("Qual o valor que deseja depositar na Conta Poupança: ");
            double valor = double.Parse(Console.ReadLine());
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R${valor} realizado na conta poupança!");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido!");
            }
        }

        public override void Sacar()
        {
            Console.WriteLine("Qual o valor que deseja sacar na Conta Poupança: ");
            double valor = double.Parse(Console.ReadLine());
            if (valor > 0 && Saldo - valor >= 0)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado na conta poupança!");
            }
            else
            {
                Console.WriteLine("Valor de saque inválido ou saldo insuficiente!");
            }
        }
    }
}
