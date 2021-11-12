using System;
using TimePeriodCalculator.Extensions;
using TimePeriodCalculator.Models;

namespace TimePeriodCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPeriod = new DateRange(DateTime.Today.AddDays(-10), DateTime.Today.AddDays(10));
            var secondPeriod = new DateRange(DateTime.Today.AddDays(-15), DateTime.Today.AddDays(15));
            Console.WriteLine($"Days overlap {firstPeriod.OverlapsWith(secondPeriod)}");
            Console.WriteLine($"Days overlap inclusive {firstPeriod.OverlapsWithInclusive(secondPeriod)}");
            Console.WriteLine($"Count of days overlap {firstPeriod.OverlapCount(secondPeriod)}");
            Console.WriteLine($"Count of days overlap inclusive {firstPeriod.OverlapCountInclusive(secondPeriod)}");
            Console.WriteLine($"After {firstPeriod.After(secondPeriod)}");
            Console.WriteLine($"Before {firstPeriod.Before(secondPeriod)}");
            Console.WriteLine($"Exact Match {firstPeriod.ExactMatch(secondPeriod)}");
            Console.WriteLine($"Enclosing {firstPeriod.Enclosing(secondPeriod)}");
            Console.WriteLine($"Inside {firstPeriod.Inside(secondPeriod)}");
            Console.ReadKey();
        }
    }
}
