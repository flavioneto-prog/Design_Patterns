using Builder.Builder;
using Builder.Product;

namespace Builder.ConcreteBuilder;

public sealed class PizzaCalabreza : PizzaBuilder
{
    public override void IncluirIngredientes()
    {
        pizza.Ingredientes = new List<string>
        {
            "Calabreza em fatias",
            "Molho de tomate"
        };
    }

    public override void PrepararMassa()
    {
        pizza.Tamanho = ETamanho.Grande;
        pizza.TipoBorda = ETipoBorda.Normal;
        pizza.TipoMassa = ETipoMassa.Grossa;
    }
}