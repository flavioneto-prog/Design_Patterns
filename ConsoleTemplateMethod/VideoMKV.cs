namespace ConsoleTemplateMethod;

public class VideoMKV : VideoPlayer
{
    protected override void DecodeVideoFormato()
    {
        Console.WriteLine("\n O Vídeo está sendo processado com o Decoder MKV");
    }
}
