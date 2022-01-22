using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class TeamYearSearchList {
        private List<TeamYearSearchRecord> list = new List<TeamYearSearchRecord>();
        public int Count { get; private set; }

        public TeamYearSearchList(IEnumerable<Team> results) {
            foreach (Team record in results) {
                list.Add(new TeamYearSearchRecord(record));
            }

            Count = list.Count;
        }

        public List<TeamYearSearchRecord> GetResults() {
            return new List<TeamYearSearchRecord>(list);
        }
    }
}
