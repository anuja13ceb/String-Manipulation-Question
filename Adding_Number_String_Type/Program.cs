using System;
public class Exercise3
{
    public static void Main()
    {
        //add the number
        string a = "1,2,3,4,5,6";

        int sum = 0;

        string[] t = a.Split(",").ToArray();

        for(int i=0;i<t.Length;i++)
        {
            sum = sum + Convert.ToInt32(t[i]);
        }


        Console.WriteLine(sum);
        Console.ReadLine();

    }
}