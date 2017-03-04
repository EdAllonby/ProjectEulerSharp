using System.Collections.Generic;
using System.Linq;
using ProjectEulerSharp.Properties;

namespace ProjectEulerSharp.Problems
{
    internal class Problem8 : IProjectEulerSolution
    {
        public string Solve()
        {
            char[] numberList = Resources.Problem8Numbers.ToArray();

            List<int> numbers = new List<int>();

            foreach (char number in numberList)
            {
                int parsedNumber;
                if (int.TryParse(number.ToString(), out parsedNumber))
                {
                    numbers.Add(parsedNumber);
                }
            }

            int maximumProduct = 0;

            const int Width = 13;

            for (int i = 0; i < 1000 - Width; i++)
            {
                List<int> subList = numbers.GetRange(i, Width);

                int product = subList.TakeWhile(num => num != 0).Aggregate(1, (current, num) => current*num);

                if (product > maximumProduct)
                {
                    maximumProduct = product;
                }
            }

            return maximumProduct.ToString();
        }
    }
}