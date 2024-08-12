namespace ConsoleExemploConceitual;

abstract class Estado
{
    protected Contexto _contexto;

    public void DefinirContexto(Contexto contexto)
    {
        this._contexto = contexto;
    }

    public abstract void Manipulador1();

    public abstract void Manipulador2();
}