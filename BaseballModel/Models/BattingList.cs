using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class BattingList {
        //List & count
        private List<BattingRecord> list = new List<BattingRecord>();
        public int Count { get; private set; }

        //lifetime stats
        public long LifeAb { get; private set; } = 0; //At Bats
        public long LifeR { get; private set; } = 0; //Runs
        public long LifeH { get; private set; } = 0; //Hits
        public long Life2b { get; private set; } = 0; //Doubles
        public long Life3b { get; private set; } = 0; //Triples
        public long LifeHr { get; private set; } = 0; //Home Runs
        public long LifeRbi { get; private set; } = 0; //Runs Batted In
        public long LifeSb { get; private set; } = 0; //Stolen Bases
        public long LifeCs { get; private set; } = 0; //Caught Stealing
        public long LifeBb { get; private set; } = 0; //Walks
        public long LifeSo { get; private set; } = 0; //Strike Outs
        public decimal LifeAvg { get; private set; } = 0; //Batting average
        

        //constructor
        public BattingList(IEnumerable<Batting> results) {
            foreach (Batting batting in results) {
                BattingRecord record = new BattingRecord(batting);
                list.Add(record);

                LifeAb += record.Ab;
                LifeR += record.R;
                LifeH += record.H;
                Life2b += record._2b;
                Life3b += record._3b;
                LifeHr += record.Hr;
                LifeRbi += record.Rbi;
                LifeSb += record.Sb;
                LifeCs += record.Cs;
                LifeBb += record.Bb;
                LifeSo += record.So;                
            }

            Count = list.Count;

            if (LifeAb > 0) {
                LifeAvg = decimal.Round(LifeH / (decimal)LifeAb, 3);
            }
            
        }

        //get list copy
        public List<BattingRecord> GetResults() {
            return new List<BattingRecord>(list);
        }

    } //end BattingList class
}
