using System;
using System.IO;
using Tyuiu.KapisRM.Sprint5.Task7.V27.Lib;

namespace Tyuiu.KapisRM.Sprint5.Task7.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Капис Р.М | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту 5               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Капис Р. М. | СМАРТб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл с набором символьных данных. Удалить все пробелы, идущие       *");
            Console.WriteLine("* подряд больше одного. Полученный результат сохранить в файл             *");
            Console.WriteLine("* OutPutDataFileTask7V27.txt.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\gipla\source\repos\Tyuiu.KapisRM.Sprint5\Tyuiu.KapisRM.Sprint5.Task7.V27\bin\Debug\InPutDataFileTask7V27.txt";
            Console.WriteLine("Находится в файле: " + path);

            if (File.Exists(path))
            {
                Console.WriteLine("Исходные данные:");
                Console.WriteLine(File.ReadAllText(path));
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string pathSave = ds.LoadDataAndSave(path);
            Console.WriteLine("Файл: " + pathSave);
            Console.WriteLine("Создан!");
            Console.WriteLine("Результат:");
            Console.WriteLine(File.ReadAllText(pathSave));

            Console.ReadKey();
        }
    }
}