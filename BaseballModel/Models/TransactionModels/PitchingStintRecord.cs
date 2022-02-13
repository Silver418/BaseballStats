using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class PitchingStintRecord {
        public PitchingRecord MyPitching { get; private set; }   // a given pitching record won't have a matching stint if:
        public StintRecord MyStint { get; private set; } // A) player only played for one team, or B) uesr hasn't yet entered stint data for the player

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
