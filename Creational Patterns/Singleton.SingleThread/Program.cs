Console.WriteLine("Criando a primeira instância, s1!");
var singleton1 = Singleton.SingleThread.Singleton.Instance;

Console.WriteLine("Tentando criar a segunda instância, s2!");
var singleton2 = Singleton.SingleThread.Singleton.Instance;

if (singleton1 == singleton2)
{
    Console.WriteLine("Existe apenas uma instância");
}
else
{
    Console.WriteLine("Existem mais de uma instância");
}

Console.Read();