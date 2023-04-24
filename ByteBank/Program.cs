using ByteBank.Entities;
using ByteBank.Entities.Enum;
#region
//Cliente marcelo = new Cliente("Marcelo", "255.255.255", "TI");
//Cliente maria = new Cliente("Maria", "255.300.255", "Dona de Casa");

//ContaCorrente contaMarcelo = new ContaCorrente(marcelo, 257, 5000, 500);
//ContaCorrente contaMaria = new ContaCorrente(maria, 257, 5001, default);

//Console.WriteLine(contaMarcelo);
//Console.WriteLine(contaMaria);
//Console.WriteLine(ContaCorrente.TotalContas);
#endregion

Funcionario pedro = new Funcionario("Pedro", "233.233.122-01", 1200, (Cargo)Enum.Parse(typeof(Cargo), "Auxiliar"));
Funcionario ana = new Diretor("Ana", "233.321.122-01", 6000, (Cargo)Enum.Parse(typeof(Cargo), "Diretor"));
GetBonificacao total = new GetBonificacao();

Console.WriteLine(pedro);
Console.WriteLine(ana);

Console.WriteLine("--------------------\n");

total.SomaBonificacao(pedro);
total.SomaBonificacao(ana);
Console.WriteLine($"Total de bonificação: R$ {total.TotalDeBonificacao} \n");

pedro.AumentarSalario();
ana.AumentarSalario();

Console.WriteLine(pedro);
Console.WriteLine(ana);