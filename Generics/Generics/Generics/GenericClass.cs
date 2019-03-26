using System;

namespace Generics
{
    public class GenericClass<T>
    {
        public int year { get; set; }
        private string name { get; set; }
        private T birth_date { get; set; }

        public GenericClass(int year, string name, T birth_date)
        {
            this.year = year;
            this.name = name;
            this.birth_date = birth_date;
        }

        static public void Print(GenericClass<T> o)
        {
            Console.WriteLine("Year: {0}\nName: {1}\nBirth Date: {2}", o.year, o.name, o.birth_date);
        }
    }

    // constraint for generic parameter 
    // T has to be a class type.

    public class GenericClass2<A> where A: class
    {
        static public void Printer(A param)
        {
            Console.WriteLine(typeof(A).ToString());
        }
    }
}
