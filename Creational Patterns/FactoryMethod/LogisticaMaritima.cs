namespace ConsoleFactoryMethod;

public class LogisticaMaritima : Logistica
{
    public override Transporte CriarTransporte()
    {
        return new Navio();
    }
}