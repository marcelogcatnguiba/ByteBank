using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Entities.Enum;

namespace ByteBank.Entities
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }
        public Cargo Cargo { get; set; }
        //Constructor - Construtor

        public Funcionario(string nome, string cpf, double salario, Cargo cargo)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
            Cargo = cargo;
        }

        //Methods - Metodos
        public virtual double GetBonificacao()
        {
            return Salario += Salario * 0.1;
        }

        //Overrride

        public override string ToString()
        {
            return $"Nome: {Nome} \n" +
                   $"CPF: {Cpf} \n" +
                   $"Salario: R${Salario.ToString("F2",CultureInfo.InvariantCulture)} \n" +
                   $"Cargo: {Cargo} \n";
        }
    }
}
