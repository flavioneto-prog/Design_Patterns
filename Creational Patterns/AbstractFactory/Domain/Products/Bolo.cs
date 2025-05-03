using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products;

// AbstractProductA
public abstract class Bolo : MassaBase
{
    protected Bolo(ETipoMassa tipoMassa, string nome) : base(tipoMassa, nome)
    {
    }
}