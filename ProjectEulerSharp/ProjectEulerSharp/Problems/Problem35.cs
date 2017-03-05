using System.Collections.Generic;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    public sealed class Problem35 : IProjectEulerSolution
    {
        public string Solve()
        {
            IEnumerable<int> primeNumbers = MathsUtilities.GetAllPrimeNumbers(1000000);

            var circularNumberCount = 0;

            foreach (int primeNumber in primeNumbers)
            {
                // Need to rotate, not permute.
                IEnumerable<string> permutations = WordUtilities.FindPermutations(primeNumber.ToString());

                var isPrimeNumberCircular = true;

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