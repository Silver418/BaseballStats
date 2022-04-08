using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel {
    public class Helpers {
        public static string StringyDate(long? year, long? month, long? day) {
            string yearStr = year > 0 ? $"{year:0000}" : "XXXX";
            string monthStr = month > 0 ? $"{month:00}" : "XX";
            string dayStr = day > 0 ? $"{day:00}" : "XX";
            return $"{yearStr}-{monthStr}-{dayStr}";
        }

        //converts month & day to string -- for use with season & stint dates, where the year is displayed elsewhere
        public static string MonthDateToString(DateTime date) {
            return $"{date.Month:d2}-{date.Day:d2}";
        }

        //converts long + string from db storage to a datetime. FOr use with stint & season dates, where a year is stored separately & associated with two different month/day fields
        public static DateTime? StringToMonthDate(long year, string monthDateStr) {
            string[] dateArray = monthDateStr.Split('-');
            try {
                int month = int.Parse(dateArray[0]);
                int day = int.Parse(dateArray[1]);
                return new DateTime((int)year, month, day);
            }
            catch {
                return null;
            }
        }
    }

    public class PositionComparer : IComparer<String> {
        //for non-alphabetical sorting of fielding positions
        private static string[] fieldPositions = { "P", "C", "1B", "2B", "3B", "SS", "OF", "LF", "CF", "RF", "DH" };

        public int Compare(string? x, string? y) {
            int pos1 = Array.IndexOf(fieldPositions, x);
            int pos2 = Array.IndexOf(fieldPositions, y);

            if (pos1 < pos2) {
                return -1;
            }
            else if (pos1 > pos2) {
                return 1;
            }
            else {
                return 0;
            }
        }
    } //end PositionComparer class
}
