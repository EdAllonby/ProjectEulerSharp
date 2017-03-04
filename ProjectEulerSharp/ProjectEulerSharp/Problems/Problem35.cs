// The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.
// There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
// How many circular primes are there below one million?

using System.Collections.Generic;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    public sealed class Problem35 : IProjectEulerSolution
    {
        public string Solve()
        {
            IEnumerable<int> primeNumbers = MathsUtilities.GetAllPrimeNumbers(1000000);

            int circularNumberCount = 0;

            foreach (var primeNumber in primeNumbers)
            {
                // Need to rotate, not permute.
                IEnumerable<string> permutations = WordUtilities.FindPermutations(primeNumber.ToString());

                bool isPrimeNumberCircular = true;

                foreach (string permutation in permutations)
                {
                    if (!permutation.StartsWith("0"))
                    {
                        int number = int.Parse(permutation);
                        if (!MathsUtilities.IsAPrimeNumber(number))
                        {
                            isPrimeNumberCircular = false;
                            break;
                        }
                    }
                }

                if (isPrimeNumberCircular)
                {
                    circularNumberCount++;
                }
            }

            return "";
        }
    }
}