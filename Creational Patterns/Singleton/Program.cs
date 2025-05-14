namespace Singleton.MultiThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => AcessoThread1(),
                () => AcessoThread2()
            );

            Console.ReadLine();
        }

        private static void AcessoThread1()
        {
            Singleton singleton1 = Singleton.Instance;
            Console.WriteLine("Thread 1");
        }

        private static void AcessoThread2()
        {
            Singleton singleton2 = Singleton.Instance;
            Console.WriteLine("Thread 2");
        }
    }
}