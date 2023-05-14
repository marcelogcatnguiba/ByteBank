using ByteBank.Exceptions;
using System.Globalization;

namespace ByteBank.Entities
{
    public sealed class ContaCorrente
    {
        public int Agencia { get; private set; }
        public int Conta { get; private set; }
        public double Saldo { get; private set; } = 100;
        public static int TotalContas { get; private set; } // membros static carrega em memoria ao iniciar

        private Cliente _cliente { get; set; }
        public ContaCorrente(Cliente cliente, int agencia, int conta, double saldo)
        {
            Validate(agencia, conta, saldo);
            _cliente = cliente;
        }


        public void Deposito(double valor)
        {
            ContaCorrenteException.When(valor < 0,
                "Valor informado incorreto");

            Saldo += valor;
        }

        public void Saque(double valor)
        {
            ContaCorrenteException.When(valor > Saldo,
                "Saldo insuficiente para esta operação.");

            Saldo -= valor;
        }

        public void Tranferencia(double valor, ContaCorrente conta)
        {
            Saque(valor);
            conta.Deposito(valor);
        }

        private void Validate(int agencia, int conta, double saldo)
        {
            ContaCorrenteException.When(agencia < 0,
                "Numero de agencia invalida.");

            ContaCorrenteException.When(conta < 0,
                "Numero de conta invalida.");

            ContaCorrenteException.When(saldo < 0,
                "Saldo invalido, não pode ser negativo.");

            Agencia = agencia;
            Conta = conta;
            Saldo = saldo;
        }


        // ToString override
        public override string ToString()
        {
            return $"Titular: {_cliente.Nome} \n" +
                   $"CPF: {_cliente.Cpf} \n" +
                   $"Profissão: {_cliente.Profissao} \n" +
                   $"Agencia: {Agencia} \n" +
                   $"Conta: {Conta} \n" +
                   $"Saldo: R${Saldo.ToString("f2", CultureInfo.InvariantCulture)} \n";
        }

    }
}
