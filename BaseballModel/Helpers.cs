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
}
