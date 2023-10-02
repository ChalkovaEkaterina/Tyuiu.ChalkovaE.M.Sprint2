using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ChalkovaE.M.Sprint2.Task0.V2.Lib
{
    public class DataService : ISprint2Task0V2
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            
            res[0] = x + 1 == y;
            res[1] = x + 1 != y;
            res[2] = x < y;
            res[3] = x + 1 > y;
            res[4] = x + 10 <= y;
            res[5] = x + 10 >= y;

            return res;
        }
    }
}
