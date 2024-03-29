﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class SeasonDateRecord {
        public long YearId { get; private set; }
        public DateTime SeasonStart { get; private set; }
        public DateTime SeasonEnd { get; private set; }
        public int SeasonDuration { get; private set; } = 0; //season duration in days

        public SeasonDateRecord(SeasonDate seasonDate) {
            YearId = seasonDate.YearId;

            if (seasonDate.SeasonStart != null) {
                SeasonStart = Helpers.StringToMonthDate(YearId, seasonDate.SeasonStart) ?? new DateTime((int)YearId, 3, 1); //fallback date March 1st;
            }
            if (seasonDate.SeasonEnd != null) {
                SeasonEnd = Helpers.StringToMonthDate(YearId, seasonDate.SeasonEnd) ?? new DateTime((int)YearId, 10, 31); //fallback date October 31st
            }
            CalcDuration();
        } //end constructor from seasonDate database record

        SeasonDateRecord(long year) {
            YearId = year;
        }

        SeasonDateRecord(long year, DateTime start, DateTime end) {
            YearId = year;
            Update(start, end);
        }

        //Updates the dates for season start & end. Returns true for success, false for failure.
        public bool Update(DateTime start, DateTime end) {
            if (YearId == start.Year && YearId == end.Year && start < end) {
                SeasonStart = start;
                SeasonEnd = end;
                CalcDuration();
                return true; //true for successful update
            }
            return false;
        }

        //Calc season duration
        private void CalcDuration() {
            if (SeasonStart != null && SeasonEnd != null) {
                TimeSpan interval = SeasonEnd - SeasonStart;
                SeasonDuration = interval.Days;
            }
        }
    }
}
