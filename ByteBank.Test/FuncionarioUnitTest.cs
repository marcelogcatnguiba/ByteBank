using ByteBank.Entities.Enum;
using ByteBank.Entities.Funcionarios;
using ByteBank.Exceptions;
using FluentAssertions;

namespace ByteBank.Test
{
    public class FuncionarioUnitTest
    {
        [Fact]

        public void CreateFuncionario_ComValoresValidos_ResultadoValido()
        {
            Action action = () => 
            new Diretor(1, "Ana", "233.321.122-01", 6000, (Cargo)Enum.Parse(typeof(Cargo), "Diretor"));

            action.Should().NotThrow<FuncionarioException>();
        }

        [Fact]

        public void CreateFuncionario_ComIdNegatio_FuncionarioException()
        {
            Action action = () =>
            new Diretor(-1, "Ana", "233.321.122-01", 6000, (Cargo)Enum.Parse(typeof(Cargo), "Diretor"));

            action.Should()
                .Throw<FuncionarioException>()
                .WithMessage("Valor de id não permitido");
        }

        [Fact]
        public void CreateFuncionario_ComNomeNuloOuVazio_FuncionarioException()
        {
            Action action = () =>
            new Diretor(1, "", "233.321.122-01", 6000, (Cargo)Enum.Parse(typeof(Cargo), "Diretor"));

            action.Should()
                .Throw<FuncionarioException>()
                .WithMessage("Nome não pode ser vazio ou nulo");
        }

        [Fact]
        public void CreateFuncionario_ComCpfNuloOuVazio_FuncionarioException()
        {
            Action action = () =>
            new Diretor(1, "Ana", "", 6000, (Cargo)Enum.Parse(typeof(Cargo), "Diretor"));

            action.Should()
                .Throw<FuncionarioException>()
                .WithMessage("Cpf não pode ser vazio ou nulo");
        }

        [Fact]
        public void CreateFuncionario_SalarioNegativo_FuncionarioException()
        {
            Action action = () =>
            new Diretor(1, "Ana", "233.321.122-01", -1, (Cargo)Enum.Parse(typeof(Cargo), "Diretor"));

            action.Should()
                .Throw<FuncionarioException>()
                .WithMessage("Salario não pode ser negativo");
        }
    }
}
