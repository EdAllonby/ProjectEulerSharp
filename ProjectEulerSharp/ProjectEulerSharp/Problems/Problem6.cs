namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem6 : IProjectEulerSolution
    {
        public string Solve()
        {
            const int UpperBoundNumber = 100;

            var squareSum = 0;
            var sum = 0;
            for (var i = 1; i <= UpperBoundNumber; i++)
            {
                squareSum += i * i;
                sum += i;
            }

            int answer = sum * sum - squareSum;

            return answer.ToString();
        }
    }
}