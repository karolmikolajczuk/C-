using System;

// lambda is a shorter way to write a function
// lambda doesnt have constraints about have arguments or not.
// lambda can have multiple lines


namespace LambdaExpression
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Func<int, int, int> Delegate = (x, y) => x + y;
            Console.WriteLine(Delegate(10, 10));

            Action<int> act = (x) =>
            {
                int a = 222;
                Console.WriteLine(x);
                Console.WriteLine(a);
            };
            act(99);
        }
    }
}
