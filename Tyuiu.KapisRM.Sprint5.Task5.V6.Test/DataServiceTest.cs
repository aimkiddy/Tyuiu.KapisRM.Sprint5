using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint5.Task5.V6.Lib;

namespace Tyuiu.KapisRM.Sprint5.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\gipla\source\repos\Tyuiu.KapisRM.Sprint5\Tyuiu.KapisRM.Sprint5.Task5.V6\bin\Debug\InPutDataFileTask5V6.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(6.997, res);
        }
    }
}