using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IsaevMA.Sprint3.Task0.V26.Lib;

namespace Tyuiu.IsaevMA.Sprint3.Task0.V26
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
            Console.WriteLine("* Задание #0                                                                                                         *");
            Console.WriteLine("* Вариант #26                                                                                                        *");
            Console.WriteLine("* Выполнил: Исаев Максим Александрович | ACOиУБ-23-3                                                                 *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("*Написать программу используя цикл for, которая вычисляет произведение ряда по формуле                               *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            int startValue = 1;
            int stopValue = 9;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(startValue,stopValue));
            Console.ReadKey();
        }
    }
}
