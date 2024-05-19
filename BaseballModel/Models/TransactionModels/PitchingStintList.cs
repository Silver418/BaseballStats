using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class PitchingStintList {
        private List<PitchingStintRecord> list = new List<PitchingStintRecord>();

        //constructor used when a SeasonDateRecord is available
        public PitchingStintList(string teamId, string lgId, SeasonDateRecord s) {

            PitchingList pitchingList = Queries.TeamPitchingByID(teamId, lgId, s.YearId);

            foreach (PitchingRecord pitching in pitchingList.GetResults()) {
                StintRecord? stint = Queries.GetStint(pitching.PlayerId, pitching.YearId, pitching.Stint);
                if (stint == null) { //if no stint is found, build a fresh record & add
                    list.Add(new PitchingStintRecord(pitching, stint));
                }
                else if (!stint.IgnoreStint) { //if we have a stint with IgnoreStint == false, add the existing record
                    list.Add(new PitchingStintRecord(pitching, stint));
                } //an existing stint with IgnoreStint == true does not get added
            }
        }

        //constructor used with just a year number instead of a full SeasonDateRecord
        public PitchingStintList(string teamId, string lgId, long yearId) {
            PitchingList pitchingList = Queries.TeamPitchingByID(teamId, lgId, yearId);

            foreach (PitchingRecord pitching in pitchingList.GetResults()) {
                StintRecord? stint = Queries.GetStint(pitching.PlayerId, pitching.YearId, pitching.Stint);
                list.Add(new PitchingStintRecord(pitching, stint));
            }
        }

        public List<PitchingStintRecord> GetResults() {
            return list;
        }
    }
}
