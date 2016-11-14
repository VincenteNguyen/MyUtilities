using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    public class Class1
    {
        public static void Test1()
        {
            var dict = new Dictionary<int, int> {
                {1, 1000},
                {2, 2500},
                {3, 4000},
                {4, 5000},
                {5, 10000},
                {6, 40000},
            };
            var value = new Dictionary<int, int> {
                {1, 6},
                {2, 28},
                {3, 1},
                {4, 2},
                {5, 1},
                {6, 2}
            };
            var sum = 0;
            foreach(var item in value)
            {
                sum += item.Value * dict[item.Key];
            }
            Console.WriteLine(sum);
        }

        public static void Test2()
        {
            var list = new List<int> { 2, 1 };
            var test = string.Join("-", list.OrderBy(x=>x).Select(x=>x).ToList());
            var dict = new Dictionary<string, int> { { test, 0 } };
            Console.WriteLine(dict["1-2"]);
        }
    }
}
