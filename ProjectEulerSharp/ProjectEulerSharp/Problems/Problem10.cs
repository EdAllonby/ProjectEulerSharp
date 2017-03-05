using System.Collections.Generic;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem10 : IProjectEulerSolution
    {
        public string Solve()
        {
            IEnumerable<int> primes = MathsUtilities.GetAllPrimeNumbers(2000000);

            long sum = 0;

            foreach (int prime in primes)
            {
                sum += prime;
            }

            return sum.ToString();
        }
    }
}