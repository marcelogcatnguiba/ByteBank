using ByteBank.Entities;
using ByteBank.Entities.Enum;

//Cliente marcelo = new Cliente("Marcelo", "255.255.255", "TI");
//Cliente maria = new Cliente("Maria", "255.300.255", "Dona de Casa");

//ContaCorrente contaMarcelo = new ContaCorrente(marcelo, 257, 5000, 500);
//ContaCorrente contaMaria = new ContaCorrente(maria, 257, 5001, default);

//Console.WriteLine(contaMarcelo);
//Console.WriteLine(contaMaria);
//Console.WriteLine(ContaCorrente.TotalContas);

Funcionario pedro = new Funcionario("Pedro", "233.233.122-01", 1200,(Cargo)Enum.Parse(typeof(Cargo), "Producao"));
Funcionario ana = new Diretor("Pedro", "233.233.122-01", 5000, (Cargo)Enum.Parse(typeof(Cargo), "Diretor"));

Console.WriteLine(pedro);
Console.WriteLine(ana);

GetBonificacao total = new GetBonificacao();

Console.WriteLine(total.Registrar(pedro));
Console.WriteLine(total.Registrar(ana));