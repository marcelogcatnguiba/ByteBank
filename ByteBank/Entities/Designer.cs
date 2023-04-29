using ByteBank.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities
{
    internal class Designer : Funcionario
    {
        public Designer(string name, string cpf, double salario, Cargo cargo) : base(name, cpf, salario, cargo)
        {

        }

        public override void AumentarSalario()
        {
            Salario += Salario * 0.11;
        }
        public override double GetBonificacao()
        {
            return Salario *= 0.17;
        }
    }
}
