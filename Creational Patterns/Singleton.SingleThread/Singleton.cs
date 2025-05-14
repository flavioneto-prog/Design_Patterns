namespace Singleton.SingleThread
{
    public class Singleton
    {
        private static Singleton instance;
        private int contador = 0;
        private Singleton()
        {
            Console.WriteLine("Instanciando dentro do construtor privado");
            contador++;
            Console.WriteLine("Número de instâncias = " + contador);
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    Console.WriteLine("Criando a primeira instância");
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}