using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IsaevMA.Sprint3.Task1.V17.Lib;

namespace Tyuiu.IsaevMA.Sprint3.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 4;

            double res = ds.GetMultiplySeries(value,startValue, stopValue);
            double wait = 482982.89090945;

            Assert.AreEqual(res, wait);
        }
    }
}

