using System;
namespace Inheritance
{
    public class BaseClassA
    {
        public BaseClassA()
        {
        }

        public void WellMethod() 
        {
            Console.WriteLine("{0}: WellMethod();", this.GetType().ToString());
        }

        public virtual int VirtualMethod() => 0;
    }
}
