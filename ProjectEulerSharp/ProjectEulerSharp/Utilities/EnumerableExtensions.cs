using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEulerSharp.Utilities
{
    public static class EnumerableExtensions
    {
        public static BigInteger ConcatToInteger(this IEnumerable<int> integerList)
        {
            return !integerList.Any() ? 0 : BigInteger.Parse(string.Join("", integerList));
        }

        public static T MaxBy<T, TU>(this IEnumerable<T> enumerable, Func<T, TU> comparer) where TU : IComparable
        {
            return enumerable.Aggregate((next, current) => comparer(next).CompareTo(comparer(current)) > 0 ? next : current);
        }
    }
}