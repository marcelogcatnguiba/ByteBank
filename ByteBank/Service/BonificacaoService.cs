using ByteBank.Entities.Enum;
using ByteBank.Entities.Funcionarios;
using ByteBank.Interface;
namespace ByteBank.Service
{
    internal class BonificacaoService : IBonificacao
    {
        //Prop
        public double TotalDeBonificacao { get; private set; }

        public BonificacaoService()
        {
            
        }
        public void Bonificacao(Funcionario funcionario)
        {
            
            if (funcionario.Cargo == (Cargo)Enum.Parse(typeof(Cargo), "Diretor") ||
                funcionario.Cargo == (Cargo)Enum.Parse(typeof(Cargo), "GerenteDeContas"))
            {
                funcionario.SetSalario(funcionario.Salario / 2);
            }

        }

        //Metodo
        public double SomaBonificacao(Funcionario funcionario)
        {
            return TotalDeBonificacao += funcionario.ReceberBonificacao();
        }

    }
}
