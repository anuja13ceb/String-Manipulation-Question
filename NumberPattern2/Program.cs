namespace SingletonDemo
{
    public class NumberPattern2
    {
        public static void Main()
        {
            Console.WriteLine("test");
            for (int i = 1; i <= 5; i++)
            {
                int a = i;
                for (int j = 5; j >= 1; j--)
                {
                    int b = j;
                    //agar i ki value 2 hai aur j less than and equal to hai to if condition ke andar jayega means if condition mai 2 baar jayega to 2 aur 2 print karega.
                    if (j <= i)
                    {
                        Console.Write(i);
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
//22
//333
//4444
//55555