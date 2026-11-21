using System;
using Tyuiu.KapisRM.Sprint5.Task4.V15.Lib;

namespace Tyuiu.KapisRM.Sprint5.Task4.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Капис Р.М | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Капис Р. М. | СМАРТб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask4V15.txt, в котором есть      *");
            Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо  *");
            Console.WriteLine("* X в формуле y = sin(x) + x^2 / 2. Вычислить значение по формуле         *");
            Console.WriteLine("* (округлить до трёх знаков после запятой) и вернуть результат на консоль.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\gipla\source\repos\Tyuiu.KapisRM.Sprint5\Tyuiu.KapisRM.Sprint5.Task4.V15\bin\Debug\InPutDataFileTask4V15.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("Значение в файле: " + File.ReadAllText(path));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("y = " + res);

            Console.ReadKey();
        }
    }
}