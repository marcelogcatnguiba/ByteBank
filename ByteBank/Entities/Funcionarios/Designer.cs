using ByteBank.Entities.Enum;

namespace ByteBank.Entities.Funcionarios
{
    public sealed class Designer : Funcionario
    {
        public Designer(int id, string name, string cpf, double salario, Cargo cargo) 
            : base(id, name, cpf, salario, cargo)
        {

        }

        public override void AumentarSalario()
        {
            Salario += Salario * 0.11;
        }
        public override double ReceberBonificacao()
        {
            return Salario *= 0.17;
        }
    }
}
