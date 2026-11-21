using System;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KapisRM.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] parts = text.Split(new char[] { ' ', '\n', '\r', '\t', ';' },
                                        StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            int count = 0;

            foreach (string part in parts)
            {
                string s = part.Trim().Replace(',', '.');
                double value;

                if (double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
                {
                    if (value % 1 != 0)
                    {
                        sum += Math.Round(value, 3);
                        count++;
                    }
                }
            }

            if (count == 0)
            {
                return 0;
            }

            return Math.Round(sum / count, 3);
        }
    }
}