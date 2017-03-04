// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
// Find the sum of all the primes below two million.

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

            foreach (var prime in primes)
            {
                sum += prime;
            }

            return sum.ToString();
        }
    }
}