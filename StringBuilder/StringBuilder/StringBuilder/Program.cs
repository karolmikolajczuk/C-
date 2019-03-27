using System;
using System.Text;

// StringBuilder doesnt create another object when modyfing an object like
// string class does.

// StringBuilder saves memory


namespace StringBuilderq
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // create objects
            string a = "hey";
            StringBuilder sb = new StringBuilder("heyy");

            // print them
            Console.WriteLine(a);
            Console.WriteLine(sb);

            // modify, where STRING will have another memory address
            // and stringbuilder will have the same one
            a += "HEEEEEEY";
            sb.Append("HHHHHHHH");

            // print values, where each one will be a correctly modyfied
            // no costly conversion and stuff
            Console.WriteLine(a);
            Console.WriteLine(sb);
        }
    }
}
