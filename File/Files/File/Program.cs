using System;
using System.IO;

// dont forget to close buffers and filestreams.
// otherwise it wont return text from file and save it to file.

namespace Fileq
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string path = "./text.txt";

            using(FileStream file = File.Open(path, FileMode.OpenOrCreate))
            {
                if (File.Exists(path)) Console.WriteLine("Exists");
                else return;

                StreamWriter write = new StreamWriter(file);
                write.WriteLine("Heyy");
                write.WriteLine("Heyy twice");
                write.Close();
                file.Close();
            }

            using (FileStream f = File.Open(path, FileMode.OpenOrCreate))
            {
                StreamReader read = new StreamReader(f);
                Console.WriteLine(read.ReadToEnd());
                read.Close();
                f.Close();
            }

        }
    }
}
