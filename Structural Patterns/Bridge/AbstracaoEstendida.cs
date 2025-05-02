namespace ConsoleBridge;

public class AbstracaoEstendida : Abstracao
{
    public AbstracaoEstendida(Implementacao implementation) : base(implementation)
    {
    }

    public override string Operacao()
    {
        return "Abstração estendida: Operação estendida com:\n" +
            base._implementation.ImplementacaoOperacao();
    }
}