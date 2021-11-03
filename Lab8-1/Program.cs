using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs/";
            DirectoryInfo directory = new DirectoryInfo(path);
            if (!directory.Exists)
            {
                directory.Create();
            }
            string filepath = "rd.txt";
            File.Create(path+filepath);
            if (!File.Exists(path + filepath))
            {
                File.Create(path + filepath);
            }
            Console.WriteLine("файл создан {0}", (path + filepath));
            StreamWriter sw = new StreamWriter((path + filepath),true);
            sw.WriteLine("11");
            sw.Close();
            Console.ReadKey();
        }
    }
}
