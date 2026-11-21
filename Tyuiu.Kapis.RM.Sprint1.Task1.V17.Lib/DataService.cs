using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KapisRM.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;
                double d = Math.Sin(x) + 1;

                if (d == 0)
                {
                    y = 0;
                }
                else
                {
                    y = 2 * x - 4 + (2 * x - 1) / d;
                }

                y = Math.Round(y, 2);

                string str = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
            }

            return path;
        }
    }
}