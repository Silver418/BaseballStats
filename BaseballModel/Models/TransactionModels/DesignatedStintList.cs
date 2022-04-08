using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class DesignatedStintList {
        private List<DesignatedStintRecord> stintList = new List<DesignatedStintRecord>();

        //constructor which extracts year from season record & passes to main constructor
        public DesignatedStintList(string teamId, string lgId, SeasonDateRecord s)
            : this(teamId, lgId, s.YearId){}

        //constructor when season data isn't available
        public DesignatedStintList(string teamId, string lgId, long yearId) {
            AppearanceList appearanceList = Queries.TeamAppearancesByID(teamId, lgId, yearId);

            foreach (AppearanceRecord appearance in appearanceList.GetResults()) {
                if (appearance.GDh > 0) { //only interested in players with games as a designated hitter
                    List<StintRecord> stints = Queries.GetPlayerStints(yearId, appearance.PlayerId);

                    //if any stints for this team are not Ignored, generate a DesignatedStintRecord & add it to the list
                    if ((from stint in stints
                         where stint.TeamId == teamId
                         && stint.IgnoreStint == false
                         select stint).Any()) {
                        stintList.Add(new DesignatedStintRecord(appearance, stints));
                    }                    
                }
            }
        }

        public List<DesignatedStintRecord> GetResults() {
            return stintList;
        }
    }
}
