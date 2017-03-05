using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEulerSharp.Utilities
{
    internal class DivisionUtilities
    {
        public static Division RecurringDivide(int a, int b)
        {
            int integer = a / b;
            int remainder = a % b;
            var seen = new Dictionary<int, int> { { remainder, 0 } };
            var digits = new List<int>();

            while (true)
            {
                remainder *= 10;
                digits.Add(remainder / b);
                remainder = remainder % b;

                if (!seen.ContainsKey(remainder))
                {
                    seen[remainder] = digits.Count;
                }
                else
                {
                    int recurringPosition = seen[remainder];
                    BigInteger nonRecurringFractional = digits.Take(recurringPosition).ConcatToInteger();
                    BigInteger recurringFractional = digits.Skip(recurringPosition).ConcatToInteger();

                    return new Division(a, b, integer, nonRecurringFractional, recurringFractional);
                }
            }
        }
    }
}