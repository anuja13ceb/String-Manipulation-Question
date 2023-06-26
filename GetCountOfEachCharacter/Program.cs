using System;
using static System.Net.Mime.MediaTypeNames;

public class CountStringCharacter
{
    public static void Main()
    {
        string t = "Hell";
        //string a = "Hell";

        //string[] t = a.Replace(" ", "").Select(s=>s.ToString()).ToArray(); ;
        //string[] t = a.Select(s => s.ToString()).ToArray();
        //string str = string.Empty;
        //string[] w=t.Split(new char[] { ' ' });
        // string[] p=t.Select(s=>s.ToString()).ToArray();
        int cal = 0;
        for (int i=0;i<t.Length;i++)
        {
            var m = t[i];
            Console.Write(t[i] + " = ");

            for (int j = 0; j < t.Length; j++)
            {
                if (t[i] == t[j])
                {
                    cal++;
                }
            }
            Console.WriteLine(cal);
            t = t.Replace(t[i].ToString(), string.Empty);
        }
      


       

        //char[] chars=strings.

        Console.ReadLine();
    }
}