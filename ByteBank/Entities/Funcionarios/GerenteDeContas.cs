using ByteBank.Entities.Enum;
using ByteBank.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities.Funcionarios
{
    internal class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string name, string cpf, double salario, Cargo cargo) : base(name, cpf, salario, cargo)
        {

        }


        public override void AumentarSalario()
        {
            Salario += Salario * 0.05;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.25;
        }
    }
}
