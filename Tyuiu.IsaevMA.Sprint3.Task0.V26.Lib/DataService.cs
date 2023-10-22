using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.IsaevMA.Sprint3.Task0.V26.Lib
{
    public class DataService : ISprint3Task0V26
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiplySeries = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                multiplySeries = multiplySeries * ((Math.Pow(2, i) / (i + 1)) * Math.Cos(1.8));
            }
            return multiplySeries;
            throw new NotImplementedException();
        }
    }
}