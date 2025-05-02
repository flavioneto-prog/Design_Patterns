namespace ConsoleNullObject.Models;

// NULL OBJECT PATTERN
public class NullMobile : Mobile
{
    private static NullMobile _instance;

    public NullMobile()
    {
    }

    public static NullMobile Instance
    {
        get
        {
            if (_instance == null)
                return new NullMobile();
            return _instance;
        }
    }

    public void Ativar()
    {
        Console.WriteLine("\nATIVO celular nulo");
    }

    public void Desativar()
    {
        Console.WriteLine("\nDESATIVADO celular nulo");
    }
}