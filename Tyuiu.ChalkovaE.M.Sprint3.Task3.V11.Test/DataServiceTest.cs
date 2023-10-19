using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChalkovaE.M.Sprint3.Task3.V11.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint3.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();

            string value = "qaqaqaqaq";
            char replaceable = 'q';
            char replacement = '7';

            string res = ds.ReplaceCharOnNum(value, replaceable, replacement);
            string wait = "7a7a7a7a7";

            Assert.AreEqual(wait, res);
        }
    }
}
