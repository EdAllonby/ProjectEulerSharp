namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem5 : IProjectEulerSolution
    {
        public string Solve()
        {
            int answer;

            for (var j = 1;; j++)
            {
                var isDivisibleNumber = true;

                for (var i = 1; i <= 20; i++)
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