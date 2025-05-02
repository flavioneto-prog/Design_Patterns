namespace ConsoleBridge;

public class Cliente
{
    public void CodigoCliente(Abstracao abstracao)
    {
        Console.Write(abstracao.Operacao());
    }
}