namespace ConsoleExemploConceitual;

class Contexto
{
    private Estado _estado = null;

    public Contexto(Estado estado)
    {
        this.TransicaoPara(estado);
    }

    public void TransicaoPara(Estado estado)
    {
        Console.WriteLine($"Contexto: Transição para {estado.GetType().Name}.");
        this._estado = estado;
        this._estado.DefinirContexto(this);
    }

    public void Solicitacao1()
    {
        this._estado.Manipulador1();
    }

    public void Solicitacao2()
    {
        this._estado.Manipulador2();
    }
}