using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using ProjectEulerSharp.Properties;

namespace ProjectEulerSharp.Problems
{
    public sealed class Problem13 : IProjectEulerSolution
    {
        public string Solve()
        {
            string getResource = Resources.Problem13Numbers;

            List<string> numbers = getResource.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var sum = new BigInteger();

            sum = numbers.Aggregate(sum, (current, number) => current + BigInteger.Parse(number));

            string answer = sum.ToString().Substring(0, 10);

            return int.Parse(answer).ToString();
        }
    }
}