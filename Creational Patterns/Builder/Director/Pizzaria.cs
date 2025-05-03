using Builder.Builder;
using Builder.Product;

namespace Builder.Director;

public class Pizzaria
{
    private readonly PizzaBuilder _builder;

    public Pizzaria(PizzaBuilder pizzaBuilder) => _builder = pizzaBuilder;

    // Construct
    public void MontarPizza()
    {
        _builder.CriarPizza();
        _builder.PrepararMassa();
        _builder.IncluirIngredientes();
    }

    public Pizza ObterPizza()
    {
        return _builder.ObterPizza();
    }
}