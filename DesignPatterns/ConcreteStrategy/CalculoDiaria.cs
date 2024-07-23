using ConsoleStrategy.Models;
using ConsoleStrategy.Strategy;

namespace ConsoleStrategy.ConcreteStrategy;

// Concrete Strategy
public class CalculoDiaria : CalculoValor
{
    private const double ValorDiaria = 15;
    private const int DIA_EM_MINUTOS = 1440;

    public double Calcular(DateTime dataEntrada, DateTime dataSaida, Veiculo veiculo)
    {
        return ValorDiaria * Math.Round(dataSaida.Subtract(dataEntrada).TotalMinutes / DIA_EM_MINUTOS, 2, MidpointRounding.ToEven);
    }
}
