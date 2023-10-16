using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChalkovaE.M.Sprint3.Task0.V18.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint3.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнила: Чалкова Е. М. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмическая структура цикла for                                ");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила Чалкова Е. М. | ИИПб-23-2                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет                *");
            Console.WriteLine("* произведение ряда по формуле, при X=1                                   *");
            Console.WriteLine("*     6          2         k                                              *");
            Console.WriteLine("* р = П (-----------------)                                               *");
            Console.WriteLine("*    k=1    cos x + 0.5                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 1;
            int startValue = 1;
            int stopValue = 6;
            Console.WriteLine("Переменная Х = " + x);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Произведение ряда с количеством повторений {stopValue} = " + ds.GetSumSeries(startValue, stopValue));

            Console.ReadKey();
        }
    }
}