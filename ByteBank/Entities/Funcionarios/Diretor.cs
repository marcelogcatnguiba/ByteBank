using ByteBank.Entities.Enum;

namespace ByteBank.Entities.Funcionarios
{
    public class Diretor : Funcionario
    {

        public Diretor(int id, string name, string cpf, double salario, Cargo cargo)
            : base(id, name, cpf, salario, cargo)
        {

        }

        public override double ReceberBonificacao()
        {
            return Salario *= 0.5;
        }

        public override void AumentarSalario()
        {
            Salario += Salario * 0.15;
        }

    }
}
