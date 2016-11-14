using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApplications
{
    public class Program
    {
        public class A { public List<B> Dice = new List<B> { new B { side = 1 }, new B { side = 4 }, new B { side = 2 } }; }
        public class B { public int side; }
        public static void Main(string[] args)
        {
            //var listSide = new List<int> { 1, 100, 103 };
            //var wheelItems = new List<int> { 1, 2, 3, 5, 100, 101, 102, 0 };
            //var test =  listSide.All(value => wheelItems.Contains(value));
            //var b = test;

            //var test1 = new Dictionary<int, SortedDictionary<decimal, List<int>>>
            //{
            //    {1, new SortedDictionary<decimal, List<int>> { {0.1m, new List<int> {1,2000} }, { 0.2m, new List<int> { 2, 5000 } } } }
            //};

            //var weight = test1[1];
            //var diceAndValues = weight.Values;

            //var diceValue = (from item in diceAndValues where item[0] == 2 select item[1]).FirstOrDefault();
            //var b = diceAndValues;


            //var test = new Dictionary<int, List<int>>
            //{
            //    {0, new List<int> {1,100,2,3 } },
            //    {1, new List<int> {1,2,3,4 } },
            //    {2, new List<int> {5,100,6,7, 100 } }
            //};
            //var count = test.Count(reel => reel.Value.Any(s => s == 100));
            //Console.WriteLine(count);
            //var a = new A();
            //var s = string.Join(",", a.Dice.Select(x => x.side));

            //var g = s.Split(',').Select(x => Convert.ToInt32(x)).ToList();
            //Console.WriteLine(s);

            ParseReelsStrip.GetReelsStrip();
            //ParseReelsStrip.GetReelsStrip2();
            //Class1.Test2();

            //            var dictionary = @"100	sm6
            //110	sm5
            //120	sm4
            //130	sm3
            //140	sm2
            //150	sm1
            //160	p4
            //170	p3
            //180	p2
            //190	p1
            //7	wild
            //8	scat
            //";
            //            var dictionary2 = (from line in dictionary.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
            //                               let seperatorIndex = line.IndexOf("\t", StringComparison.Ordinal)
            //                               let returnValue = line.Substring(seperatorIndex + 1, line.Length - seperatorIndex - 1).Trim()
            //                               where returnValue != "wild" && returnValue != "scat"
            //                               select new
            //                               {
            //                                   Key = line.Substring(seperatorIndex + 1, line.Length - seperatorIndex - 1).Trim(),
            //                                   Value = Convert.ToInt32(line.Substring(0, seperatorIndex)),
            //                               }).ToList().ToDictionary(x => x.Key, x => x.Value);
            //            var line2 = dictionary.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            //            var list2 = new StringBuilder(dictionary);
            //            var index = 12;
            //            foreach (var item in dictionary2)
            //            {
            //                var index = item.Value;
            //                for (int i = 1; i <= 6; i++)
            //                {
            //                    list2.AppendFormat("{0}\t{1}_r{2}", index + i, item.Key, i);
            //                    list2.AppendFormat(@"{0}", index++);
            //                    list2.Append("\t");
            //                    list2.AppendFormat(@"{0}", item);
            //                    list2.AppendLine();
            //                }
            //            }
            //            var b = list2.ToString();
        }


        
    }
}
