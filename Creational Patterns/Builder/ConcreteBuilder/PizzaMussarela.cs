using Builder.Builder;
using Builder.Product;

namespace Builder.ConcreteBuilder;

public sealed class PizzaMussarela : PizzaBuilder
{
    public override void IncluirIngredientes()
    {
        pizza.Ingredientes = new List<string>
        {
            "Mussarela",
            "Molho de tomate",
            "Orégano"
        };
    }

    public override void PrepararMassa()
    {
        pizza.Tamanho = ETamanho.Grande;
        pizza.TipoBorda = ETipoBorda.Recheada;
        pizza.TipoMassa = ETipoMassa.Normal;
    }
}
