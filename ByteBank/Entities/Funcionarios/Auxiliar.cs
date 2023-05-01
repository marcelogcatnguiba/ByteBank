using ByteBank.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities.Funcionarios
{
    internal class Auxiliar : Funcionario
    {
        public Auxiliar(string nome, string cpf, double salario, Cargo cargo) : base(nome, cpf, salario, cargo)
        {

        }

        public override double GetBonificacao()
        {
            return Salario *= 0.2;
        }

        public override void AumentarSalario()
        {
            Salario += Salario * 0.1;
        }
    }
}
