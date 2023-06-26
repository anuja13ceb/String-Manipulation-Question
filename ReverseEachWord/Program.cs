using System;
public class StringMAnipulations
{
    public static void Main()
    {

        string s=Console.ReadLine();
       
        string[] a = s.Split(" ");
        string sum=string.Empty;

        for (int i=0;i<a.Length;i++)
        {
            char[] chars = a[i].ToCharArray();
            for(int j=chars.Length-1;j>=0;j--)
            {
                sum = sum + chars[j];
            }

            sum = sum + " ";
        }
        Console.WriteLine(sum);
        Console.ReadLine();

    }
}