using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChalkovaE.M.Sprint3.Task1.V19.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint3.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValigGetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 1;
            int startValue = 1;
            int stopValue = 9;


            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 13.863;

            Assert.AreEqual(wait, res);
        }
    }
}
