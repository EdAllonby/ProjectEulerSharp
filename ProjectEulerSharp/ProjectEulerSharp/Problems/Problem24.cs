using System.Linq;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal class Problem24 : IProjectEulerSolution
    {
        public string Solve()
        {
            var perms = WordUtilities.FindPermutations("0123456789").OrderBy(x => x).ToList();

            var millionthPerm = perms[999999];

            return millionthPerm;
        }
    }
}