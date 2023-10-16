using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChalkovaE.M.Sprint3.Task0.V18.Lib
{
    public class DataService : ISprint3Task0V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            int x = 1;
            double p = 1;
            stopValue = 6;
            for (startValue = 1; startValue <= stopValue; startValue++)
            {
                p *= Math.Pow((2 / (Math.Cos(x) + 0.5)), startValue);
            }
            return Math.Round(p, 3);
        }
    }
}
