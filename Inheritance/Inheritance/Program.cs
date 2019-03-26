using System;

namespace Inheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BaseClassA obj_a = new BaseClassA();
            BaseClassA obj_b = new KidClassA();
            BaseClassA obj_c = new GrandKidClassA();
        
            obj_a.WellMethod();
            Console.WriteLine(obj_b.VirtualMethod()); 
            Console.WriteLine(obj_c.VirtualMethod());
            SealedClassA.ImSealedClassMethod();
        }
    }
}
