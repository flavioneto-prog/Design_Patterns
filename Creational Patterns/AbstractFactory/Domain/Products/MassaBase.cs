using AbstractFactory.Domain.Enums;
using System.Collections;

namespace AbstractFactory.Domain.Products;

public abstract class MassaBase
{
    public ETipoMassa TipoMassa { get; set; }

    public string Nome { get; set; } = default!;

    public ArrayList Ingredientes = new();

    protected MassaBase(
        ETipoMassa tipoMassa,
        string nome)
    {
        TipoMassa = tipoMassa;
        Nome = nome;
    }
}