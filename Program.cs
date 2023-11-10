using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Marcos",sobrenome: "de Souza");
hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

Console.WriteLine($"{hospedes.Count} hospedes foram cadastrados.");

// Cria a suíte
Console.WriteLine("Tipo de Suíte?");
string tip = Console.ReadLine();
Console.WriteLine("Capacidade máxima?");
int cap = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Valor da Diária?");
decimal val = Convert.ToDecimal(Console.ReadLine());

Suite suite = new Suite(tipoSuite: tip, capacidade: cap, valorDiaria: val);

// Cria uma nova reserva, passando a suíte e os hóspedes
Console.WriteLine("Quantos dias de hospedagem?");
int dias = Convert.ToInt32(Console.ReadLine());

Reserva reserva = new Reserva(diasReservados: dias);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($" Valor Total da Reserva: {reserva.CalcularValorDiaria() * reserva.ObterQuantidadeHospedes()}" +
                  $" reais. \n Total de Hóspedes: {reserva.ObterQuantidadeHospedes()}");