using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Windows/";
            string[] dirs = Directory.GetDirectories(path);
            Console.WriteLine("{0}", dirs.Length);
            foreach (string dir in dirs)
            {
                Console.WriteLine("{0}", dir);
                string[] subdirs = Directory.GetDirectories(dir);
                int n = subdirs.Length;
                foreach (string subdir in subdirs)
                {
                    Console.WriteLine("{0}", subdir);
                    Console.WriteLine("Всего ПОД-подкаталогов: {0}", subdir.Length);
                }
            }
            Console.ReadKey();
        }
    }
}
