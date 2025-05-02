namespace ConsoleFactoryMethod;

public class Navio : Transporte
{
    public override void Entregar()
    {
        Console.WriteLine("Entrega feita por navio...");
    }
}