namespace ConsoleBridge;

public class Abstracao
{
    protected Implementacao _implementation;

    public Abstracao(Implementacao implementation)
    {
        this._implementation = implementation;
    }

    public virtual string Operacao()
    {
        return "Abstrato: Operação de base com:\n" +
            _implementation.ImplementacaoOperacao();
    }
}