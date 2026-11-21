using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint5.Task2.V22.Lib;

namespace Tyuiu.KapisRM.Sprint5.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[3, 3] { { -8, -1, -9 },
                                          {  8,  5,  5 },
                                          {  9,  6, -2 } };

            string path = ds.SaveToFileTextData(mtrx);

            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);

            string res = File.ReadAllText(path);
            string wait = "0;0;0" + Environment.NewLine +
                          "1;1;1" + Environment.NewLine +
                          "1;1;0";

            Assert.AreEqual(wait, res);
        }
    }
}