using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class PitchingStintList {
        private List<PitchingStintRecord> list = new List<PitchingStintRecord>();
        private SeasonDateRecord? season;

        //constructor used when a SeasonDateRecord is available (calculates stint's StintX values)
        public PitchingStintList(string teamId, string lgId, SeasonDateRecord s) {
            this.season = s;
            
            PitchingList pitchingList = Queries.TeamPitchingByID(teamId, lgId, season.YearId);

            foreach (PitchingRecord pitching in pitchingList.GetResults()) {
                StintRecord? stint = Queries.GetStint(teamId, season.YearId, pitching.PlayerId);
                if (stint != null) {
                    stint.CalcStintX(season.SeasonDuration);
                }
                PitchingStintRecord psr = new PitchingStintRecord(pitching, stint);
                list.Add(psr);
            }
        }

        //constructor used with just a year number instead of a full SeasonDateRecord
        public PitchingStintList(string teamId, string lgId, long yearId) {
            PitchingList pitchingList = Queries.TeamPitchingByID(teamId, lgId, yearId);

            foreach (PitchingRecord pitching in pitchingList.GetResults()) {
                StintRecord? stint = Queries.GetStint(teamId, yearId, pitching.PlayerId);
                list.Add(new PitchingStintRecord(pitching, stint));
            }
        }

        public List<PitchingStintRecord> GetResults() {
            return list;
        }
    }
}
