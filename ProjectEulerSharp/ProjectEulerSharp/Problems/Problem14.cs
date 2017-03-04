// The following iterative sequence is defined for the set of positive integers:
// n → n/2 (n is even)
// n → 3n + 1 (n is odd)
// Using the rule above and starting with 13, we generate the following sequence:
// 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
// It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms.
// Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
// Which starting number, under one million, produces the longest chain?
// NOTE: Once the chain starts the terms are allowed to go above one million.

using System.Collections.Generic;

namespace ProjectEulerSharp.Problems
{
    public sealed class Problem14 : IProjectEulerSolution
    {
        private Dictionary<long, List<long>> collatzCache = new Dictionary<long, List<long>>();

        public string Solve()
        {
            for (int number = 1; number < 1000000; number++)
            {
                AddCollatzSequenceToCache(number);
            }

            long biggestStartingNumber=0;
            long longestSequence=0;

            foreach (KeyValuePair<long, List<long>> kpv in collatzCache)
            {
                int sequenceLength = kpv.Value.Count;
                if (sequenceLength > longestSequence)
                {
                    longestSequence = sequenceLength;
                    biggestStartingNumber = kpv.Key;
                }

            }

            return biggestStartingNumber.ToString();
        }

        private void AddCollatzSequenceToCache(long number)
        {
            long startingNumber = number;

            List<long> numbers = new List<long> {number};

            do
            {
                if (!collatzCache.ContainsKey(number))
                {
                    number = number % 2 == 0 ? EvenGenerator(number) : OddGenerator(number);
                    numbers.Add(number);
                }
                else
                {
                    List<long> cachedNumbers = new List<long>(collatzCache[number]);
                    cachedNumbers.RemoveAt(0);
                    numbers.AddRange(cachedNumbers);
                    break;
                }

            } while (number != 1);

            collatzCache.Add(startingNumber, numbers);
        }

        private long EvenGenerator(long number)
        {
            return number / 2;
        }

        private long OddGenerator(long number)
        {
            return (3 * number) + 1;
        }
    }
}