using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class DesignatedStintRecord : IRosterRecord {
        private SeasonDateRecord? season { get; set; }
        public string PlayerId { get; private set; }
        public long YearId { get; private set; }
        public string TeamId { get; private set; }
        public string LgId { get; private set; }
        public string Pos { get; } = "DH"; //position
        public long GDh { get; private set; } //games played as a designated hitter
        public long GDefense { get; private set; } //games played at a defensive position
        public List<StintRecord> StintRecords { get; private set; } //collection of this player's stint records
        //queried data
        public string TeamName { get; private set; }
        public string NameFirst { get; private set; }
        public string NameLast { get; private set; }
        //calculated data
        public decimal StintXSum { get; private set; } = 0; //sum of all stints a player did for this team
        public int Count { get; private set; }
        public int StintDuration { get; private set; }  //sum of days for all stints for this team
        //Stint start & end - per client preferences, draws from start of first & end of last stint for this particular team (calculated in ctor)
        public DateTime? StintStart { get; private set; } = null;
        public DateTime? StintEnd { get; private set; } = null;
        //dummy properties for satisfying IRosterRecord - pulls data from another property with a different name
        public long? G { get => GDefense; }
        public long? Gs { get => GDh; }
        
        public decimal StintX { get => StintXSum; }

        //ctor
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
                    StintDuration += record.StintDuration;
                }
            }
            Count = StintRecords.Count();

            //Stint start & stop
            StintRecord first = null;
            StintRecord last = null;
            foreach (StintRecord record in stintRecords) {  //grab first & last stints player did for this team
                if (record.TeamId == TeamId) {
                    if (first == null) {
                        first = record;
                    }
                    last = record;
                }
            }
            if (first != null) {
                StintStart = first.StintStart;
            }
            if (last != null) {
                StintEnd = last.StintEnd;
            }
        }
    }
}
