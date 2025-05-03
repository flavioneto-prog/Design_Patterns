using Builder.Product;

namespace Builder.Builder;

public abstract class PizzaBuilder
{
    protected Pizza pizza = default!;

    public void CriarPizza()
    {
        pizza = new Pizza();
    }

    public Pizza ObterPizza()
    {
        return pizza;
    }

    public abstract void PrepararMassa();

    public abstract void IncluirIngredientes();
}