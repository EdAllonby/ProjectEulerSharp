// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?

using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    class Problem3 : IProjectEulerSolution
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