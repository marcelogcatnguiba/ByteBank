
namespace ByteBank.Entities
{
    internal class ContaCorrente
    {
        public Titular Titular { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; } 
        public double Saldo { get ; private set; }
        public static int TotalContas { get; private set; }

        // Construtores - Constructor
        public ContaCorrente()
        {
            Saldo = 100;
            TotalContas++;
        }
        public ContaCorrente(Titular titular, int agencia, int conta, double saldo) : this()
        {
            Titular = titular;
            Agencia = agencia;
            Conta = conta;
        }
        // Methods - Metodos
        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Não possivel atribuir saldo negativo.");
            }
            else
            {
                Saldo = valor;
            }
        }
        public double GetSaldo()
        {
            return Saldo;
        }
        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public bool Saque(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;
            }
        }

        public void Tranferencia(double valor, ContaCorrente conta)
        {
            bool teste = Saque(valor);
            if(teste == true)
            {
                conta.Deposito(valor);
            }
        }
        // End Methods - Fim Metodos

        // ToString override
        public override string ToString()
        {
            return $"Titular: {Titular.Nome} \n" +
                   $"CPF: {Titular.Cpf} \n" +
                   $"Profissão: {Titular.Profissao} \n" +
                   $"Agencia: {Agencia} \n" +
                   $"Conta: {Conta} \n" +
                   $"Saldo: {Saldo} \n";
        }

    }
}
