using System;
using System.Threading.Tasks;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem27 : IProjectEulerSolution
    {
        private readonly object thisLock = new object();

        public string Solve()
        {
            const int low = -1000;
            const int high = 1000;

            int bestA = low;
            int bestB = low;
            var bestN = 0;

            Parallel.For(low, high + 1, a =>
            {
                Parallel.For(low, high + 1, b =>
                {
                    var n = 0;

                    while (MathsUtilities.IsAPrimeNumber(Solve(n, a, b)))
                    {
                        n++;
                    }

                    lock (thisLock)
                    {
                        if (n > bestN)
                        {
                            bestN = n;
                            bestA = a;
                            bestB = b;
                        }
                    }
                });
            });

            return (bestA * bestB).ToString();
        }

        private static int Solve(int n, int a, int b)
        {
            return Math.Abs(n * n + a * n + b);
        }
    }
}