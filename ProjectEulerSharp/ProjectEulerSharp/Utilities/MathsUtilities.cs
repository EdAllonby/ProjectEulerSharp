using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEulerSharp.Utilities
{
    public static class MathsUtilities
    {
        /// <summary>
        /// An optimised implementation for finding primes.
        /// </summary>
        /// <param name="upperBound">The maximum prime to find.</param>
        /// <returns>A collection of primes up to the <see cref="upperBound" /> defined.</returns>
        public static IEnumerable<int> GetAllPrimeNumbers(int upperBound)
        {
            return SieveOfEratosthenes(upperBound);
        }

        public static int GetNthPrime(int nthPrime)
        {
            List<int> largeCollectionOfPrimes = SieveOfEratosthenes(1000000).ToList();
            return largeCollectionOfPrimes[nthPrime - 1];
        }

        public static IEnumerable<int> ProperDivisors(int number)
        {
            return Enumerable.Range(1, number / 2).Where(divisor => number % divisor == 0);
        }

        public static int ProperDivisiorsSum(int number)
        {
            var sqrt = (int) Math.Sqrt(number);
            var sum = 1;

            for (var i = 2; i <= sqrt; i++)
            {
                if (number % i != 0)
                {
                    continue;
                }

                sum += i;
                int d = number / i;
                if (d != i)
                {
                    sum += d;
                }
            }

            return sum;
        }

        public static bool IsAPrimeNumber(int number)
        {
            var boundary = (int) Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (var i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public static IEnumerable<BigInteger> FibonacciGeneratorFast()
        {
            BigInteger last = 1;
            BigInteger current = 1;

            yield return last;
            yield return current;

            while (true)
            {
                BigInteger next = last + current;
                last = current;
                current = next;

                yield return next;
            }
        }

        public static int DigitsInNumber(BigInteger number)
        {
            return (int) Math.Floor(BigInteger.Log10(number) + 1);
        }

        /// <summary>
        /// Creates fibonacci numbers up to the specified upper bound. Uses recursive implementation.
        /// </summary>
        /// <param name="maxFibonacciNumber">
        /// Specifies the last number to look for in the fibonacci sequence. If Not a fibonacci
        /// number, then use the last one found.
        /// </param>
        /// <returns>The fubonacci numbers found.</returns>
        public static IEnumerable<int> FibonacciGeneratorFromMaxNumber(int maxFibonacciNumber)
        {
            var numbers = new List<int>();

            for (var i = 0;; i++)
            {
                int currentFibonacciNumber = FibonacciFinder(i);

                if (currentFibonacciNumber > maxFibonacciNumber)
                {
                    break;
                }

                numbers.Add(currentFibonacciNumber);
            }

            return numbers;
        }

        public static List<int> FactorFinder(int number)
        {
            var factors = new List<int>();
            var max = (int) Math.Sqrt(number);
            for (var factor = 1; factor <= max; ++factor)
            {
                if (number % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != number / factor)
                    {
                        factors.Add(number / factor);
                    }
                }
            }
            return factors;
        }

        public static bool IsPalindrome(int possiblePalindrome)
        {
            string palindrome = possiblePalindrome.ToString();

            char[] tempPalindrome = palindrome.ToCharArray();
            Array.Reverse(tempPalindrome);
            var reversePalindrome = new string(tempPalindrome);

            return palindrome.Equals(reversePalindrome);
        }

        public static int GetSumOfDigits(BigInteger number)
        {
            return number.ToString().Sum(digit => int.Parse(digit.ToString()));
        }

        private static IEnumerable<int> SieveOfEratosthenes(int upperBound)
        {
            double upperBoundSquareRoot = Math.Sqrt(upperBound);

            var eliminated = new BitArray(upperBound + 1);

            yield return 2;

            for (var possiblePrime = 3; possiblePrime <= upperBound; possiblePrime += 2)
            {
                if (!eliminated[possiblePrime])
                {
                    if (possiblePrime < upperBoundSquareRoot)
                    {
                        for (int eliminatedPrimeLookup = possiblePrime * possiblePrime; eliminatedPrimeLookup <= upperBound; eliminatedPrimeLookup += 2 * possiblePrime)
                        {
                            eliminated[eliminatedPrimeLookup] = true;
                        }
                    }

                    yield return possiblePrime;
                }
            }
        }

        private static int FibonacciFinder(int upperBound)
        {
            if (upperBound <= 2)
            {
                return upperBound == 0 ? 0 : 1;
            }

            return FibonacciFinder(upperBound - 1) + FibonacciFinder(upperBound - 2);
        }
    }
}