namespace ConsoleExemploConceitual;

class EstadoConcretoB : Estado
{
    public override void Manipulador1()
    {
        Console.Write("Estado Concreto B lida com a solicitação 1.");
    }

    public override void Manipulador2()
    {
        Console.WriteLine("Estado Concreto B lida com a solicitação 2.");
        Console.WriteLine("Estado Concreto B quer mudar o estado do contexto.");
        this._contexto.TransicaoPara(new EstadoConcretoA());
    }
}