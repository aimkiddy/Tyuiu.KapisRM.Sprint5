using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KapisRM.Sprint5.Task3.V9.Lib
{
    public class DataService : ISprint5Task3V9
    {
        public byte[] SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();

            double y = Math.Pow(x, 3) / (Math.Pow(x, 2) - 1);
            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(y);
            }

            return File.ReadAllBytes(path);
        }

        string ISprint5Task3V9.SaveToFileTextData(int x)
        {
            return Convert.ToBase64String(SaveToFileTextData(x));
        }
    }
}