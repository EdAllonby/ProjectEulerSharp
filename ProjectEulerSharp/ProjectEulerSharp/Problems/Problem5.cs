// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem5 : IProjectEulerSolution
    {
        public string Solve()
        {
            int answer;

            for (int j = 1; ; j++)
            {
                bool isDivisibleNumber = true;

                for (int i = 1; i <= 20; i++)
                {
                    if (j % i != 0)
                    {
                        isDivisibleNumber = false;
                        break;
                    }
                }
                if (isDivisibleNumber)
                {
                    answer = j;
                    break;
                }
            }

            return answer.ToString();
        }
    }
}