using System;

/**
 * Covariance means if class B inherits from class A, 
 * and class C inherits from class B, it means data 
 * from class A is visible in C. It means we can create
 * an object like A obj = new C(); It means we can point 
 * like from A class (base class) to kids classes.
 * 
 * Also it gives us informations that, grandkids know more
 * than granddad. Because granddad knows things only from class A
 * but grandkids know things from class A, class B and 
 * ofcourse from themselves class C.
 **/

namespace Covariance
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            ClassA a = new ClassA();
            ClassA b = new ClassB();
            ClassA c = new ClassC();

            a.Print();
            b.Print();
            c.Print();
        }
    }
}
