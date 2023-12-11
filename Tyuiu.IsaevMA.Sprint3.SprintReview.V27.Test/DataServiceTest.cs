using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IsaevMA.Sprint3.SprintReview.V27.Lib;

namespace Tyuiu.IsaevMA.Sprint3.SprintReview.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = 3.57;
            valueWaitArray[1] = 5.01;
            valueWaitArray[2] = 5.62;
            valueWaitArray[3] = 4.75;
            valueWaitArray[4] = 2.76;
            valueWaitArray[5] = 0;
            valueWaitArray[6] = 3.84;
            valueWaitArray[7] = 4.33;
            valueWaitArray[8] = 4.96;
            valueWaitArray[9] = 4.69;
            valueWaitArray[10] = 3.69;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
