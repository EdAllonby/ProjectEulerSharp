using System.Linq;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem26 : IProjectEulerSolution
    {
        public string Solve()
        {
            Division highest = Enumerable.Range(1, 1000)
                .Select(division => DivisionUtilities.RecurringDivide(1, division))
                .MaxBy(division => division.RecurringFractional.ToString().Length);

            return highest.Denominator.ToString();
        }
    }
}