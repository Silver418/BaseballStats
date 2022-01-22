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
    }
}
