using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUtilities.Services
{
    public class StringServices
    {
        public static string Between
        {
            get { return @"        public static string Between(this string value, string a, string b)
        {
            var posA = value.IndexOf(a, StringComparison.Ordinal);
            var stringFromPosA = value.Substring(posA);
            var posB = stringFromPosA.IndexOf(b, StringComparison.Ordinal);
            if (posA == -1)
            {
                return string.Empty;
            }
            if (posB == -1)
            {
                return string.Empty;
            }
            return posA >= posB ? string.Empty : value.Substring(posA, posB + b.Length);
        }"; }
        }

        public static string Before
        {
            get
            {
                return @"        public static string Before(this string value, string a)
        {
            var posA = value.IndexOf(a, StringComparison.Ordinal);
            return posA == -1 ? string.Empty : value.Substring(0, posA);
        }";
            }
        }

        public static string After
        {
            get
            {
                return @"        public static string After(this string value, string a)
        {
            var posA = value.LastIndexOf(a, StringComparison.Ordinal);
            if (posA == -1)
            {
                return string.Empty;
            }
            var adjustedPosA = posA + a.Length;
            return adjustedPosA >= value.Length ? string.Empty : value.Substring(adjustedPosA);
        }";
            }
        }

        public static string Contains
        {
            get
            {
                return @"        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }";
            }
        }

        public static string Substring
        {
            get
            {
                return @"        public static string Substring(this string source, string a, string b)
        {
            var subStringFromA = source.Substring(source.IndexOf(a, StringComparison.Ordinal));
            var indexBFromA = subStringFromA.IndexOf(b, StringComparison.Ordinal);
            var substringFromAtoB = subStringFromA.Substring(0, indexBFromA + b.Length);
            return substringFromAtoB;
        }";
            }
        }
    }
}
