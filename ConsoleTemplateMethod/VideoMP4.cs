namespace ConsoleTemplateMethod;

public class VideoMP4 : VideoPlayer
{
    protected override void DecodeVideoFormato()
    {
        Console.WriteLine("\n O Vídeo está sendo processado com o Decoder MP4");
    }
}
