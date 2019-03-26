using System;
namespace Covariance
{
    public class ClassC : ClassB
    {
        public int c = 7;

        public ClassC()
        {
        }

        public override void Print()
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

    }
}
