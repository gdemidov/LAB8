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
            //File.Create(path+filepath);

            // создание массива случайных чисел
            const int n = 10;
            int[] array = new int[n];
            string str = "";
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write("{0} ", array[i]);// для проверки выводим на консоль
                str += array[i]+" "; //превращаем в строку разделитель  пробел
            }
            Console.WriteLine();

            //записываем в файл
            using (StreamWriter sw = new StreamWriter((path + filepath), false))
            {
                sw.WriteLine(str);
            }
            //считываем из файла
            using (StreamReader sr = new StreamReader(path + filepath))
            {
                str = sr.ReadLine();
            }
            

            //выводим на экран
            
            Console.Write("{0} ", str);
            Console.ReadKey();
        }
    }
}
