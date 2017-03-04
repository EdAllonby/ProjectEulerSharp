// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
// Find the largest palindrome made from the product of two 3-digit numbers.

using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem4 : IProjectEulerSolution
    {
        public string Solve()
        {
            int highestPalindrome = 0;

            for (int first = 100; first < 999; first++)
            {
                for (int second = 100; second < 999; second++)
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