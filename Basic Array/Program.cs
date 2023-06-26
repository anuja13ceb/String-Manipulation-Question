using System;
public class Exercise3
{
    public static void Main()
    {
        int[] a = new int[100];
        int i, n, sum = 0;

        Console.Write("\n\nFind sum of all elements of array:\n");
        Console.Write("--------------------------------------\n");

        Console.Write("Input the number of elements to be stored in the array :");
        n = Convert.ToInt32(Console.ReadLine());

       
        String numberString = Convert.ToString(n);
        string[] stringArray = numberString.Select(c => c.ToString()).ToArray();
        

       // int length = stringArray.Length;
        for(int z=0;z<stringArray.Length;z++)
        {
            sum = sum + Convert.ToInt32(stringArray[z]);
        }

        ////char[] digits = numberString.ToCharArray();

        //for (int j = 0; j < numberString.Length; j++)
        //{
        //    sum = sum + digits[j];
        //}

        Console.WriteLine(sum);
        Console.ReadKey();


    }
}