using System.Collections.Generic;
using System.Linq;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal class Problem24 : IProjectEulerSolution
    {
        public string Solve()
        {
            List<string> perms = WordUtilities.FindPermutations("0123456789").OrderBy(x => x).ToList();

            string millionthPerm = perms[999999];

            return millionthPerm;
        }
    }
}