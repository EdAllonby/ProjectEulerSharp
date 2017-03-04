using System.Collections.Generic;

namespace ProjectEulerSharp.Utilities
{
    internal class NumberToWordConverter
    {
        private static readonly string[] UnitsMap = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private static readonly string[] TensMap = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        public string Convert(int number)
        {
            if (number == 0)
                return GetUnitValue(0);

            if (number < 0)
                return $"minus {Convert(-number)}";

            var parts = new List<string>();

            if (number / 1000000000 > 0)
            {
                parts.Add($"{Convert(number / 1000000000)} billion");
                number %= 1000000000;
            }

            if (number / 1000000 > 0)
            {
                parts.Add($"{Convert(number / 1000000)} million");
                number %= 1000000;
            }

            if (number / 1000 > 0)
            {
                parts.Add($"{Convert(number / 1000)} thousand");
                number %= 1000;
            }

            if (number / 100 > 0)
            {
                parts.Add($"{Convert(number / 100)} hundred");
                number %= 100;
            }

            if (number > 0)
            {
                if (parts.Count != 0)
                    parts.Add("and");

                if (number < 20)
                    parts.Add(GetUnitValue(number));
                else
                {
                    string lastPart = TensMap[number / 10];
                    if (number % 10 > 0)
                    {
                        lastPart += $" {GetUnitValue(number % 10)}";
                    }

                    parts.Add(lastPart);
                }
            }

            string toWords = string.Join(" ", parts.ToArray());


            return toWords;
        }

        private static string GetUnitValue(int number)
        {
            return UnitsMap[number];
        }
    }
}