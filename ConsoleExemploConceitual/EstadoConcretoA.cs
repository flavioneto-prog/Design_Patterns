namespace ConsoleExemploConceitual;

class EstadoConcretoA : Estado
{
    public override void Manipulador1()
    {
        Console.WriteLine("Estado Concreto A lida com a solicitação 1.");
        Console.WriteLine("Estado Concreto A quer alterar o estado do contexto.");
        this._contexto.TransicaoPara(new EstadoConcretoB());
    }

    public override void Manipulador2()
    {
        Console.WriteLine("Estado Concreto A lida com a solicitação 2.");
    }
}