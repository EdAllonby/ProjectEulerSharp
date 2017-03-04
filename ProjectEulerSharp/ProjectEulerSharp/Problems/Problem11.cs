// In the 20×20 grid below, four numbers along a diagonal line have been marked in red (in resources)
// The product of these numbers is 26 × 63 × 78 × 14 = 1788696.
// What is the greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) in the 20×20 grid?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEulerSharp.Properties;

namespace ProjectEulerSharp.Problems
{
    internal class Problem11 : IProjectEulerSolution
    {
        public string Solve()
        {
            string[] numberLines = Resources.Problem11Numbers.Split(new[] {Environment.NewLine}, StringSplitOptions.None);

            int[,] numberGrid = ParseGridToMultiDimensionalArray(numberLines);

            int highestHorizontalNumber = 0;
            int highestVerticalNumber = 0;
            int highestleftDownNumber = 0;
            int highestrightDownNumber = 0;

            highestHorizontalNumber = HighestHorizontalValue(numberGrid);
            highestVerticalNumber = HighestVerticalValue(numberGrid);
            highestleftDownNumber = HighestLeftDownValue(numberGrid);
            highestrightDownNumber = HighestRightDownValue(numberGrid);

            List<int> numbers = new List<int>
            {
                highestHorizontalNumber,
                highestVerticalNumber,
                highestleftDownNumber,
                highestrightDownNumber
            };

            return numbers.Max().ToString();
        }

        private static int[,] ParseGridToMultiDimensionalArray(IEnumerable<string> grid)
        {
            int[,] numberGrid = new int[20, 20];

            int xIndex = 0;
            int yIndex = 0;

            foreach (string numbers in grid)
            {
                StringBuilder numberBuilder = new StringBuilder();

                foreach (char number in numbers)
                {
                    if (number == ' ')
                    {
                        int currentNumber = int.Parse(numberBuilder.ToString());
                        numberGrid[yIndex, xIndex] = currentNumber;

                        numberBuilder.Clear();
                        xIndex++;
                    }
                    numberBuilder.Append(number);
                }

                xIndex = 0;
                yIndex++;
            }

            return numberGrid;
        }

        private static int HighestHorizontalValue(int[,] numberGrid)
        {
            int highestNumber = 0;

            for (int row = 0; row < 20; row++)
            {
                for (int column = 0; column < 16; column++)
                {
                    int product = numberGrid[row, column]*numberGrid[row, column + 1]*numberGrid[row, column + 2]*numberGrid[row, column + 3];
                    if (product > highestNumber)
                    {
                        highestNumber = product;
                    }
                }
            }

            return highestNumber;
        }

        private static int HighestVerticalValue(int[,] numberGrid)
        {
            int highestNumber = 0;
            for (int row = 0; row < 16; row++)
            {
                for (int column = 0; column < 20; column++)
                {
                    int product = numberGrid[row, column]*numberGrid[row + 1, column]*numberGrid[row + 2, column]*numberGrid[row + 3, column];
                    if (product > highestNumber)
                    {
                        highestNumber = product;
                    }
                }
            }

            return highestNumber;
        }

        private static int HighestLeftDownValue(int[,] numberGrid)
        {
            int highestNumber = 0;
            for (int row = 0; row < 16; row++)
            {
                for (int column = 0; column < 16; column++)
                {
                    int product = numberGrid[row, column]*numberGrid[row + 1, column + 1]*numberGrid[row + 2, column + 2]*numberGrid[row + 3, column + 3];
                    if (product > highestNumber)
                    {
                        highestNumber = product;
                    }
                }
            }

            return highestNumber;
        }

        private static int HighestRightDownValue(int[,] numberGrid)
        {
            int highestNumber = 0;
            for (int row = 0; row < 16; row++)
            {
                for (int column = 3; column < 20; column++)
                {
                    int product = numberGrid[row, column] * numberGrid[row + 1, column - 1] * numberGrid[row + 2, column - 2] * numberGrid[row + 3, column - 3];
                    if (product > highestNumber)
                    {
                        highestNumber = product;
                    }
                }
            }
            return highestNumber;
        }
    }
}