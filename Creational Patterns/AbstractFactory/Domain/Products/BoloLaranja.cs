using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products;

//ProductA2
public sealed class BoloLaranja : Bolo
{
    public BoloLaranja() : base(ETipoMassa.Bolo, "Bolo de laranja")
    {
        Ingredientes.Add("Cobertura de chocolate");
    }
}