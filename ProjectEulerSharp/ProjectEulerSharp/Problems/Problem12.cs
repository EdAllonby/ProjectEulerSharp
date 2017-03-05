using ProjectEulerSharp.Utilities;

namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem12 : IProjectEulerSolution
    {
        public string Solve()
        {
            int answer;

            for (var i = 1;; i++)
            {
                var triangleNumber = 0;
                for (var j = 0; j < i; j++)
                {
                    triangleNumber += j;
                }
                if (MathsUtilities.FactorFinder(triangleNumber).Count > 500)
                {
                    answer = triangleNumber;
                    break;
                }
            }

            return answer.ToString();
        }
    }
}