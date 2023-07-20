namespace SingletonDemo
{
    public class NumberPattern
    {
        public static void Main()
        { 
            for(int i=1;i<=5;i++)
            {
                int a = i;
                for(int j=5;j>=1;j--)
                {
                    int b = j;
                    //agar i ki value 2 hai aur j less than and equal to hai to if condition ke andar jayega means if condition mai 2 baar jayega to 1 aur 2 print karega.
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

//output
//    1
//   21
//  321
// 4321
//54321