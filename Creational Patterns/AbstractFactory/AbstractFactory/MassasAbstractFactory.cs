using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;
using AbstractFactory.Factory;

namespace AbstractFactory.AbstractFactory;

// AbstractFactory
public abstract class MassasAbstractFactory
{
    public abstract MassaBase CriarMassa(ETipoMassa tipoMassa);

    public static MassasAbstractFactory CriarFabricaMassas(ETipoMassa tipoMassa)
    {
        switch (tipoMassa)
        {
            case ETipoMassa.Pizza:
                return new PizzaFactory();
            case ETipoMassa.Bolo:
                return new BoloFactory();
            default:
                throw new ArgumentOutOfRangeException(nameof(tipoMassa), tipoMassa, null);
        }
    }
}