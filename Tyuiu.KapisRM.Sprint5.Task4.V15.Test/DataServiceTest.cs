using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint5.Task4.V15.Lib;

namespace Tyuiu.KapisRM.Sprint5.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\gipla\source\repos\Tyuiu.KapisRM.Sprint5\Tyuiu.KapisRM.Sprint5.Task4.V15\bin\Debug\InPutDataFileTask4V15.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(5.878, res);
        }
    }
}