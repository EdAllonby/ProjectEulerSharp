// n! means n × (n − 1) × ... × 3 × 2 × 1
// For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
// and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27. 
// Find the sum of the digits in the number 100!

using System.Numerics;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem20 : IProjectEulerSolution
    {
        public string Solve()
        {
            BigInteger product = new BigInteger(1);
            for (int i = 1; i <= 100; i++)
            {
                product = BigInteger.Multiply(product, i);
            }

            int sum = MathsUtilities.GetSumOfDigits(product);

            return sum.ToString();
        }
    }
}
