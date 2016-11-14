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
            var reelsStrip = @"sm6
p3
p1
sm6
p1_r1
sm2
sm6
p2
scat
p1_r2
p4
p3
sm1
p4
p1_r3
p1
sm1
p3
sm2
p1_r4
p4
sm1
p2
sm2
p1_r5
p3
sm1
p4
p3
p1_r6
scat
sm3
sm2
sm4
sm2
p2_r1
sm3
sm1
sm5
sm2
p2_r2
sm1
sm3
sm6
sm4
p2_r3
sm3
sm5
sm6
sm4
p2_r4
scat
sm5
sm5
p4
sm1
p2_r5
p2
sm2
p3
sm1
p2_r6
p4
p3
sm3
sm2
p3_r1
sm4
sm2
sm3
sm1
p3_r2
scat
sm5
sm2
sm1
sm3
p3_r3
sm6
sm4
sm3
sm5
p3_r4
sm6
sm4
sm5
sm5
p3_r5
sm6
sm4
sm3
sm4
p3_r6
scat
sm1
sm4
sm3
sm4
p4_r1
sm6
sm3
sm4
sm1
p4_r2
sm3
sm1
sm3
sm6
p4_r3
sm4
sm5
sm6
p4
p4_r4
scat
sm6
sm3
sm4
sm1
p4_r5
sm6
sm3
sm4
sm1
p4_r6
sm6
sm3
sm4
sm1
sm1_r1
sm6
sm3
sm4
sm1
sm1_r2
scat
sm6
sm3
sm4
sm1
sm1_r3
sm6
sm3
sm4
sm1
sm1_r4
scat
sm6
sm3
sm4
sm1
sm1_r5
sm6
sm3
sm4
sm1
sm1_r6
sm6
sm3
sm4
sm1
sm2_r1
sm6
sm3
sm4
sm1
sm2_r2
scat
sm6
sm3
sm4
sm1
sm2_r3
sm6
sm2
sm6
p2
sm2_r4
scat
p4
p3
sm1
sm2_r5
p4
p1
sm1
p3
sm2_r6
scat
sm2
p4
sm1
p2
sm3_r1
sm2
p3
sm1
p4
sm3_r2
p3
sm3
sm2
sm4
sm3_r3
sm2
sm3
sm1
sm5
sm3_r4
sm2
sm1
sm3
sm6
sm3_r5
sm4
sm3
sm5
sm6
sm3_r6
scat
sm4
sm5
sm5
p4
sm4_r1
sm1
p2
sm2
p3
sm4_r2
sm1
p4
p3
sm3
sm4_r3
sm2
sm4
sm2
sm3
sm4_r4
scat
sm1
sm5
sm2
sm1
sm4_r5
sm3
sm6
sm4
sm3
sm4_r6
sm5
sm6
sm4
sm5
sm5_r1
sm5
sm6
sm4
sm3
sm5_r2
scat
sm4
sm1
sm4
sm3
sm5_r3
sm4
sm6
sm3
sm4
sm5_r4
sm1
sm3
sm1
sm3
sm5_r5
sm6
sm4
sm5
sm6
sm5_r6
p4
sm1
sm1
sm3
sm6_r1
sm1
sm3
sm6
sm4
sm6_r2
scat
sm5
sm6
p4
sm1
sm6_r3
sm1
sm3
sm1
sm3
sm6_r4
sm6
sm4
sm5
sm6
sm6_r5
p4
sm1
sm4
sm5
sm6_r6
wild
p3
p1
sm6
sm2
sm6
p2
scat
p4
p3
sm1
p4
p1
sm1
p3
sm2
p4
sm1
p2
sm2
scat
p3
sm1
p4
p3
sm3
sm2
sm4
sm2
sm3
sm1
sm5
sm2
sm1
sm3
sm6
sm4
sm3
sm5
sm6
sm4
scat
sm5
sm5
p4
sm1
p2
sm2
p3
sm1
p4
p3
sm3
sm2
sm4
sm2
sm3
sm1
sm5
sm2
sm1
sm3
sm6
sm4
sm3
sm5
sm6
sm4
sm5
sm5
sm6
sm4
sm3
sm4
sm1
sm4
sm3
sm4
sm6
sm3
sm4
sm1
sm3
sm1
sm3
sm6
sm4
sm5
sm6
p4
sm1
".ToListExt();
            var dictionary = @"100	sm6
110	sm5
120	sm4
130	sm3
140	sm2
150	sm1
160	p4
170	p3
180	p2
190	p1
70	wild
80	scat
101	sm6_r1
102	sm6_r2
103	sm6_r3
104	sm6_r4
105	sm6_r5
106	sm6_r6
111	sm5_r1
112	sm5_r2
113	sm5_r3
114	sm5_r4
115	sm5_r5
116	sm5_r6
121	sm4_r1
122	sm4_r2
123	sm4_r3
124	sm4_r4
125	sm4_r5
126	sm4_r6
131	sm3_r1
132	sm3_r2
133	sm3_r3
134	sm3_r4
135	sm3_r5
136	sm3_r6
141	sm2_r1
142	sm2_r2
143	sm2_r3
144	sm2_r4
145	sm2_r5
146	sm2_r6
151	sm1_r1
152	sm1_r2
153	sm1_r3
154	sm1_r4
155	sm1_r5
156	sm1_r6
161	p4_r1
162	p4_r2
163	p4_r3
164	p4_r4
165	p4_r5
166	p4_r6
171	p3_r1
172	p3_r2
173	p3_r3
174	p3_r4
175	p3_r5
176	p3_r6
181	p2_r1
182	p2_r2
183	p2_r3
184	p2_r4
185	p2_r5
186	p2_r6
191	p1_r1
192	p1_r2
193	p1_r3
194	p1_r4
195	p1_r5
196	p1_r6
".ToDictionaryExt();
            var sb = new StringBuilder();
            foreach(var item in reelsStrip)
            {
                sb.Append(dictionary[item]);
                sb.Append(",");
            }
            sb.Length--;

            var value = sb.ToString();
            //Console.WriteLine(value);
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

        public static string GetReelsStrip2()
        {
            var reelsStrip = @"Lin
Jia
Incense
Jewellery
Jia
Powder
Incense
Jade
Lin
Mirror
Grandmother
Koi
Incense
Jade
Mirror
Grandmother
Koi
Lin
Powder
Grandmother
Jewellery
Mirror
Incense
Jewellery
Grandmother
Mirror
Jade
Koi
Mirror
".ToListExt();
            var dictionary = @"0	Koi
1	Incense
2	Mirror
3	Powder
4	Jewellery
5	Jade
6	Grandmother
7	Lin
8	Jia
9	Book
10	Rim
11	Screen
".ToDictionaryExt();
            var sb = new StringBuilder();
            foreach (var item in reelsStrip)
            {
                sb.Append(dictionary[item]);
                sb.Append(",");
            }
            sb.Length--;

            var value = sb.ToString();
            //Console.WriteLine(value);
            return value;
        }
    }
}
