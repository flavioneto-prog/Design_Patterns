using ConsoleStrategy.Models;

namespace ConsoleStrategy.Strategy;

// strategy
public interface CalculoValor
{
    public double Calcular(DateTime dataEntrada, DateTime dataSaida, Veiculo veiculo);
}