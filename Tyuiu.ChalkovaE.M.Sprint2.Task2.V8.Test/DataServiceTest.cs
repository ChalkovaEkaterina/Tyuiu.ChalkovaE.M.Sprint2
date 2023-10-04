using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChalkovaE.M.Sprint2.Task2.V8.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint2.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 4;
            int y = 4;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
