using System;
using static System.Net.Mime.MediaTypeNames;
namespace SingletonDemo
{
    public class Singletons
    {
        public static void Main()
        {
        Singleton singleton=Singleton.GetInstance();
            singleton.PrintDetails("test");
            Console.WriteLine(singleton.ToString());

            Singleton fromStudent = Singleton.GetInstance();
            fromStudent.PrintDetails("From Student");
            Console.WriteLine(fromStudent.ToString());
            Console.ReadLine();
        }
    }

    /*
    *  Sealed ensures the class being inherited and
    *  object instantiation is restricted in the derived class
    */
    public sealed class Singleton
    {
        /*
        * Private property initilized with null
        * ensures that only one instance of the object is created
        * based on the null condition
        */
        private static Singleton instance = null;

        /*
       * Private constructor ensures that object is not
       * instantiated other than with in the class itself
       */
        //cannot create an object for the class outside of the class. But we can create objects for the class within the same class. 
        private Singleton() 
        { 
        
        }
        /*
      * public property is used to return only one instance of the class
      * leveraging on the private property
      */
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance=new Singleton();
            }
          return instance;
        
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}


