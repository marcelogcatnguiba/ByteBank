using ByteBank.Entities.Enum;
using ByteBank.Entities.Funcionarios;
using ByteBank.Interface;
namespace ByteBank.Service
{
    internal class GerenciadorBonifica : IBonificacao
    {
        //Prop
        public double TotalDeBonificacao { get; private set; }

        public GerenciadorBonifica()
        {
            
        }
        public void Bonificacao(Funcionario funcionario)
        {
            
            if (funcionario.Cargo == (Cargo)Enum.Parse(typeof(Cargo), "Diretor"))
            {
                funcionario.SetSalario(funcionario.Salario / 2);
            }

        }

        //Metodo
        public double SomaBonificacao(Funcionario funcionario)
        {
            return TotalDeBonificacao += funcionario.GetBonificacao();
        }

    }
}
