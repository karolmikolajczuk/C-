using System;
namespace Covariance
{
    public class ClassA
    {
        protected int a = 5;

        public ClassA()
        {
        }

        public virtual void Print()
        {
            Console.WriteLine(a);
        }
    }
}
