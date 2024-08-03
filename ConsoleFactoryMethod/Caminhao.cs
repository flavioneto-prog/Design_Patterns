namespace ConsoleFactoryMethod;

public class Caminhao : Transporte
{
    public override void Entregar()
    {
        Console.WriteLine("Entrega feita por caminhão...");
    }
}