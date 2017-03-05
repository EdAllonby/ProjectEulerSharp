using System.Numerics;

namespace ProjectEulerSharp.Utilities
{
    public class Division
    {
        public Division(int numerator, int denominator, int integer, BigInteger nonRecurringFractional, BigInteger recurringFractional)
        {
            Numerator = numerator;
            Denominator = denominator;
            Integer = integer;
            NonRecurringFractional = nonRecurringFractional;
            RecurringFractional = recurringFractional;
        }

        public int Numerator { get; }
        public int Denominator { get; }
        public int Integer { get; }
        public BigInteger NonRecurringFractional { get; }
        public BigInteger RecurringFractional { get; }

        public override string ToString()
        {
            return $"Result for {Numerator}/{Denominator}";
        }
    }
}