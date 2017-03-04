using System;
using System.Diagnostics;
using ProjectEulerSharp.Problems;

namespace ProjectEulerSharp
{
    internal static class Program
    {
        private static void Main()
        {
            var executionTime = new Stopwatch();

            executionTime.Start();
            var selection = new Problem24();

            string answer = selection.Solve();
            Console.WriteLine(answer);

            executionTime.Stop();

            Console.WriteLine("Time elapsed: {0}", executionTime.Elapsed);
            Console.ReadKey();
        }
    }
}