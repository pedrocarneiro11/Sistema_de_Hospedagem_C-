using System.Text;
using pasta_projeto.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa pedro = new Pessoa("pedro", "carneiro");
Pessoa pedro2 = new Pessoa("pedro2", "carneiro2");

hospedes.Add(pedro);
hospedes.Add(pedro2);

Suite suite = new Suite("suite", 2, 100);

Reserva reserva = new Reserva(2);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diaria: {reserva.CalcularValorDiaria()}");




