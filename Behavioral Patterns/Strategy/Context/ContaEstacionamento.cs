using ConsoleStrategy.Models;
using ConsoleStrategy.Strategy;

namespace ConsoleStrategy.Context;

// context
public class ContaEstacionamento
{
    private readonly CalculoValor CalculoValor;
    private readonly Veiculo Veiculo;
    private readonly DateTime DataEntrada;
    private readonly DateTime DataSaida;

    public ContaEstacionamento(CalculoValor calculoValor, Veiculo veiculo, DateTime dataEntrada, DateTime dataSaida)
    {
        CalculoValor = calculoValor;
        Veiculo = veiculo;
        DataEntrada = dataEntrada;
        DataSaida = dataSaida;
    }

    public double ValorConta()
    {
        return CalculoValor.Calcular(DataEntrada, DataSaida, Veiculo);
    }
}