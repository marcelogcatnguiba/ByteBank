using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities
{
    internal class GetBonificacao
    {
        public double TotalDeBonificacao { get; private set; }
        public double Registrar(Funcionario funcionario)
        {
            return this.TotalDeBonificacao = funcionario.GetBonificacao();
        }

    }
}
