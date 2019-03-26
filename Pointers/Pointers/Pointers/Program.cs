using System;

namespace Pointers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int a = 5;
            unsafe
            {
                fixed(int* ptr_a = &a)
                {
                    
                }
            }

        }
    }
}
