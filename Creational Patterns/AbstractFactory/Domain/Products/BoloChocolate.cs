using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products;

//ProductA1
public sealed class BoloChocolate : Bolo
{
    public BoloChocolate() : base(ETipoMassa.Bolo, "Bolo de chocolate")
    {
        Ingredientes.Add("Cobertura de chocolate");
    }
}