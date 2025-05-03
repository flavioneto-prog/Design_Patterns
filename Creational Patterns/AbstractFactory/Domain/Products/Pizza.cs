using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products;

// AbstractProductB
public abstract class Pizza : MassaBase
{
    protected Pizza(ETipoMassa tipoMassa, string nome) : base(tipoMassa, nome)
    {
    }
}