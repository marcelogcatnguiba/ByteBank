using ByteBank.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities
{
    internal class Diretor : Funcionario
    {
        public Diretor(string name, string cpf, double salario, Cargo cargo) : base(name, cpf, salario, cargo)
        {

        }
        public override double GetBonificacao()
        {
            return this.Salario; // 100% do salario
        }
    }
}
