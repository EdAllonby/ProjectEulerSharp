using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal class Problem7 : IProjectEulerSolution
    {
        public string Solve()
        {
            int answer = MathsUtilities.GetNthPrime(10001);
            return answer.ToString();
        }
    }
}