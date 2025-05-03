using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products;

// ProductB1
public sealed class PizzaCalabreza : Pizza
{
    public PizzaCalabreza() : base(ETipoMassa.Pizza, "Pizza de calabreza")
    {
        Ingredientes.Add("Pimenta");
    }
}