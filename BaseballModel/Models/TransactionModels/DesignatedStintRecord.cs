using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class DesignatedStintRecord {
        private SeasonDateRecord? season { get; set; }
        public string PlayerId { get; private set; }
        public long YearId { get; private set; }
        public string TeamId { get; private set; }
        public string LgId { get; private set; }
        public string Pos { get; } = "DH"; //position
        public long GDh { get; private set; } //games played as a designated hitter
        public long GDefense { get; private set; } //games played at a defensive position
        public List<StintRecord> StintRecords { get; private set; } //collection of this player's stint records
                                                                      //TODO: want all stints, or for this team only?
        //queried data
        public string TeamName { get; private set; }
        public string NameFirst { get; private set; }
        public string NameLast { get; private set; }
        //calculated data
        public decimal StintXSum { get; private set; } = 0; //sum of all stints a player did for this team
        public int Count { get; private set; }

        public DesignatedStintRecord(AppearanceRecord appeareance, List<StintRecord> stintRecords, SeasonDateRecord? s = null) {
            StintRecords = stintRecords;
            this.season = s;

            //extracting appearance data
            PlayerId = appeareance.PlayerId;
            YearId = appeareance.YearId;
            TeamId = appeareance.TeamId;
            LgId = appeareance.LgId;
            GDh = appeareance.GDh ?? 0;
            GDefense = appeareance.GDefense ?? 0;

            //queried data
            TeamName = Queries.GetTeamName(TeamId, YearId);
            (NameFirst, NameLast) = Queries.PlayerName(PlayerId);
            //calculated data
            foreach (StintRecord record in stintRecords) {
                if(TeamId == record.TeamId) {
                    StintXSum += record.StintX;
                }
            }
            Count = StintRecords.Count();
        }
    }
}
