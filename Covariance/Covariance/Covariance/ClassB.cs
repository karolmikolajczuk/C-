using System;
namespace Covariance
{
    public class ClassB : ClassA
    {
        protected int b = 6;

        public ClassB()
        {
        }

        public static override void Print()
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
