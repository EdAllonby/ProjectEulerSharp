//A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
//
//a2 + b2 = c2
//For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
//
//There exists exactly one Pythagorean triplet for which a + b + c = 1000.
//Find the product abc.

namespace ProjectEulerSharp.Problems
{
    internal class Problem9 : IProjectEulerSolution
    {
        public string Solve()
        {
            int finalA = 0;
            int finalB = 0;
            int finalC = 0;

            bool isFound = false;

            for (int c = 0; c < 1000; c++)
            {
                for (int b = 0; b < c; b++)
                {
                    for (int a = 0; a < b; a++)
                    {
                        if ((a*a) + (b*b) == (c*c) && a + b + c == 1000)
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

            return (finalA*finalB*finalC).ToString();
        }
    }
}