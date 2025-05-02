namespace ConsoleTemplateMethod;

public abstract class VideoPlayer
{
    /// <summary>
    /// Template Method - Prodecimentos - passo a passo
    /// </summary>
    public void ExecutarVideo()
    {
        CarregarArquivo();
        DecodeVideoFormato();
        IniciarExecucao();
    }

    // procedimento padrão
    protected void CarregarArquivo()
    {
        Console.WriteLine("\n Arquivo de vídeo carregado...");
    }

    // procedimento que será sobrescrito
    protected abstract void DecodeVideoFormato();

    // procedimento padrão
    protected void IniciarExecucao()
    {
        Console.WriteLine("\n O vídeo iniciou a execução...");
    }
}