namespace SingletonDemo
{
    public class NumberPattern3
    {
        public static void Main()
        {
            int[] k = { 1,2,3,4,5};

            int m=k.Length;

            Console.WriteLine("test");
            for (int i = 1; i <= 5; i++)
            {
                int a = i;
                for (int j = 5; j >= 1; j--)
                {
                    int b = j;

                    if (j <= i)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();

            }


            for (int i = m-1; i >= 1; i--)
            {
                for (int j = 1; j <= m-1; j++)
                {
                    if (j <= i)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
//OutPut
//1
//12
//123
//1234
//12345
//1234
//123
//12
//1