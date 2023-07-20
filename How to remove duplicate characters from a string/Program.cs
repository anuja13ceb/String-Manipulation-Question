namespace SingletonDemo
{
    public class DuplicateCharacterFromString
    {
        public static void Main()
        {
            string t = "abbccdd";
            Console.WriteLine(t);
            string print = RemoveDuplicate(t);
            Console.WriteLine(print);
            Console.ReadKey();
         
        }

        public static string RemoveDuplicate(string message)
        {
            string a=string.Empty;



            for(int i=0;i<message.Length;i++)
            {
                if (!a.Contains(message[i]))
                {
                    a = a + message[i];
                }
            }


            return a;
        }
    }
}