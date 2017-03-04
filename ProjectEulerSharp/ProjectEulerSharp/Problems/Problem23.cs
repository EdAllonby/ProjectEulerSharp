using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem23 : IProjectEulerSolution
    {
        public string Solve()
        {
            const int limit = 28123;

            List<int> abundent = Enumerable.Range(2, limit)
                .AsParallel()
                .Where(i => MathsUtilities.ProperDivisiorsSum(i) > i)
                .OrderBy(x => x)
                .ToList();

            // Make all the sums of two abundant numbers
            var canBeWrittenAsAbundent = new bool[limit + 1];

            for (var i = 0; i < abundent.Count; i++)
            {
                for (int j = i; j < abundent.Count; j++)
                {
                    int abundentPair = abundent[i] + abundent[j];

                    if (abundentPair > limit)
                    {
                        break;
                    }

                    canBeWrittenAsAbundent[abundentPair] = true;
                }
            }

            int sum = canBeWrittenAsAbundent.AsParallel()
                .Select((item, index) => new { item, index })
                .Where(kvp => !kvp.item)
                .Sum(kvp => kvp.index);

            return sum.ToString();
        }
    }
}