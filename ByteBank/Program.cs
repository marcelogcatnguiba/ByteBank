using ByteBank.Entities;
using ByteBank.Entities.Enum;
using ByteBank.Entities.Funcionarios;
using ByteBank.Interface;
using ByteBank.Service;

#region
//Funcionario pedro = new Auxiliar("Pedro", "233.233.122-01", 1200, (Cargo)Enum.Parse(typeof(Cargo), "Auxiliar"));
//Funcionario ana = new Diretor("Ana", "233.321.122-01", 6000, (Cargo)Enum.Parse(typeof(Cargo), "Diretor"));
//Funcionario jose = new Designer("Jose", "233.321.222-01", 3000, (Cargo)Enum.Parse(typeof(Cargo), "Designer"));
//Funcionario maria = new GerenteDeContas("Maria", "444.321.122-01", 2000, (Cargo)Enum.Parse(typeof(Cargo), "GerenteDeContas"));

//List<Funcionario> list = new List<Funcionario>();
//GerenciadorBonifica total = new GerenciadorBonifica();

//ana.Login = "Ana";
//ana.Senha = "999";

//Console.WriteLine(ana.Autenticar("Ana", "999"));
#endregion

//Cliente marcos = new Cliente("Marcos", "222.444.555-22", "Tecelao");
//ContaCorrente contaMarcos = new ContaCorrente(marcos, 0, 100, 2000);
//contaMarcos.Saque(3000);

Funcionario ana = new Diretor("Ana", "233.321.122-01", 6000, (Cargo)Enum.Parse(typeof(Cargo), "Diretor"));
IBonificacao teste = new GerenciadorBonifica();
teste.Bonificacao(ana);
Console.WriteLine(ana);

