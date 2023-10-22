using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.IsaevMA.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            while (startValue <= stopValue)
            {
                multiplySeries = multiplySeries * Math.Pow(2 / Math.Cos(value), startValue);
                startValue++;
            }
            return multiplySeries;
        }
    }
}
    
