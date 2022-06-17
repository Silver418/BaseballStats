using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models.TransactionModels {
    public class PitchingStintRecord : IRosterRecord {
        public PitchingRecord MyPitching { get; private set; }
        public StintRecord MyStint { get; private set; }

        //get-only adapters for fetching data from child objects
        public string PlayerId { get => MyPitching.PlayerId; }
        public string NameFirst { get => MyPitching.NameFirst; }
        public string NameLast { get => MyPitching.NameLast; }
        public string Pos { get => "P"; }   //Pitching records don't have Position, but match "P" on the fielding table
        public long? G { get => MyPitching.G; }
        public long? Gs { get => MyPitching.Gs; }
        public DateTime? StintStart { get => MyStint.StintStart; }
        public DateTime? StintEnd { get => MyStint.StintEnd; }
        public int StintDuration { get => MyStint.StintDuration; }
        public decimal StintX { get => MyStint.StintX; }

        //ctor
        public PitchingStintRecord(PitchingRecord pitch, StintRecord? stint = null) {
            MyPitching = pitch;
            if (stint != null) {
                MyStint = stint;
            }
            else {
                MyStint = new StintRecord(MyPitching.PlayerId, MyPitching.YearId, MyPitching.Stint, MyPitching.TeamId);
            }
        }
    }
}