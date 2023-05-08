using System.Globalization;
using System.Net.Http.Headers;
using ByteBank.Entities;
using ByteBank.Exceptions;

namespace ByteBank.Entities
{
    internal sealed class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; private set; }
        public int Conta { get; private set; }
        public double Saldo { get; private set; } = 100;
        public static int TotalContas { get; private set; } // membros static carrega em memoria ao iniciar


        public ContaCorrente(Cliente titular, int agencia, int conta, double saldo)
        {
            Validate(agencia, conta, saldo);
            Titular = titular;
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

            ContaCorrenteException.When(Saldo < 0,
                "Saldo invalido, não pode ser negativo.");

            Agencia = agencia;
            Conta = conta;
            Saldo = saldo;
        }


        // ToString override
        public override string ToString()
        {
            return $"Titular: {Titular.Nome} \n" +
                   $"CPF: {Titular.Cpf} \n" +
                   $"Profissão: {Titular.Profissao} \n" +
                   $"Agencia: {Agencia} \n" +
                   $"Conta: {Conta} \n" +
                   $"Saldo: R${Saldo.ToString("f2", CultureInfo.InvariantCulture)} \n";
        }

    }
}
