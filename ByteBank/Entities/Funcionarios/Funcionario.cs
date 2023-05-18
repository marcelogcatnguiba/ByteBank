using ByteBank.Entities.Enum;
using ByteBank.Exceptions;
using System.Globalization;


namespace ByteBank.Entities.Funcionarios
{
    public abstract class Funcionario
    {
        // Prop
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; protected set; }
        public double Salario { get; protected set; }
        public Cargo Cargo { get; private set; }


        public static int TotalFuncionarios { get; protected set; }

        //Constructor - Construtor

        public Funcionario(int id, string nome, string cpf, double salario, Cargo cargo)
        {
            Valida(id, nome, cpf, salario);
            Cargo = cargo;
            TotalFuncionarios++;
        }

        //Methods - Metodos
        public abstract double ReceberBonificacao();

        public abstract void AumentarSalario();

        public void SetSalario(double value)
        {
            Salario += value;
        }

        private void Valida(int id, string nome, string cpf, double salario)
        {
            FuncionarioException.When(id < 0,
                "Valor de id não permitido");

            FuncionarioException.When(string.IsNullOrEmpty(nome),
                "Nome não pode ser vazio ou nulo");

            FuncionarioException.When(string.IsNullOrEmpty(cpf),
                "Cpf não pode ser vazio ou nulo");

            FuncionarioException.When(salario < 0,
                "Salario não pode ser negativo");

            Nome = nome;
            Cpf = cpf;
            Salario = salario;
            
        }
        //Overrride

        public override string ToString()
        {
            return $"Nome: {Nome} \n" +
                   $"CPF: {Cpf} \n" +
                   $"Salario: R$ {Salario.ToString("F2", CultureInfo.InvariantCulture)} \n" +
                   $"Cargo: {Cargo} \n";
        }


    }
}
