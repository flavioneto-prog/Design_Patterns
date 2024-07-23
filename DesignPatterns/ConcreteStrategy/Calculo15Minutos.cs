using ConsoleStrategy.Models;
using ConsoleStrategy.Strategy;

namespace ConsoleStrategy.ConcreteStrategy;

// Concrete Strategy
public class Calculo15Minutos : CalculoValor
{
    private const double Valor15Minutos = 0.5;
    private const int QUINZE_MINUTOS = 15;

    public double Calcular(DateTime dataEntrada, DateTime dataSaida, Veiculo veiculo)
    {
        return Valor15Minutos * Math.Round(dataSaida.Subtract(dataEntrada).TotalMinutes / QUINZE_MINUTOS, 2, MidpointRounding.ToEven);
    }
}