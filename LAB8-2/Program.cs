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
            string path = "C:/Windows";
            string[] dirs = Directory.GetDirectories(path);
            Console.WriteLine("всего директорий {0}", dirs.Length);
            foreach (string dir in dirs)
            {
                string[] subdirs = Directory.GetDirectories(dir);
                Console.WriteLine("{0}", dir);
                Console.WriteLine("Всего поддерикторий: {0}", dir.Length);
                foreach (string subdir in subdirs)
                {
                      Console.WriteLine("поддериктория: {0}", subdir);
                      Console.WriteLine("Всего под-поддерикторий: {0}", subdir.Length);
                }
            }
            Console.ReadKey();
        }
    }
}
