using System;
using System.Linq;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal class Problem3 : IProjectEulerSolution
    {
        public string Solve()
        {
            const long Number = 600851475143;

            int numberSquareRoot = (int) Math.Sqrt(Number) + 1;

            int answer = MathsUtilities.GetAllPrimeNumbers(numberSquareRoot)
                .Where(IsPrimeFactor(Number))
                .Max();

            return answer.ToString();
        }

        private static Func<int, bool> IsPrimeFactor(long number)
        {
            return prime => number % prime == 0;
        }
    }
}