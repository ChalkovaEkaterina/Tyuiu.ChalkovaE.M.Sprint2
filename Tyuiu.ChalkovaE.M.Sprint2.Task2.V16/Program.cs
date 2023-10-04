using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChalkovaE.M.Sprint2.Task2.V8.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint2.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнила: Чалкова Е.М. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                    *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                           *");
            Console.WriteLine("* Задание #2                                                                   *");
            Console.WriteLine("* Вариант #8                                                                   *");
            Console.WriteLine("* Выполнила Чалкова Е.М. | ИИПб-23-2                                           *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры       *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной области.  *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            
            Console.WriteLine("Введите значение переменной X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            bool result = ds.CheckDotInShadedArea(x, y);
            
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            if (result == true)
            {
                Console.WriteLine($"Точка с координатами ({x};{y}) находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x};{y}) НЕ находится в заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}
