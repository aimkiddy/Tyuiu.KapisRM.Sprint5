using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint5.Task3.V9.Lib;

namespace Tyuiu.KapisRM.Sprint5.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            string res = ds.SaveToFileTextData(3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);

            string wait = Convert.ToBase64String(BitConverter.GetBytes(3.375));
            Assert.AreEqual(wait, res);

            double y;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                y = reader.ReadDouble();
            }
            Assert.AreEqual(3.375, y);
        }
    }
}