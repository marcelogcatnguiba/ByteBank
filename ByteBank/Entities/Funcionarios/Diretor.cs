using ByteBank.Entities.Enum;
using ByteBank.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities.Funcionarios
{
    public class Diretor : Funcionario
    {

        public Diretor(string name, string cpf, double salario, Cargo cargo) : base(name, cpf, salario, cargo)
        {

        }

        public override double GetBonificacao()
        {
            return Salario *= 0.5;
        }

        public override void AumentarSalario()
        {
            Salario += Salario * 0.15;
        }

    }
}
