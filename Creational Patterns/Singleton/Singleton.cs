namespace Singleton.MultiThread
{
    public class Singleton
    {
        private static int contador = 0;
        private static Singleton instance = null;
        private static object lockObject = new object();

        private Singleton()
        {
            contador++;
            Console.WriteLine("Instância = " + contador);
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }
    }
}
