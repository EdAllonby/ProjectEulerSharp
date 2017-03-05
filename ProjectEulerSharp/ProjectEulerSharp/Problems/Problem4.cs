using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem4 : IProjectEulerSolution
    {
        public string Solve()
        {
            var highestPalindrome = 0;

            for (var first = 100; first < 999; first++)
            {
                for (var second = 100; second < 999; second++)
                {
                    int possiblePalindrome = first * second;

                    if (possiblePalindrome > highestPalindrome && MathsUtilities.IsPalindrome(possiblePalindrome))
                    {
                        highestPalindrome = possiblePalindrome;
                    }
                }
            }

            int answer = highestPalindrome;

            return answer.ToString();
        }
    }
}