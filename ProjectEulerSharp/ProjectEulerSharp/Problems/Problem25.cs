using System.Linq;
using System.Numerics;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem25 : IProjectEulerSolution
    {
        public string Solve()
        {
            int index = 1 + MathsUtilities.FibonacciGeneratorFast().TakeWhile(fibonacciNumber => MathsUtilities.DigitsInNumber(fibonacciNumber) < 1000).Count();

            return index.ToString();
        }
    }
}