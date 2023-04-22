using ByteBank.Entities;

Titular marcelo = new Titular("Marcelo", "255.255.255", "TI");
Titular maria = new Titular("Maria", "255.300.255", "Dona de Casa");

ContaCorrente contaMarcelo = new ContaCorrente(marcelo, 257, 5000, 500);
ContaCorrente contaMaria = new ContaCorrente(maria, 257, 5001, 100);

Console.WriteLine(contaMarcelo);
Console.WriteLine(contaMaria);