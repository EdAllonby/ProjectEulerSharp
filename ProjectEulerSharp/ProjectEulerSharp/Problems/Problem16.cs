// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
// What is the sum of the digits of the number 2^1000?

using System.Numerics;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem16 : IProjectEulerSolution
    {
        public string Solve()
        {
            BigInteger largeNumber = BigInteger.Pow(2, 1000);

            int answer = MathsUtilities.GetSumOfDigits(largeNumber);


            return answer.ToString();
        }
    }
}