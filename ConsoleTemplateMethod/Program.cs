using ConsoleTemplateMethod;

Console.WriteLine("TEMPLATE METHOD");
Console.WriteLine("\n EXEMPLO DE IMPLEMENTAÇÃO");
Console.ReadLine();

Console.WriteLine("\n VÍDEO PLAYER - VÍDEO MP4");
var arquivoVideo = new VideoMP4();
arquivoVideo.ExecutarVideo();

Console.WriteLine("\n VÍDEO PLAYER - VÍDEO MP4");
var arquivoVideoMvk = new VideoMKV();
arquivoVideoMvk.ExecutarVideo();

Console.ReadLine();