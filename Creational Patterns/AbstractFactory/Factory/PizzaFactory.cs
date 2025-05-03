using AbstractFactory.AbstractFactory;
using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;

namespace AbstractFactory.Factory;

// ConcreteFactory2
public sealed class PizzaFactory : MassasAbstractFactory
{
    public override MassaBase CriarMassa(ETipoMassa tipoMassa)
    {
        var tipoPizza = (ETipoPizza)tipoMassa;

        switch (tipoPizza)
        {
            case ETipoPizza.Mussarela:
                return new PizzaMussarela();
            case ETipoPizza.Calabreza:
                return new PizzaCalabreza();
            default:
                throw new ArgumentOutOfRangeException("Tipo não implementado");
        }
    }
}