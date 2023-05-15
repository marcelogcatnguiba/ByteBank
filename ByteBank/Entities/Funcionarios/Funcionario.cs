using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Entities.Enum;
using ByteBank.Interface;
using ByteBank.Service;

namespace ByteBank.Entities.Funcionarios
{
    public abstract class Funcionario
    {
        // Prop
        public string Nome { get; set; }
        public string Cpf { get; protected set; }
        public double Salario { get; protected set; }
        public Cargo Cargo { get; set; }


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

        public void SetSalario(double value)
        {
            Salario += value;
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
