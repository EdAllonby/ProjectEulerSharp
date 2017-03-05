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
            string[] numberLines = Resources.Problem11Numbers.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            int[,] numberGrid = ParseGridToMultiDimensionalArray(numberLines);

            var highestHorizontalNumber = 0;
            var highestVerticalNumber = 0;
            var highestleftDownNumber = 0;
            var highestrightDownNumber = 0;

            highestHorizontalNumber = HighestHorizontalValue(numberGrid);
            highestVerticalNumber = HighestVerticalValue(numberGrid);
            highestleftDownNumber = HighestLeftDownValue(numberGrid);
            highestrightDownNumber = HighestRightDownValue(numberGrid);

            var numbers = new List<int>
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
            var numberGrid = new int[20, 20];

            var xIndex = 0;
            var yIndex = 0;

            foreach (string numbers in grid)
            {
                var numberBuilder = new StringBuilder();

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
            var highestNumber = 0;

            for (var row = 0; row < 20; row++)
            {
                for (var column = 0; column < 16; column++)
                {
                    int product = numberGrid[row, column] * numberGrid[row, column + 1] * numberGrid[row, column + 2] * numberGrid[row, column + 3];
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
            var highestNumber = 0;
            for (var row = 0; row < 16; row++)
            {
                for (var column = 0; column < 20; column++)
                {
                    int product = numberGrid[row, column] * numberGrid[row + 1, column] * numberGrid[row + 2, column] * numberGrid[row + 3, column];
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
            var highestNumber = 0;
            for (var row = 0; row < 16; row++)
            {
                for (var column = 0; column < 16; column++)
                {
                    int product = numberGrid[row, column] * numberGrid[row + 1, column + 1] * numberGrid[row + 2, column + 2] * numberGrid[row + 3, column + 3];
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
            var highestNumber = 0;
            for (var row = 0; row < 16; row++)
            {
                for (var column = 3; column < 20; column++)
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