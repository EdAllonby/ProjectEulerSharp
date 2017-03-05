namespace ProjectEulerSharp.Problems
{
    internal class Problem9 : IProjectEulerSolution
    {
        public string Solve()
        {
            var finalA = 0;
            var finalB = 0;
            var finalC = 0;

            var isFound = false;

            for (var c = 0; c < 1000; c++)
            {
                for (var b = 0; b < c; b++)
                {
                    for (var a = 0; a < b; a++)
                    {
                        if (a * a + b * b == c * c && a + b + c == 1000)
                        {
                            finalA = a;
                            finalB = b;
                            finalC = c;
                            isFound = true;
                            break;
                        }
                    }
                    if (isFound)
                    {
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }

            return (finalA * finalB * finalC).ToString();
        }
    }
}