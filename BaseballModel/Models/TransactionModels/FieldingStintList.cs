using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class FieldingStintList {
        private List<FieldingStintRecord> list = new List<FieldingStintRecord>();
        private SeasonDateRecord? season;

        //constructor used when a SeasonDateRecord is available (calculates stint's StintX values)
        public FieldingStintList(string teamId, string lgId, SeasonDateRecord s, bool includeOutfieldDetails = false) {
            season = s;

            FieldingList fieldingList = Queries.TeamFieldingByID(teamId, lgId, season.YearId, includeOutfieldDetails);

            foreach (FieldingRecord fielding in fieldingList.GetResults()) {
                StintRecord? stint = Queries.GetStint(teamId, season.YearId, fielding.PlayerId);
                //TODO: Cleanup
                /*
                if (stint != null) {
                    stint.CalcStintX(season.SeasonDuration);
                }
                */
                //FieldingStintRecord fsr = new FieldingStintRecord(fielding, stint);
                if (stint == null) { //if no stint is found, build a fresh record & add
                    list.Add(new FieldingStintRecord(fielding, stint));
                } else if (!stint.IgnoreStint) { //if we have a stint with IgnoreStint == false, add the existing record
                    list.Add(new FieldingStintRecord(fielding, stint));
                } //an existing stint with IgnoreStint == true does not get added
            }
        }

        //constructor used with just a year number instead of a full SeasonDateRecord
        public FieldingStintList(string teamId, string lgId, long yearId, bool includeOutfieldDetails = false) {
            FieldingList fieldingList = Queries.TeamFieldingByID(teamId, lgId, yearId, includeOutfieldDetails);

            foreach (FieldingRecord fielding in fieldingList.GetResults()) {
                StintRecord? stint = Queries.GetStint(teamId, yearId, fielding.PlayerId);
                list.Add(new FieldingStintRecord(fielding, stint));
            }
        }

        public List<FieldingStintRecord> GetResults() {
            return list;
        }
    }
}