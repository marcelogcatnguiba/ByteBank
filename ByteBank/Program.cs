using ByteBank.Entities;
using ByteBank.Entities.Enum;
using ByteBank.Service;
#region
//Cliente marcelo = new Cliente("Marcelo", "255.255.255", "TI");
//Cliente maria = new Cliente("Maria", "255.300.255", "Dona de Casa");

//ContaCorrente contaMarcelo = new ContaCorrente(marcelo, 257, 5000, 500);
//ContaCorrente contaMaria = new ContaCorrente(maria, 257, 5001, default);

//Console.WriteLine(contaMarcelo);
//Console.WriteLine(contaMaria);
//Console.WriteLine(ContaCorrente.TotalContas);
#endregion

Funcionario pedro = new Auxiliar("Pedro", "233.233.122-01", 1200, (Cargo)Enum.Parse(typeof(Cargo), "Auxiliar"));
Funcionario ana = new Diretor("Ana", "233.321.122-01", 6000, (Cargo)Enum.Parse(typeof(Cargo), "Diretor"));
Funcionario jose = new Designer("Jose", "233.321.222-01", 3000, (Cargo)Enum.Parse(typeof(Cargo), "Designer"));
Funcionario maria = new GerenteDeContas("Maria", "444.321.122-01", 2000, (Cargo)Enum.Parse(typeof(Cargo), "GerenteDeContas"));

List<Funcionario> list = new List<Funcionario>();
GerenciadorBonifica total = new GerenciadorBonifica();

ana.Login = "Ana";
ana.Senha = "999";

Console.WriteLine(ana.Autenticar("Ana", "999"));
#region
//list.Add(pedro); 
//list.Add(ana);
//list.Add(jose);
//list.Add(maria);

//foreach (Funcionario funcionario in list)
//{
//    total.SomaBonificacao(funcionario);
//}

//Console.WriteLine(total.TotalDeBonificacao);

//Console.WriteLine("--------------------\n");

//total.SomaBonificacao(pedro);
//total.SomaBonificacao(ana);
//Console.WriteLine($"Total de bonificação: R$ {total.TotalDeBonificacao} \n");

//pedro.AumentarSalario();
//ana.AumentarSalario();

//Console.WriteLine(pedro);
//Console.WriteLine(ana);
#endregion
