using System;
namespace Inheritance
{
    public class KidClassA : BaseClassA
    {
        public KidClassA()
        {
        }

        public override int VirtualMethod() => 1;

        public void KidClassAA() => Console.WriteLine("KidClassA();");

    }
}
