using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChalkovaE.M.Sprint2.Task6.V2.Lib;
namespace Tyuiu.ChalkovaE.M.Sprint2.Task6.V2
{
    class Program
    {
        static void Main()
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнила: Чалкова Е. М. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                    *");
            Console.WriteLine("* Тема: Получение результата из switch                                         *");
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #2                                                                   *");
            Console.WriteLine("* Выполнила Чалкова Е. М. | ИИПб-23-2                                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора    *");
            Console.WriteLine("* switch вычисляет требуемое значение и возвращает результат.                  *");
            Console.WriteLine("* По данному месяцу, определите в какую пору года попадает                     *");
            Console.WriteLine("* этот месяц (Зима, Лето, Весна, Осень).                                       *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите месяц: ");
            int value = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            if (value >= 1 && value <= 12)
            {
                string res = ds.FindMonthSeason(value);
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
