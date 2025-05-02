using ConsoleStrategy.ConcreteStrategy;
using ConsoleStrategy.Context;
using ConsoleStrategy.Models;

var carro = new Carro();
var dataEntrada = DateTime.Now;
var dataSaida = DateTime.Now.AddMinutes(15);
const double VALOR_PERIODO = 0.5;
var calculadoraMinutos = new Calculo15Minutos(VALOR_PERIODO);

var contaEstacionamentoPeriodo15Minutos = new ContaEstacionamento(calculadoraMinutos, carro, dataEntrada, dataSaida);
var valor = contaEstacionamentoPeriodo15Minutos.ValorConta();

var carro2 = new Carro();
var dataEntrada2 = DateTime.Now;
var dataSaida2 = DateTime.Now.AddDays(1);
const double VALOR_DIARIA = 15;
var calculadoraDiaria = new CalculoDiaria(VALOR_DIARIA);

var contaEstacionamentoDiaria = new ContaEstacionamento(calculadoraDiaria, carro2, dataEntrada2, dataSaida2);
var valor2 = contaEstacionamentoDiaria.ValorConta();

Console.WriteLine("Periodo 15 minutos");
Console.WriteLine("R$ " + valor);

Console.WriteLine("Diaria");
Console.WriteLine("R$ " + valor2);