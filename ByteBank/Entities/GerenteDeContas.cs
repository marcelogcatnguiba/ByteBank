using ByteBank.Entities.Enum;
using ByteBank.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities
{
    internal class GerenteDeContas : Funcionario, IAutenticar
    {
        public GerenteDeContas(string name, string cpf, double salario, Cargo cargo) : base(name, cpf, salario, cargo)
        {

        }

        public string Login { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Senha { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AumentarSalario()
        {
            Salario += Salario * 0.05;
        }

        public bool Autenticar(string login, string senha)
        {
            throw new NotImplementedException();
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.25;
        }
    }
}
