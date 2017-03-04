// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
// What is the 10 001st prime number?

using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    class Problem7 : IProjectEulerSolution
    {
        public string Solve()
        {
            int answer = MathsUtilities.GetNthPrime(10001);
            return answer.ToString();
        }
    }
}
