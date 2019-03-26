using System;
namespace Inheritance
{
    sealed public class SealedClassA : GrandKidClassA
    {
        public SealedClassA()
        {
        }

        static public void ImSealedClassMethod() => Console.WriteLine("Sealed class' method.");
    }
}
