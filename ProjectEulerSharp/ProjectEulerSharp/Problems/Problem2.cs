using System.Linq;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem2 : IProjectEulerSolution
    {
        public string Solve()
        {
            int sum = MathsUtilities.FibonacciGeneratorFast()
                .TakeWhile(x => x < 3999999)
                .Where(fibonacciNumber => fibonacciNumber % 2 == 0)
                .Sum(x => (int) x);

            return sum.ToString();
        }
    }
}