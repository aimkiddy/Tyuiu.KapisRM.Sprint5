using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint5.Task1.V17.Lib;

namespace Tyuiu.KapisRM.Sprint5.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5);

            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);

            string[] lines = File.ReadAllLines(path);

            Assert.AreEqual(11, lines.Length);
            Assert.AreEqual(System.Convert.ToString(-19.62), lines[0]);
            Assert.AreEqual(System.Convert.ToString(-5.0), lines[5]);
            Assert.AreEqual(System.Convert.ToString(225.11), lines[10]);
        }
    }
}