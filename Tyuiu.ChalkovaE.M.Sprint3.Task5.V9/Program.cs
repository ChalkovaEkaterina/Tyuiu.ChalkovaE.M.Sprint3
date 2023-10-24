using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChalkovaE.M.Sprint3.Task5.V9.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint3.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнила: Чалкова Е. М. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмическая структура цикла while                             *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила Чалкова Е. М. | ИИПб-23-2                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя вложенные циклы, которая вычисляет         *");
            Console.WriteLine("* сумму сумм ряда по формуле, при x=5                                     *");
            Console.WriteLine("*     3   14     1                                                        *");
            Console.WriteLine("* y = E    E   ------ + x                                                 *");
            Console.WriteLine("*    i=1  k=1  sin(k)                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 14; 
            Console.WriteLine("Переменная Х = " + x);
            Console.WriteLine("Старт шага 1 = " + startValue1);
            Console.WriteLine("Старт шага 2 = " + startValue1);
            Console.WriteLine("Конец шага 1 = " + stopValue1);
            Console.WriteLine("Конец шага 2 = " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма сумм ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

            Console.ReadKey();
        }
    }
}
