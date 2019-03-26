using System;

   /*  
    * 
    * Example of use a nullable "structure"
    * 
    */

namespace Nullable
{
    class ExampleClass 
    {
        public int j;
        public Nullable<int> i;
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            // set an integer variable a NULL value
            Nullable<int> i = null;

            if (i.HasValue) Console.WriteLine(i.Value);
            else Console.WriteLine("NULL");

            Nullable<int> j = null;
            Console.WriteLine(j.GetValueOrDefault());

            int? k = null;
            Console.WriteLine(k.GetValueOrDefault());

            int? l = null;
            int m = l ?? 0;
            Console.WriteLine(m);

            ExampleClass obj = new ExampleClass();
            if (obj.i == null) Console.WriteLine("Jest Nullem");
            if (obj.j == null) Console.WriteLine("Jest Nullem");
            else Console.WriteLine(obj.j); // what is a default value
        }
    }
}
