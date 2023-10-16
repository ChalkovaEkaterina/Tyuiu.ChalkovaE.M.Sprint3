using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChalkovaE.M.Sprint3.Task0.V18.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint3.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 6;
            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 914700.94;
            Assert.AreEqual(wait, res);
        }
    }
}
