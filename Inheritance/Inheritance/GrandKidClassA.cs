using System;
namespace Inheritance
{
    public class GrandKidClassA : KidClassA
    {
        public GrandKidClassA()
        {
        }

        public void GrandKidClassAA() 
        {
            WellMethod();
            KidClassAA();
            Console.WriteLine("GrandKidClassAA();");
        }

        public override sealed int VirtualMethod() => 2;
    }
}
