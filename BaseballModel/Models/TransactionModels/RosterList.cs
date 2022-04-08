using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    //For combining IRosterRecord (FieldingStintRecords & DesignatedStintRecords) in a single list for display
    public class RosterList {
        private List<IRosterRecord> list = new List<IRosterRecord>();
        public int Count { get; private set; } = 0;

        public RosterList() { } //default ctor

        public RosterList AppendFieldingStintList(FieldingStintList fieldingStintList) {
            foreach (IRosterRecord record in fieldingStintList.GetResults()) {
                list.Add(record);
            }
            return this;
        }

        public RosterList AppendDesignatedStintList(DesignatedStintList designatedStintList) {
            foreach (IRosterRecord record in designatedStintList.GetResults()) {
                list.Add(record);
            }
            return this;
        }

        public RosterList TeamSort() {
            list.Sort(new TeamRosterComparer());
            return this;
        }

        public List<IRosterRecord> GetResults() {
            return list;
        }

        //nested comparer class for a team roster
        // Position, then # games (desc), then PlayerIds (alphabetical)
        private class TeamRosterComparer : IComparer<IRosterRecord> {
            public int Compare(IRosterRecord x, IRosterRecord y) {
                PositionComparer positionComparer = new PositionComparer();
                int posCompare = positionComparer.Compare(x.Pos, y.Pos);

                if (posCompare == 0) {
                    if (x.G > y.G) { //if same position, test # games - more games first
                        return -1;
                    }
                    else if (x.G < y.G) {
                        return 1;
                    }
                    else return String.Compare(x.PlayerId, y.PlayerId); //if same # games played, test PlayerIds (alphabetical)
                }
                else {
                    return posCompare;
                }
            }
        } //end TeamFieldingComprarer class
    }
}
