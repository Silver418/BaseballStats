using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class FieldingStintRecord {
        public FieldingRecord MyFielding { get; private set; }   // a given fielding record won't have a matching stint if:
        public StintRecord MyStint { get; private set; } // A) player only played for one team, or B) uesr hasn't yet entered stint data for the player

        public FieldingStintRecord(FieldingRecord field, StintRecord? stint = null) {
            MyFielding = field;
            if (stint != null) {
                MyStint = stint;
            }
            else {
                MyStint = new StintRecord(MyFielding.PlayerId, MyFielding.YearId, MyFielding.Stint, MyFielding.TeamId);
            }
        }
    }
}
