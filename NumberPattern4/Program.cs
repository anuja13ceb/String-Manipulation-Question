namespace SingletonDemo
{
    public class NumberPattern4
    {
        public static void Main()
        {
            int[] m = {1,2,3,4,5};
            int len= m.Length;

            Console.WriteLine("test");
            for(int i=5;i>=1;i--)
            {
                int a = i;
                for(int j=1;j<=5;j++)
                {
                    int b= j;
                    if(j>=i)
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