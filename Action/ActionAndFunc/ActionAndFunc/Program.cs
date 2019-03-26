using System;

/**
 * Func delegate takes type parameters. 
 * Last parameter gives info what type is returned.
 * All types before the last one are parameters type's.
 * 
 * By the way, using here also lambda expression.
 **/


namespace ActionAndFunc
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Func<int, int, int> AddFunc = (x, y) => x + y;
            Console.WriteLine(AddFunc(5, 4));

            // override an last expression and give a new one
            AddFunc += (x, y) => x - y;
            Console.WriteLine(AddFunc(5, 4));

            // Func must return a value.
            //Func<void> voidFunc = () => Console.WriteLine("hey");

            // here we can use Action delegate. It doesn't return any value.
            // no matter what. ;-)

            Action<int> PrintInteger = (x) => Console.WriteLine(x);
            PrintInteger(101230123);

            // but it must have at least 1 param
            //Action<void> PrintHey = () => Console.WriteLine("Hey");

        }
    }
}
