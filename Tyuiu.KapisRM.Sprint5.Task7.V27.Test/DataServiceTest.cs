using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint5.Task7.V27.Lib;

namespace Tyuiu.KapisRM.Sprint5.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\gipla\source\repos\Tyuiu.KapisRM.Sprint5\Tyuiu.KapisRM.Sprint5.Task7.V27\bin\Debug\InPutDataFileTask7V27.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

            DataService ds = new DataService();
            string pathSave = ds.LoadDataAndSave(path);

            Assert.AreEqual(true, File.Exists(pathSave));
            Assert.AreEqual("Этострокаспробелами", File.ReadAllText(pathSave));
        }
    }
}