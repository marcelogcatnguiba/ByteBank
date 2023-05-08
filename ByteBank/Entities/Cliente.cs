using ByteBank.Exceptions;

namespace ByteBank.Entities
{
    public sealed class Cliente
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Profissao { get; private set; }

        //Constructors - Construtores

        public Cliente(string nome, string cpf, string profissao)
        {
            Validate(nome, cpf, profissao);
        }

        private void Validate(string nome, string cpf, string profissao)
        {
            ClienteException.When(string.IsNullOrEmpty(nome),
                "Nome nao pode ser nulo ou vazio.");

            ClienteException.When(string.IsNullOrEmpty(cpf),
                "Cpf invalido nao pode ser nulo ou vazio.");

            ClienteException.When(string.IsNullOrEmpty(profissao),
                "Profissao invalido nao pode ser nulo ou vazio.");

            Nome = nome;
            Cpf = cpf;
            Profissao = profissao;

        }
    }
}
