using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class SeasonDateRecord {
        public long YearId { get; private set; }
        public DateTime SeasonStart { get; private set; }
        public DateTime SeasonEnd { get; private set; }

        public SeasonDateRecord(SeasonDate seasonDate) {
            YearId = seasonDate.YearId;

            if (seasonDate.SeasonStart != null) {
                string[] startArray = seasonDate.SeasonStart.Split('-');
                try {
                    int startMonth = int.Parse(startArray[0]);
                    int startDay = int.Parse(startArray[1]);
                    SeasonStart = new DateTime((int)YearId, startMonth, startDay);
                }
                catch {
                    SeasonStart = new DateTime((int)YearId, 3, 1); //fallback start date of March 1st
                }
            }
            if (seasonDate.SeasonEnd != null) {
                string[] endArray = seasonDate.SeasonEnd.Split('-');
                try {
                    int endMonth = int.Parse(endArray[0]);
                    int endDay = int.Parse((endArray[1]));
                    SeasonEnd = new DateTime((int)YearId, endMonth, endDay);
                }
                catch {
                    SeasonEnd = new DateTime((int)YearId, 10, 31); //fallback start date of October 31st 
                }
            }
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
                return true; //true for successful update
            }
            return false;
        }
    }
}
