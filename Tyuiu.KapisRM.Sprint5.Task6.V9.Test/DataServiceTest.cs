using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint5.Task6.V9.Lib;

namespace Tyuiu.KapisRM.Sprint5.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\gipla\source\repos\Tyuiu.KapisRM.Sprint5\Tyuiu.KapisRM.Sprint5.Task6.V9\bin\Debug\InPutDataFileTask6V9.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

            DataService ds = new DataService();
            int res = ds.LoadFromDataFile(path);
            Assert.AreEqual(2, res);
        }
    }
}