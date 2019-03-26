using System;

namespace Predicate
{
    class MainClass
    {
        private static bool isStringUpper(string text)
        {
            return text.Equals(text.ToUpper());
        }

        public static void Main(string[] args)
        {

            Predicate<string> checkUpper = isStringUpper;
            Console.WriteLine(checkUpper("Hey Babe"));
            Console.WriteLine(checkUpper("YES"));
            Console.WriteLine(checkUpper("no"));
            Console.WriteLine(checkUpper(".")); // it will give true, cuz after upper method dot is still a dot (no bigger dot or something)
        }
    }
}
