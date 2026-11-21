using System;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KapisRM.Sprint5.Task4.V15.Lib
{
    public class DataService : ISprint5Task4V15
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Trim().Replace(',', '.');
            double x = double.Parse(strX, CultureInfo.InvariantCulture);

            double y = Math.Sin(x) + Math.Pow(x, 2) / 2;
            return Math.Round(y, 3);
        }
    }
}