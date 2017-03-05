using System;

namespace ProjectEulerSharp.Problems
{
    internal class Problem19 : IProjectEulerSolution
    {
        public string Solve()
        {
            DateTime startingDate = new DateTime(1901, 1, 1).Date;
            DateTime finalDate = new DateTime(2000, 12, 31).Date;

            var totalSundaysOnFirstOfMonth = 0;

            for (DateTime date = startingDate; date.Date <= finalDate; date = date.AddMonths(1))
            {
                if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    totalSundaysOnFirstOfMonth++;
                }
            }

            return totalSundaysOnFirstOfMonth.ToString();
        }
    }
}