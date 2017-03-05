namespace ProjectEulerSharp.Problems
{
    internal sealed class Problem1 : IProjectEulerSolution
    {
        public string Solve()
        {
            var sum = 0;

            for (var i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum.ToString();
        }
    }
}