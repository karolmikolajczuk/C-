using System;

namespace ExtensionMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = 10;
            if (number.isGreater(9)) Console.WriteLine(true);
            if (number.isGreater(10)) Console.WriteLine(false);

            string text = "Hey";
            if (text.isLonger("Heyy")) Console.WriteLine(false);
            if (text.isLonger("He")) Console.WriteLine(true);
        }
    }
}
