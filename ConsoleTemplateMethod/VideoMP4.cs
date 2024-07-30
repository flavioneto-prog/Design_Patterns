namespace ConsoleTemplateMethod;

public class VideoMP4 : VideoPlayer
{
    public override void DecodeVideoFormato()
    {
        Console.WriteLine("\n O Vídeo está sendo processado com o Decoder MP4");
    }
}
