using ByteBank.Entities.Enum;

namespace ByteBank.Entities.Funcionarios
{
    public sealed class Auxiliar : Funcionario
    {
        public Auxiliar(int id, string nome, string cpf, double salario, Cargo cargo)
            : base(id, nome, cpf, salario, cargo)
        {

        }

        public override double ReceberBonificacao()
        {
            return Salario *= 0.2;
        }

        public override void AumentarSalario()
        {
            Salario += Salario * 0.1;
        }
    }
}
