using System.Globalization;
using ByteBank.Entities;
using ByteBank.Exceptions;

namespace ByteBank.Entities
{
    internal class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public double Saldo { get; private set; } = 100;
        public static int TotalContas { get; private set; } // membros static carrega em memoria ao iniciar

        // Construtores - Constructor
        public ContaCorrente(Cliente titular, int agencia, int conta, double saldo)
        {

            if (agencia <= 0 || conta <= 0)
            {
                string erro = agencia <= 0 ? "agencia" : "conta";
                throw new ArgumentException($"Não possivel agencia ou conta menores que 0. Parametro com erro: {erro}");
            }
            else
            {
                Titular = titular;
                Agencia = agencia;
                Conta = conta;
                Saldo = saldo;
            }

        }
        // Methods - Metodos
        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Não possivel colocar valores negativos.");
            }
            else
            {
                Saldo = valor;
            }
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
                throw new SaldoInsuficienteException("Saldo insuficiente para essa transação.");

            }
        }

        public void Tranferencia(double valor, ContaCorrente conta)
        {
            bool teste = Saque(valor);
            if (teste == true)
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
                   $"Saldo: R${Saldo.ToString("f2", CultureInfo.InvariantCulture)} \n";
        }

    }
}
