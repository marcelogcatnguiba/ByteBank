namespace ByteBank.Entities
{
    public class Titular
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        //Constructors - Construtores
        public Titular()
        {
        }
        public Titular(string nome, string cpf, string profissao)
        {
            Nome = nome;
            Cpf = cpf;
            Profissao = profissao;
        }
    }
}
