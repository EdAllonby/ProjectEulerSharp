using System.Threading;
using System.Threading.Tasks;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem21 : IProjectEulerSolution
    {
        public string Solve()
        {
            var sum = 0;

            Parallel.For(2, 10000, number =>
            {
                int divisorSum = MathsUtilities.ProperDivisiorsSum(number);

                if (number == divisorSum)
                {
                    return;
                }

                if (MathsUtilities.ProperDivisiorsSum(divisorSum) == number)
                {
                    Interlocked.Add(ref sum, number + divisorSum);
                }
            });

            return (sum / 2).ToString();
        }
    }
}