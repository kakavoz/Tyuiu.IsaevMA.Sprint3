using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IsaevMA.Sprint3.Task1.V17.Lib;

namespace Tyuiu.IsaevMA.Sprint3.Task1.V17
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил:  Исаев.М.А. | ACОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                          *");
            Console.WriteLine("* Тема: Оператор цикла for                                                                                           *");
            Console.WriteLine("* Задание #1                                                                                                         *");
            Console.WriteLine("* Вариант #17                                                                                                        *");
            Console.WriteLine("* Выполнил: Исаев Максим Александрович | ACOиУБ-23-3                                                                 *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("*Написать программу используя цикл while, которая вычисляет произведение ряда по формуле, при х=1                    *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");
            int value = 1;
            int startValue = 1;
            int stopValue = 4;
            Console.WriteLine("значение x = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value,startValue, stopValue));
            Console.ReadKey();
        }
    }
}
