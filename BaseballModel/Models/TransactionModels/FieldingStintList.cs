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
        public FieldingStintList(string teamId, string lgId, SeasonDateRecord s) {
            season = s;

            FieldingList fieldingList = Queries.TeamFieldingByID(teamId, lgId, season.YearId);

            foreach (FieldingRecord fielding in fieldingList.GetResults()) {
                StintRecord? stint = Queries.GetStint(teamId, season.YearId, fielding.PlayerId);
                if (stint != null) {
                    stint.CalcStintX(season.SeasonDuration);
                }
                FieldingStintRecord fsr = new FieldingStintRecord(fielding, stint);
                list.Add(fsr);
            }
        }

        //constructor used with just a year number instead of a full SeasonDateRecord
        public FieldingStintList(string teamId, string lgId, long yearId) {
            FieldingList fieldingList = Queries.TeamFieldingByID(teamId, lgId, yearId);

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