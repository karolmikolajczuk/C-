using System;

namespace Anonymous_Method
{
    // generic class, which is also internal
    internal class Delegates<T> 
    {        
        // a delegate for printing
        public delegate void Print(T value);

        // static method for access to print
        static public void Printing(T thing)
        {
            // an object for anonymous method
            Print print = delegate (T val)
            {
                Console.WriteLine("{0}: {1}", typeof(T).ToString(), val);
            };

            // print a thing 
            print(thing);
        }
    }

    class MainClass
    {

        public static void Main(string[] args)
        {
            // a welcome thing
            Console.WriteLine("Hello World!");

            // print a integer
            Delegates<int>.Printing(100);

            // print a string
            Delegates<string>.Printing("HEEEELO");

            // print a short number
            Delegates<short>.Printing(1);

            // print a double type number
            Delegates<double>.Printing(3.14);
        }
    }
}
