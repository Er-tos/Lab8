using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Работа/NextGIS/DTClassifier";
            string[] diresInParent;
            if (Directory.Exists(path))
            {
                Console.WriteLine("Содержимое папки, расположенной по дирректории: {0}", path);
                diresInParent = GetDirsFromDir(path);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Данной директории не существует!");
            }
            Console.ReadKey();
        }
        static string[] GetDirsFromDir(string path)
        {
            string[] dires = new string[0];
            string[] files = new string[0];
            if (Directory.Exists(path))
            {
                Console.WriteLine("В директории {0} найдено:", path);
                // Ищем папки в поданной директории
                dires = Directory.GetDirectories(path);
                if (dires.Length > 0)
                {
                    foreach (string dir in dires)
                    {
                        Console.WriteLine("     - найдена папка     {0}", dir);
                    }
                }
                // Ищем файлы в поданной директории
                files = Directory.GetFiles(path);
                if (files.Length > 0)
                {
                    foreach (string file in files)
                    {
                        Console.WriteLine("     - найден файл     {0}", file);
                    }
                }
                if (dires.Length > 0)
                {
                    foreach (string dir in dires)
                    {
                        GetDirsFromDir(dir);
                    }
                }
            }
            return dires;
        }
    }
}
