using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KapisRM.Sprint5.Task6.V9.Lib
{
    public class DataService : ISprint5Task6V9
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            char[] separators = { ' ', '\n', '\r', '\t', ',', '.', '!', '?', ';', ':', '-', '–', '—', '(', ')', '"' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;
            foreach (string word in words)
            {
                if (word.Length == 3)
                {
                    count++;
                }
            }

            return count;
        }
    }
}