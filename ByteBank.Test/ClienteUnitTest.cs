using ByteBank.Entities;
using ByteBank.Exceptions;
using FluentAssertions;

namespace ByteBank.Test
{
    public class ClienteUnitTest
    {
        [Fact]
        
        public void CreateCliente_ComvaloresValidos_ResultadoValido()
        {
            Action action = () => new Cliente("Marcos", "222.444.555-22", "Tecelao");
            action.Should()
                .NotThrow<ClienteException>();
        }

        [Fact]
        public void CreateCliente_ComNomeNull_ClienteException()
        {
            Action action  = () => new Cliente(null, "222.444.555-22", "Tecelao");
            action.Should()
                .Throw<ClienteException>()
                .WithMessage("Nome nao pode ser nulo ou vazio.");
        }

        [Fact]
        public void CreateCliente_ComNomeVazio_ClienteException()
        {
            Action action = () => new Cliente("", "222.444.555-22", "Tecelao");
            action.Should()
                .Throw<ClienteException>()
                .WithMessage("Nome nao pode ser nulo ou vazio.");
        }
    }
}
