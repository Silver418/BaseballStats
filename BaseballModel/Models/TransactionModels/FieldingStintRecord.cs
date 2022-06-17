using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class FieldingStintRecord : IRosterRecord {
        public FieldingRecord MyFielding { get; private set; }   // a given fielding record won't have a matching stint if:
        public StintRecord MyStint { get; private set; } // A) player only played for one team, or B) user hasn't yet entered stint data for the player

        //get-only adapters for fetching data from child objects
        public string PlayerId { get => MyFielding.PlayerId; }
        public string NameFirst { get => MyFielding.NameFirst; }
        public string NameLast { get => MyFielding.NameLast; }
        public string Pos { get => MyFielding.Pos; }
        public long? G { get => MyFielding.G; }
        public long? Gs { get => MyFielding.Gs; }
        public DateTime? StintStart { get => MyStint.StintStart; }
        public DateTime? StintEnd { get => MyStint.StintEnd; }
        public int StintDuration { get => MyStint.StintDuration; }
        public decimal StintX { get => MyStint.StintX; }


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
