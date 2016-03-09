﻿using System;

namespace Every
{
    public class DayOfWeekBuilder : JobBuilder
    {
        private DayOfWeek[] _daysOfWeek;

        internal DayOfWeekBuilder(params DayOfWeek[] daysOfWeek)
            : base(0, 0)
        {
            _daysOfWeek = daysOfWeek;
        }


        public JobBuilder At(TimeSpan at)
        {
            throw new NotImplementedException();
        }

        public JobBuilder At(int hours, int minutes, int seconds = 0)
        {
            return At(new TimeSpan(hours, minutes, seconds));
        }
    }
}