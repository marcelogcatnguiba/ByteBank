using ByteBank.Entities;
using ByteBank.Exceptions;
using FluentAssertions;

namespace ByteBank.Test
{
    public class ContaCorrenteUnitTest
    {
        [Fact]
        public void CreateContaCorrente_ComValores_Validos_ResultadoValido()
        {
            Cliente cliente = new Cliente("Marcos", "222.444.555-22", "Tecelao");
            Action action = () => new ContaCorrente(cliente, 333, 2525120, 0);

            action.Should().NotThrow<ContaCorrenteException>();
        }

        [Fact]
        public void CreateContaCorrente_ComAgenciaNegativa_ContaCorrenteException()
        {
            Cliente cliente = new Cliente("Marcos", "222.444.555-22", "Tecelao");
            Action action = () => new ContaCorrente(cliente, -1, 2525120, 0);

            action.Should().Throw<ContaCorrenteException>()
                .WithMessage("Numero de agencia invalida.");
        }

        [Fact]

        public void CreateContaCorrente_ComContaNegativa_ContaCorrenteException()
        {
            Cliente cliente = new Cliente("Marcos", "222.444.555-22", "Tecelao");
            Action action = () => new ContaCorrente(cliente, 333, -1, 0);

            action.Should()
                .Throw<ContaCorrenteException>()
                .WithMessage("Numero de conta invalida.");
        }

        [Fact]

        public void CreateContaCorrente_ComSaldoNegativo_ContaCorrenteException()
        {
            Cliente cliente = new Cliente("Marcos", "222.444.555-22", "Tecelao");
            Action action = () => new ContaCorrente(cliente, 333, 3322211, -1);

            action.Should()
                .Throw<ContaCorrenteException>()
                .WithMessage("Saldo invalido, não pode ser negativo.");

        }
    }
}