using System.Collections.Generic;

namespace ProjectEulerSharp.Problems
{
    public sealed class Problem14 : IProjectEulerSolution
    {
        private readonly Dictionary<long, List<long>> collatzCache = new Dictionary<long, List<long>>();

        public string Solve()
        {
            for (var number = 1; number < 1000000; number++)
            {
                AddCollatzSequenceToCache(number);
            }

            long biggestStartingNumber = 0;
            long longestSequence = 0;

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

            var numbers = new List<long> { number };

            do
            {
                if (!collatzCache.ContainsKey(number))
                {
                    number = number % 2 == 0 ? EvenGenerator(number) : OddGenerator(number);
                    numbers.Add(number);
                }
                else
                {
                    var cachedNumbers = new List<long>(collatzCache[number]);
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
            return 3 * number + 1;
        }
    }
}