using MyUtilities.Extensions;
using MyUtilities.Models;
using System;
using System.Linq;

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

        public static string RemoveDiacritics
        {
            get
            {
                return @"        public static string RemoveDiacritics(this string s)
        {
            var normalizedString = s.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();
            foreach (var c in normalizedString)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }
            return stringBuilder.ToString();
        }";
            }
        }

        public static StringExtensionModel GetStringExtension(string methodName)
        {
            var model = new StringExtensionModel { Name = methodName };
            switch (methodName)
            {
                case "Between":
                    model.SourceCode = Between;
                    break;
                case "Before":
                    model.SourceCode = Before;
                    break;
                case "After":
                    model.SourceCode = After;
                    break;
                case "Contains":
                    model.SourceCode = Contains;
                    break;
                case "Substring":
                    model.SourceCode = Substring;
                    break;
                case "RemoveDiacritics":
                    model.SourceCode = RemoveDiacritics;
                    break;
                default:
                    return null;
            }
            return model;
        }

        public static string ExecuteMethod(StringExtensionModel model)
        {
            string result;
            switch (model.Name)
            {
                case "Between":
                    result = model.SourceValue.Between(model.FromA, model.ToB);
                    break;
                case "Before":
                    result = model.SourceValue.Before(model.TextToCheck);
                    break;
                case "After":
                    result = model.SourceValue.After(model.TextToCheck);
                    break;
                case "Contains":
                    result = model.SourceValue.Contains(model.TextToCheck, StringComparison.OrdinalIgnoreCase) ? "Yes" : "No";
                    break;
                case "Substring":
                    result = model.SourceValue.Substring(model.FromA, model.ToB);
                    break;
                case "RemoveDiacritics":
                    result = model.SourceValue.RemoveDiacritics();
                    break;
                default:
                    return string.Empty;
            }
            return result;
        }
    }
}
