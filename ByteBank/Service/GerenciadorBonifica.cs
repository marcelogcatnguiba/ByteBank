using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Entities.Funcionarios;

namespace ByteBank.Service
{
    internal class GerenciadorBonifica
    {
        //Prop
        public double TotalDeBonificacao { get; private set; }

        //Metodo
        public double SomaBonificacao(Funcionario funcionario)
        {
            return TotalDeBonificacao += funcionario.GetBonificacao();
        }

    }
}
