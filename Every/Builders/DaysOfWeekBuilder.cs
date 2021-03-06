﻿using System.Linq;

namespace Every.Builders
{
    public class DayOfWeekBuilder : AtBuilder
    {
        internal DayOfWeekBuilder(JobConfiguration config)
            : base(config)
        {
            Configuration.CalculateNext = next =>
            {
                do
                    next = next.AddDays(1);
                while (!Configuration.DaysOfWeek.Contains(next.DayOfWeek));

                return next;
            };
        }
    }
}
