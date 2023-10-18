using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChalkovaE.M.Sprint3.Task2.V15.Lib
{
    public class DataService : ISprint3Task2V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SS = 0;
            do
            {
                SS = SS + ((Math.Pow(value, startValue) + 1 / 2) * Math.Cos(startValue));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(SS, 3);
        }
    }
}
