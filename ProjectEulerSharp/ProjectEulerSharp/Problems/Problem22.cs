using System.Linq;
using ProjectEulerSharp.Properties;
using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal class Problem22 : IProjectEulerSolution
    {
        public string Solve()
        {
            int result = Resources.Problem22Names
                .Replace("\"", "")
                .Split(',')
                .OrderBy(name => name)
                .Select(letter => letter.Sum(WordUtilities.LetterToAlphabetIndex))
                .Select((score, position) => score * (position + 1))
                .Sum();

            return result.ToString();
        }
    }
}