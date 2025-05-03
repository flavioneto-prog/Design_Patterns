using AbstractFactory.AbstractFactory;
using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;

namespace AbstractFactory.Factory;

public sealed class BoloFactory : MassasAbstractFactory
{
    // ConcreteFactory1
    public override MassaBase CriarMassa(ETipoMassa tipoMassa)
    {
        var tipoBolo = (ETipoBolo)tipoMassa;

        switch (tipoBolo)
        {
            case ETipoBolo.Chocolate:
                return new BoloChocolate();
            case ETipoBolo.Laranja:
                return new BoloLaranja();
            default:
                throw new ArgumentOutOfRangeException("Tipo não implementado");
        }
    }
}
