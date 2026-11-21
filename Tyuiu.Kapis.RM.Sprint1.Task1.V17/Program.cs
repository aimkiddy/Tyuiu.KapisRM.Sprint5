using System;
using System.IO;
using Tyuiu.KapisRM.Sprint5.Task1.V17.Lib;

namespace Tyuiu.KapisRM.Sprint5.Task1.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Капис Р.М | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Капис Р. М. | СМАРТб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = 2x - 4 + (2x - 1) / (sin(x) + 1). Произвести        *");
            Console.WriteLine("* табулирование f(x) на диапазоне [-5; 5] с шагом 1. Произвести проверку  *");
            Console.WriteLine("* деления на ноль, при делении на ноль вернуть 0. Результат сохранить     *");
            Console.WriteLine("* в файл OutPutFileTask1.txt и вывести на консоль в таблицу.              *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue  = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Создан!");
            Console.WriteLine();

            string[] lines = File.ReadAllLines(path);

            Console.WriteLine("+----------+------------+");
            Console.WriteLine("|    X     |    F(x)    |");
            Console.WriteLine("+----------+------------+");

            int x = startValue;
            foreach (string line in lines)
            {
                Console.WriteLine($"|{x,9} |{line,11} |");
                x++;
            }

            Console.WriteLine("+----------+------------+");

            Console.ReadKey();
        }
    }
}