using System;
public class Exercise3
{
    public static void Main()
    {
        string a = "Hello";
        string t=string.Empty;

        char[] chars = a.ToCharArray();
        int len = chars.Length;
      
        for (int i = len-1; i >= 0; i--)
        {
            t = t + chars[i];
        }
        Console.WriteLine(t);
        Console.ReadLine();
    
    }
}