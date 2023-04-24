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
        public double SomaBonificacao(Funcionario funcionario)
        {
            return TotalDeBonificacao += funcionario.GetBonificacao();
        }

    }
}
