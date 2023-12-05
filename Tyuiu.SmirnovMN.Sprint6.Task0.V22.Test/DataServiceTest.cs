using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint6.Task0.V22.Lib;

namespace Tyuiu.SmirnovMN.Sprint6.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2);
            double wait = 8.88;
            Assert.AreEqual(wait, res);
        }
    }
}
