﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.IsaevMA.Sprint3.SprintReview.V27.Lib;

namespace Tyuiu.IsaevMA.Sprint3.SprintReview.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Исаев М. А. | ACОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                          *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                                            *");
            Console.WriteLine("* Задание #SprintReview                                                                                              *");
            Console.WriteLine("* Вариант #27                                                                                                        *");
            Console.WriteLine("* Выполнил: Исаев Максим Александрович | ACOиУБ-23-3                                                                 *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функций: f(x) на заданном диапазоне [-5;5]                    *");
            Console.WriteLine("* с шагом 1. Произвести проверку деления на ноль. При делении на ноль вернуть значение 0.                            *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    f(x)   |");
            Console.WriteLine("+----------+-----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,6:f2}   |", startValue, valueArray[i]);
                startValue++;
            }

            Console.WriteLine("+----------+-----------+");

            Console.ReadKey();
        }
    }
}