using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToDir = "Example";
            if (!Directory.Exists(pathToDir))
            {
                Directory.CreateDirectory(pathToDir);
            }
            string fileName = "NewFile.txt";
            string pathToFile = pathToDir + "/" + fileName;
            if (!File.Exists(pathToFile))
            {
                File.Create(pathToFile);
            }
            int num = 10;
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(pathToFile, false))
            {
                for (int i = 0; i < num; i++)
                {
                    int intFromRandom = random.Next(0, 100);
                    sw.WriteLine(intFromRandom);
                }
            }
            int sum = 0;
            using (StreamReader sr = new StreamReader(pathToFile))
            {
                for (int i = 0; i < num; i++)
                {
                    int number = Convert.ToInt32(sr.ReadLine());
                    sum += number;
                    Console.WriteLine(number);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма чисел: {0}", sum);
            Console.ReadKey();
        }
    }
}
