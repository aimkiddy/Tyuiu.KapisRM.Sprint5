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
            byte[] res = ds.SaveToFileTextData(3);

            byte[] wait = BitConverter.GetBytes(3.375);
            CollectionAssert.AreEqual(wait, res);

            double y = BitConverter.ToDouble(res, 0);
            Assert.AreEqual(3.375, y);
        }
    }
}