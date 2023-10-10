using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChalkovaE.M.Sprint2.Task5.V15.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint2.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнила: Чалкова Е. М. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                    *");
            Console.WriteLine("* Тема: Оператор switch                                                        *");
            Console.WriteLine("* Задание #5                                                                   *");
            Console.WriteLine("* Вариант #15                                                                  *");
            Console.WriteLine("* Выполнила Чалкова Е. М. | ИИПб-23-2                                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет требуемое   *");
            Console.WriteLine("* значение и возвращает результат. Дано целое число k(1 <= k <= 365).          *");
            Console.WriteLine("* Определить, каким днем недели является k-й день не високосного года,         *");
            Console.WriteLine("* в котором 1 января понедельник.                                              *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите целое число:");
            int value = Convert.ToInt32(Console.ReadLine());
            string res = ds.FindDayName(value);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            if (value >= 1 && value <= 365)
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine($"Неправильное значение, {value}");
            }
            Console.ReadKey();
        }
    }
}
