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