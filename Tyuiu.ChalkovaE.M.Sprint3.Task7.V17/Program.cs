using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChalkovaE.M.Sprint3.Task7.V17.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint3.Task7.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнила: Чалкова Е. М. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнила Чалкова Е. М. | ИИПб-23-2                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("*         sin (x)                                                         *");
            Console.WriteLine("* F(x) = --------- - cos (x) * 4x - 6                                     *");
            Console.WriteLine("*         x + 1,7                                                         *");
            Console.WriteLine("* в заданном диапазоне [-5; 5]                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Начало диапазона = " + startValue);
            Console.WriteLine("Конец диапазона = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+-----------------+-----------------+");
            Console.WriteLine("|       X         |       F(x)      |");
            Console.WriteLine("+-----------------+-----------------+");
            for (int i = 0; i <= len - 1; i++) 
            {
                Console.WriteLine("|{0,5:d}           |  {1,  6:f2}         |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+-----------------+-----------------+");
            Console.ReadKey();
        }
    }
}
