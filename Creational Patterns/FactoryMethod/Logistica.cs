namespace ConsoleFactoryMethod;

public abstract class Logistica
{
    public Transporte PlanejarEntrega()
    {
        return CriarTransporte();
    }

    public abstract Transporte CriarTransporte();
}