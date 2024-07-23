using ConsoleStrategy.ConcreteStrategy;
using ConsoleStrategy.Context;
using ConsoleStrategy.Models;

var carro = new Carro();
var dataEntrada = DateTime.Now;
var dataSaida = DateTime.Now.AddMinutes(15);

var contaEstacionamentoPeriodo15Minutos = new ContaEstacionamento(new Calculo15Minutos());
var valor = contaEstacionamentoPeriodo15Minutos.ValorConta(dataEntrada, dataSaida, carro);

var carro2 = new Carro();
var dataEntrada2 = DateTime.Now;
var dataSaida2 = DateTime.Now.AddDays(1);

var contaEstacionamentoDiaria = new ContaEstacionamento(new CalculoDiaria());
var valor2 = contaEstacionamentoDiaria.ValorConta(dataEntrada2, dataSaida2, carro2);

Console.WriteLine("Periodo 15 minutos");
Console.WriteLine("R$ " + valor);

Console.WriteLine("Diaria");
Console.WriteLine("R$ " + valor2);