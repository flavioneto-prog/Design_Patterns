using ConsoleStrategy.Models;
using ConsoleStrategy.Strategy;

namespace ConsoleStrategy.Context;

// context
public class ContaEstacionamento
{
    public ContaEstacionamento(CalculoValor calculoValor)
    {
        CalculoValor = calculoValor;
    }

    private CalculoValor CalculoValor;

    public double ValorConta(DateTime dataEntrada, DateTime dataSaida, Veiculo veiculo)
    {
        return CalculoValor.Calcular(dataEntrada, dataSaida, veiculo);
    }
}