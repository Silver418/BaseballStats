using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class AppearanceList {
        //list & count
        private List<AppearanceRecord> list = new List<AppearanceRecord> ();
        public int Count { get; private set; } = 0;

        //constructor
        public AppearanceList(IEnumerable<Appearance> results) {
            foreach (Appearance record in results) {
                list.Add(new AppearanceRecord(record));
            }

            Count = list.Count;
        }

        //get list
        public List<AppearanceRecord> GetResults() {
            return list;
        }
    }
}
