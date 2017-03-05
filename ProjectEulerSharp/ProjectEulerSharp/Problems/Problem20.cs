using System.Numerics;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem20 : IProjectEulerSolution
    {
        public string Solve()
        {
            var product = new BigInteger(1);
            for (var i = 1; i <= 100; i++)
            {
                product = BigInteger.Multiply(product, i);
            }

            int sum = MathsUtilities.GetSumOfDigits(product);

            return sum.ToString();
        }
    }
}