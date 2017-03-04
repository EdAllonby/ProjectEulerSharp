// The sum of the squares of the first ten natural numbers is,
// 1^2 + 2^2 + ... + 10^2 = 385
// The square of the sum of the first ten natural numbers is,
// (1 + 2 + ... + 10)^2 = 55^2 = 3025
// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem6 : IProjectEulerSolution
    {
        public string Solve()
        {
            const int UpperBoundNumber = 100;

            int squareSum = 0;
            int sum = 0;
            for (int i = 1; i <= UpperBoundNumber; i++)
            {
                squareSum += i * i;
                sum += i;
            }

            int answer = (sum * sum) - squareSum;

            return answer.ToString();
        }
    }
}