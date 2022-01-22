using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class FieldingRecord {
        //static
        private static string Catcher = "C"; //"C" in the Position field represents a catcher. Catcher records have some additional fields.
        private static string Outfielder = "OF"; //"OF" in the Position field represents a combined record for a player's center, left, and right outfield games. OF records have some additional fields.
        //keys from db
        public string PlayerId { get; private set; } = "";
        public long YearId { get; private set; } = 0;
        public long Stint { get; private set; } = 0;
        public string TeamId { get; private set; } = "";
        public string LgId { get; private set; } = "";
        //data fields from db
        public string Pos { get; private set; } = ""; //Position
        public long? G { get; private set; } //Games played
        public long? Gs { get; private set; } //Games started
        public long? InnOuts { get; private set; } //Time played in the field, as # of outs
        public long? Po { get; private set; } // Put Outs
        public long? A { get; private set; } // Assists
        public long? E { get; private set; } // Errors
        public long? Dp { get; private set; } // Double Plays
        public double? Zr { get; private set; } = 0; // Zone Rating (catchers only)
        //Catcher-only stats
        public long? Pb { get; private set; } // Passed Balls (catcher only)
        public long? Wp { get; private set; } // Wild Pitches (catchers only)
        public long? Sb { get; private set; } // Stolen Bases allowed (catchers only)
        public long? Cs { get; private set; } // Caught Stealing (catchers only)
        //calculated fields
        public decimal FPct { get; private set; } = 0; //Fielding Percentage: (Po + A) / (Po + A + Errors)
        //queried fields
        public string TeamName { get; private set; } = "";
        public string NameFirst { get; private set; } = "";
        public string NameLast { get; private set; } = "";
        //queried fields for combined outfielder records only (Pos="OF")
        public long Glf { get; private set; } = 0; //games left field (for outfielders)
        public long Gcf { get; private set; } = 0; //games center field (for outfielders)
        public long Grf { get; private set; } = 0; //games right field (for outfielders)


        //private chained constructor for shared logic of Fielding & FieldingOfSplit constructors
        private FieldingRecord(string playerId, long yearId, long stint, string pos, string? teamId, string? lgId,
            long? g, long? gs, long? innOuts, long? po, long? a, long? e, long? dp, double? zr ) {
            //guaranteed inputs
            PlayerId = playerId;
            YearId = yearId;
            Stint = stint;
            Pos = pos;

            //nullable inputs
            if (teamId != null) {
                TeamId = teamId;
            }
            if (lgId != null) {
                LgId = lgId;
            }
            G = g;
            Gs = gs;
            InnOuts = innOuts;
            Po = po;
            A = a;
            E = e;
            Dp = dp;
            Zr = zr;

            //calculated fields
            try {
                FPct = decimal.Round((decimal)(Po + A) / (decimal)(Po + A + E), 3);
            }
            catch (Exception exc) {
                //if any inputs for Po, A, or E are null or if (Po + A + E) is 0, then FPct should be 0, which is already default.
                //no further handling necessary
            }

            //queries
            TeamName = Queries.GetTeamName(TeamId, YearId);
            (NameFirst, NameLast) = Queries.PlayerName(PlayerId);
        } //end private constructor w/ shared logic

        //constructor using data from Fielding table
        public FieldingRecord(Fielding fielding)
            :this(fielding.PlayerId, fielding.YearId, fielding.Stint, fielding.Pos, fielding.TeamId, fielding.LgId,
                 fielding.G, fielding.Gs, fielding.InnOuts, fielding.Po, fielding.A, fielding.E, fielding.Dp, fielding.Zr) {

            //Catcher fields -- null for non-pitchers 
            if (Pos == Catcher) {
                Pb = fielding.Pb;
                Wp = fielding.Wp;
                Sb = fielding.Sb;
                Cs = fielding.Cs;
            }

            //query for # Outfield games played by position
            if (Pos.Equals(Outfielder)) {
                //first check the FieldingOFsplit table, which is more detailed
                //in cases where FieldingOFsplit & FieldingOF disagreed, more external sources (such as retrosheet.org) seemed to agree with FieldingOFsplit, so I'm preferring it

                (Glf, Gcf, Grf) = Queries.GetOutfieldingSplitGames(PlayerId, YearId, Stint);
                if (Glf + Gcf + Grf == 0) { //if no detailed split records were available, check the less-detailed FieldingOF table
                    var OfRecord = Queries.GetOutfieldingRecord(PlayerId, YearId, Stint);
                    if (OfRecord != null) {
                        Glf = OfRecord.Glf;
                        Gcf = OfRecord.Gcf;
                        Grf = OfRecord.Grf;
                    }
                }
            }
        } //end constructor for Fielding data

        //constructor using data from FieldingOFsplit table
        public FieldingRecord(FieldingOfsplit fieldingOfsplit)
            :this(fieldingOfsplit.PlayerId, fieldingOfsplit.YearId, fieldingOfsplit.Stint, fieldingOfsplit.Pos,
                 fieldingOfsplit.TeamId, fieldingOfsplit.LgId, fieldingOfsplit.G, fieldingOfsplit.Gs,
                 fieldingOfsplit.InnOuts, fieldingOfsplit.Po, fieldingOfsplit.A, fieldingOfsplit.E,
                 fieldingOfsplit.Dp, fieldingOfsplit.Zr) {
            //blank constructor; all work is in the private constructor w/ shared logic
        }

        //constructor using data from FieldingOF table
        public FieldingRecord(FieldingOf fieldingOf, Position pos) {
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
                default: //should never reach this position; switch accounts for all valid values of the Position enum
                    Pos = "XX";
                    G = 0;
                    break;
            } //end switch

            //queried data
            (TeamId, LgId) = Queries.GetTeamLeague(PlayerId, YearId, Stint);
            TeamName = Queries.GetTeamName(TeamId, YearId);
            (NameFirst, NameLast) = Queries.PlayerName(PlayerId);
        } // end constructor using FieldingOf

    } //end FieldingRecord class
} //end namespace BaseballModel.Models
