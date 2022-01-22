using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class PitchingList {
        //List & count
        private List<PitchingRecord> list = new List<PitchingRecord>();
        public int Count { get; private set; }

        //Lifetime stats
        public long LifeW { get; private set; } = 0; //Wins
        public long LifeL { get; private set; } = 0; //Losses
        public long LifeG { get; private set; } = 0; //Games
        public long LifeGs { get; private set; } = 0; //Games Started
        public long LifeCg { get; private set; } = 0; //Complete Games
        public long LifeSho { get; private set; } = 0; //Shutouts
        public long LifeSv { get; private set; } = 0; //Saves
        public long LifeIpouts { get; private set; } = 0; //Outs Pitched
        public long LifeH { get; private set; } = 0; //Hits
        public long LifeR { get; private set; } = 0; //Runs allowed
        public long LifeEr { get; private set; } = 0; //Earned Runs
        public long LifeHr { get; private set; } = 0; //Homeruns
        public long LifeBb { get; private set; } = 0; //Walks
        public long LifeSo { get; private set; } = 0; //Strikeouts

        //calculated
        public decimal LifeEra { get; private set; } = 0; //Earned Run Average
        public decimal LifeIp { get; private set; } = 0; //Innings Pitched


        //constructor
        public PitchingList(IEnumerable<Pitching> results) {
            foreach (Pitching pitching in results) {
                PitchingRecord record = new PitchingRecord(pitching);
                list.Add(record);

                LifeW += record.W;
                LifeL += record.L;
                LifeG += record.G;
                LifeGs += record.Gs;
                LifeCg += record.Cg;
                LifeSho += record.Sho;
                LifeSv += record.Sv;
                LifeIpouts += record.Ipouts;
                LifeH += record.H;
                LifeR += record.R;
                LifeEr += record.Er;
                LifeHr += record.Hr;
                LifeBb += record.Bb;
                LifeSo += record.So;
            }

            Count = list.Count;
            //calculated
            if (LifeIpouts > 0) {
                LifeIp = decimal.Round(LifeIpouts / (decimal) 3, 2);
                LifeEra = decimal.Round((LifeEr / (decimal)LifeIpouts) * 27, 2);
            }
            
        }

        //get list copy
        public List<PitchingRecord> GetResults() {
            return new List<PitchingRecord>(list);
        }
    }
}
