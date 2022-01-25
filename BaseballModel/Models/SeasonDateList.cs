using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class SeasonDateList {
        //list & count
        private List<SeasonDateRecord> list = new List<SeasonDateRecord>();
        public int Count { get; private set; }

        public SeasonDateList(IEnumerable<SeasonDate> results) {
            foreach (SeasonDate season in results) {
                list.Add(new SeasonDateRecord(season));
            }
            Count = list.Count;
        }

        //get list copy
        public List<SeasonDateRecord> GetResults() {
            return new List<SeasonDateRecord>(list);
        }
    }
}
