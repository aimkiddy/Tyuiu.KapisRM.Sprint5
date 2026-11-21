using System;
using Tyuiu.KapisRM.Sprint5.Task5.V6.Lib;

namespace Tyuiu.KapisRM.Sprint5.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Капис Р.М | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask5V6.txt, в котором есть набор*");
            Console.WriteLine("* значений. Найти среднее значение всех вещественных (дробных) чисел      *");
            Console.WriteLine("* в файле. Полученный результат вывести на консоль. У вещественных        *");
            Console.WriteLine("* значений округлить до трёх знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\gipla\source\repos\Tyuiu.KapisRM.Sprint5\Tyuiu.KapisRM.Sprint5.Task5.V6\bin\Debug\InPutDataFileTask5V6.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine(File.ReadAllText(path));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Среднее значение дробных чисел = " + res);

            Console.ReadKey();
        }
    }
}