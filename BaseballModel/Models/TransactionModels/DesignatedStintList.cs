using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class DesignatedStintList {
        private List<DesignatedStintRecord> list = new List<DesignatedStintRecord>();
        private SeasonDateRecord? season;

        //constructor when season data is available
        public DesignatedStintList(string teamId, string lgId, SeasonDateRecord s) {
            season = s;

            AppearanceList appearanceList = Queries.TeamAppearancesByID(teamId, lgId, season.YearId);

            foreach (AppearanceRecord appearance in appearanceList.GetResults()){
                if (appearance.GDh > 0) { //only interested in players with games as a designated hitter
                    List<StintRecord> stints = Queries.GetPlayerStints(season.YearId, appearance.PlayerId, season.SeasonDuration);
                    DesignatedStintRecord dsr = new DesignatedStintRecord(appearance, stints);
                    list.Add(dsr);
                }
            }
        }

        //constructor when season data isn't available
        public DesignatedStintList(string teamId, string lgId, long yearId) {
            AppearanceList appearanceList = Queries.TeamAppearancesByID(teamId, lgId, yearId);

            foreach (AppearanceRecord appearance in appearanceList.GetResults()) {
                List<StintRecord> stints = Queries.GetPlayerStints(yearId, appearance.PlayerId);
                list.Add(new DesignatedStintRecord(appearance, stints));
            }
        }

        public List<DesignatedStintRecord> GetResults() {
            return list;
        }
    }
}
