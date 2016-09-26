using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    public static class ParseReelsStrip
    {
        public static string GetReelsStrip()
        {
            var reelsStrip = @"Cracker
Orange
Jack
Ace
Orange
King
Queen
Coin
Dragon
Ace
Ten
Red Packet
Orange
Jack
Red Packet
Lantern
Ten
Red Packet
Coin
Ace
Red Packet
Sword
Jack
Queen
Red Packet
Cracker
Jack
Ace
Cracker
Queen
Red Packet
Cracker
Queen
Lantern
Sword
Jack
".ToListExt();
            var dictionary = @"0	Ten
1	Jack
2	Queen
3	King
4	Ace
5	Sword
6	Red Packet
7	Cracker
8	Orange
9	Lantern
10	Dragon
11	Coin
12	Wild
".ToDictionaryExt();
            var sb = new StringBuilder();
            foreach(var item in reelsStrip)
            {
                sb.Append(dictionary[item]);
                sb.Append(",");
            }
            sb.Length--;

            var value = sb.ToString();
            return value;
        }
        private static Dictionary<string, int> ToDictionaryExt(this string parameter)
        {
            return (from line in parameter.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                    let seperatorIndex = line.IndexOf("\t", StringComparison.Ordinal)
                    select new 
                    {
                        Key = line.Substring(seperatorIndex + 1, line.Length - seperatorIndex - 1).Trim(),
                        Value = Convert.ToInt32(line.Substring(0, seperatorIndex)),
                    }).ToList().ToDictionary(x=>x.Key, x=>x.Value);
        }
        private static List<string> ToListExt(this string parameter)
        {
            return (from line in parameter.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                    select line).ToList();
        }
    }
}
