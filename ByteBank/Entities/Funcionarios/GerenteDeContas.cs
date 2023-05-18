using ByteBank.Entities.Enum;

namespace ByteBank.Entities.Funcionarios
{
    internal class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(int id, string name, string cpf, double salario, Cargo cargo)
            : base(id, name, cpf, salario, cargo)
        {

        }

        public override void AumentarSalario()
        {
            Salario += Salario * 0.05;
        }

        public override double ReceberBonificacao()
        {
            return Salario *= 0.25;
        }
    }
}
