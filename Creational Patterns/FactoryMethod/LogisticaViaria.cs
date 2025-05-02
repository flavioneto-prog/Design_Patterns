namespace ConsoleFactoryMethod;

public class LogisticaViaria : Logistica
{
    public override Transporte CriarTransporte()
    {
        return new Caminhao();
    }
}