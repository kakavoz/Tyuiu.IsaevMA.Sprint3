﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IsaevMA.Sprint3.SprintReview.V27.Lib
{
    public class DataService : ISprint3Task7V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Cos(x)/x+1) - Math.Cos(x) * 1,3 +(3*x));
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
