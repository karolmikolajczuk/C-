using System;

namespace Generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GenericClass<string> obj = new GenericClass<string>(21, "Karol", "19-07-1997");
            GenericClass<string>.Print(obj);
            Console.WriteLine("Get year: " + obj.year.ToString());

            obj.year = 23;
            Console.WriteLine("Set year: " + obj.year);

            Console.WriteLine("Printing a second class thing");
            Console.WriteLine("Printing what object was sent through parameter");
            Console.WriteLine("Used 'where' keyword.");
            GenericClass2<GenericClass<string>>.Printer(obj);
        }
    }
}
