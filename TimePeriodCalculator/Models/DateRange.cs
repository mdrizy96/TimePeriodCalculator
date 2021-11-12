using System;

namespace TimePeriodCalculator.Models
{
    public class DateRange
    {
        public DateRange(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate < endDate ? startDate : endDate;
            EndDate = startDate < endDate ? endDate : startDate;
            // EndDate = (endDate < startDate)? throw new ArgumentException("End date cannot be less than start date"): endDate;
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}