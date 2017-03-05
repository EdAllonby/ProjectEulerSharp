using System.Collections.Generic;
using System.Linq;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem17 : IProjectEulerSolution
    {
        public string Solve()
        {
            var numberToWordConverter = new NumberToWordConverter();

            var numbersInEnglish = new List<string>();

            for (var i = 1; i <= 1000; i++)
            {
                numbersInEnglish.Add(numberToWordConverter.Convert(i));
            }

            int sum = numbersInEnglish.Sum(number => number.Count(x => x != ' '));

            return sum.ToString();
        }
    }
}