namespace SingletonDemo
{
    public class Singletons
    {
        public static void Main()
        {
            Singleton singleton = Singleton.GetInstance();
            singleton.Message("test");
        
        }
    }

    public sealed class Singleton
    {
        private static Singleton instance = null;

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public string Message(string message)
        {
            return message;
        }

    }
}