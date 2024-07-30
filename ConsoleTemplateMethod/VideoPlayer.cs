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
    public void CarregarArquivo()
    {
        Console.WriteLine("\n Arquivo de vídeo carregado...");
    }

    // procedimento que será sobrescrito
    public abstract void DecodeVideoFormato();

    // procedimento padrão
    public void IniciarExecucao()
    {
        Console.WriteLine("\n O vídeo iniciou a execução...");
    }
}