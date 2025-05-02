using System.Collections;

namespace ConsoleLanche;

public abstract class Lanche
{
    public abstract string Nome { get; }

    public ArrayList Ingredientes = new();
}
