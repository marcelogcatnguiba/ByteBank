using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Entities.Enum;
using ByteBank.Service;

namespace ByteBank.Entities
{
    public abstract class Funcionario : IAutenticar
    {
        // Prop
        public string Nome { get; set; }
        public string Cpf { get; protected set; }
        public double Salario { get; protected set; }
        public Cargo Cargo { get; set; }
        public string Login { get ; set ; }
        public string Senha { get ; set; }

        public static int TotalFuncionarios { get; protected set; }

        //Constructor - Construtor

        public Funcionario(string nome, string cpf, double salario, Cargo cargo)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
            Cargo = cargo;
            TotalFuncionarios++;
        }

        //Methods - Metodos
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();

        public bool Autenticar(string login, string senha)
        {
            if (Login == login & Senha == senha)
            {
                Console.WriteLine("Boas vindas ao sistema !!.");
                return true;
            }
            else
            {
                Console.WriteLine("Senha invalida.");
                return false;
            }
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
