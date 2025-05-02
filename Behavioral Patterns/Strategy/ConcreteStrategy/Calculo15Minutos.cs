using ConsoleStrategy.Models;
using ConsoleStrategy.Strategy;

namespace ConsoleStrategy.ConcreteStrategy;

// Concrete Strategy
public class Calculo15Minutos : CalculoValor
{
    private readonly double ValorPeriodo = 0.5;
    private const int QUINZE_MINUTOS = 15;

    public Calculo15Minutos(double valorPeriodo)
    {
        ValorPeriodo = valorPeriodo;
    }
    public double Calcular(DateTime dataEntrada, DateTime dataSaida, Veiculo veiculo)
    {
        return ValorPeriodo * Math.Round(dataSaida.Subtract(dataEntrada).TotalMinutes / QUINZE_MINUTOS, 2, MidpointRounding.ToEven);
    }
}