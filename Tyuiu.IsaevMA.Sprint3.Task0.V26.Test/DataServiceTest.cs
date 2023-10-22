using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IsaevMA.Sprint3.Task0.V26.Lib;

namespace Tyuiu.IsaevMA.Sprint3.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 9;

            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = -15.6421970082033;

            Assert.AreEqual(res, wait);
        }
    }
}
