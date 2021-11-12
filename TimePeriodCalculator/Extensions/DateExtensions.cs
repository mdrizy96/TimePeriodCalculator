using System;
using System.Linq;
using TimePeriodCalculator.Models;

namespace TimePeriodCalculator.Extensions
{
    public static class DateExtensions
    {
        public static int OverlapCount(this DateRange firstPeriod, DateRange secondPeriod)
        {
            var timeDifference = new[] { firstPeriod.EndDate, secondPeriod.EndDate }.Min() -
                                 new[] { firstPeriod.StartDate, secondPeriod.StartDate }.Max();
            return Math.Max(
                timeDifference.Days, 0);
        }
        
        public static int OverlapCountInclusive(this DateRange firstPeriod, DateRange secondPeriod)
        {
            var timeDifference = new[] { firstPeriod.EndDate, secondPeriod.EndDate }.Min() -
                                 new[] { firstPeriod.StartDate, secondPeriod.StartDate }.Max();
            return Math.Max(
                timeDifference.Days + 1, 0);
        }

        public static bool OverlapsWith(this DateRange firstPeriod, DateRange secondPeriod)
        {
            return new[] { firstPeriod.StartDate, secondPeriod.StartDate }.Max() < new[] { firstPeriod.EndDate, secondPeriod.EndDate }.Min();
        }

        public static bool OverlapsWithInclusive(this DateRange firstPeriod, DateRange secondPeriod)
        {
            return  (firstPeriod.StartDate <= secondPeriod.EndDate) && firstPeriod.EndDate >= secondPeriod.StartDate;
        }

        public static bool After(this DateRange firstPeriod, DateRange secondPeriod)
        {
            return  firstPeriod.StartDate > secondPeriod.EndDate;
        }

        public static bool Before(this DateRange firstPeriod, DateRange secondPeriod)
        {
            return  firstPeriod.EndDate < secondPeriod.StartDate;
        }

        public static bool ExactMatch(this DateRange firstPeriod, DateRange secondPeriod)
        {
            return (firstPeriod.StartDate == secondPeriod.StartDate) && firstPeriod.EndDate == secondPeriod.EndDate;
        }

        public static bool EndTouching(this DateRange firstPeriod, DateRange secondPeriod)
        {
            return (firstPeriod.EndDate == secondPeriod.StartDate) && (firstPeriod.EndDate < secondPeriod.EndDate);
        }

        public static bool StartTouching(this DateRange firstPeriod, DateRange secondPeriod)
        {
            return (firstPeriod.StartDate == secondPeriod.EndDate) && (firstPeriod.StartDate > secondPeriod.StartDate);
        }

        public static bool StartInside(this DateRange firstPeriod, DateRange secondPeriod)
        {
            return (firstPeriod.StartDate > secondPeriod.StartDate) && (firstPeriod.StartDate < secondPeriod.EndDate);
        }

        public static bool EndInside(this DateRange firstPeriod, DateRange secondPeriod)
        {
            return (firstPeriod.EndDate < secondPeriod.EndDate) && (firstPeriod.EndDate > secondPeriod.StartDate);
        }

        public static bool Inside(this DateRange firstPeriod, DateRange secondPeriod)
        {
            return (firstPeriod.StartDate > secondPeriod.StartDate) && (firstPeriod.EndDate < secondPeriod.EndDate);
        }

        public static bool Enclosing(this DateRange firstPeriod, DateRange secondPeriod)
        {
            return (firstPeriod.StartDate < secondPeriod.StartDate) && (firstPeriod.EndDate > secondPeriod.EndDate);
        }
    }
}