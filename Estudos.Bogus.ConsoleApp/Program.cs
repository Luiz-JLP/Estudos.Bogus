
using Estudos.Bogus.ConsoleApp.Fakers;

Console.WriteLine("Estudos sobre o gerenciador de dados Fake Bogus.");
Console.WriteLine();

var endereco = new AddressFaker().Generate();
var company = new CompanyFaker().Generate();
var finance = new FinanceFaker().Generate();

Console.WriteLine();

