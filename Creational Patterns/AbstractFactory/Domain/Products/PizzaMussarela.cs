using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products;

// ProductB2
public sealed class PizzaMussarela : Pizza
{
    public PizzaMussarela() : base(ETipoMassa.Pizza, "Pizza de mussarela")
    {
        Ingredientes.Add("Ketchup");
    }
}