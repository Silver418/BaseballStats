using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public enum Position { LF, CF, RF } //Left, Center, and Right field enum

    public class OutfieldingRecord {
        //keys from db
        public string PlayerId { get; private set; }
        public long YearId { get; private set; }
        public long Stint { get; private set; }
        public string TeamId { get; private set; } = "";
        public string LgId { get; private set; } = "";
        //data fields from db
        public string Pos { get; private set; } //Position - required
        public long? G { get; private set; } //Games played
        public long? Gs { get; private set; } //Games started
        public long? InnOuts { get; private set; } //Time played in the field, as # of outs
        public long? Po { get; private set; } //Put Outs
        public long? A { get; private set; } //Assists
        public long? E { get; private set; } //Errors
        public long? Dp { get; private set; } //Double Plays
        //calculated
        public decimal? FPct { get; private set; } //Fielding Percentage: (Po + A) / (Po + A + Errors)
        //queried fields
        public string TeamName { get; private set; } = "";
        public string NameFirst { get; private set; } = "";
        public string NameLast { get; private set; } = "";

        //constructor with more detail from FieldingOf
        public OutfieldingRecord(FieldingOfsplit fieldingOfSplit) {
            //guaranteed inputs
            PlayerId = fieldingOfSplit.PlayerId;
            YearId = fieldingOfSplit.YearId;
            Stint = fieldingOfSplit.Stint;
            Pos = fieldingOfSplit.Pos;

            //nullable inputs
            if (fieldingOfSplit.TeamId != null) {
                TeamId = fieldingOfSplit.TeamId;
            }
            if (fieldingOfSplit.LgId != null) {
                LgId = fieldingOfSplit.LgId;
            }
            G = fieldingOfSplit.G;
            Gs = fieldingOfSplit.Gs;
            InnOuts = fieldingOfSplit.InnOuts;
            Po = fieldingOfSplit.Po;
            A = fieldingOfSplit.A;
            E = fieldingOfSplit.E;
            Dp = fieldingOfSplit.Dp;


            //calculated fields
            if ((Po + A) != null && (Po + A + E) != 0) {
                FPct = decimal.Round((decimal)((Po + A) / (decimal)(Po + A + E)), 3);
            }

            //query for team name
            TeamName = Queries.GetTeamName(TeamId, YearId);
            (NameFirst, NameLast) = Queries.PlayerName(PlayerId);


        } // end constructor using FieldingOfsplit

        //constructor with fieldingOf with fewer details
        public OutfieldingRecord(FieldingOf fieldingOf, Position pos) {
            PlayerId = fieldingOf.PlayerId;
            YearId = fieldingOf.YearId;
            Stint = fieldingOf.Stint;

            switch (pos) {
                case Position.LF:
                    Pos = "LF";
                    G = fieldingOf.Glf;
                    break;
                case Position.CF:
                    Pos = "CF";
                    G = fieldingOf.Gcf;
                    break;
                case Position.RF:
                    Pos = "RF";
                    G = fieldingOf.Grf;
                    break;
                default:
                    Pos = "RF";
                    G = 0;
                    break;
            } //end switch

            //query for team & league IDs
            (TeamId, LgId) = Queries.GetTeamLeague(PlayerId, YearId, Stint);
            //query for team name
            TeamName = Queries.GetTeamName(TeamId, YearId);
        } // end constructor using FieldingOf
    }
}
