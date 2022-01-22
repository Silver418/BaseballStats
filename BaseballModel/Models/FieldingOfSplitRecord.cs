using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class FieldingOfSplitRecord {
        public string PlayerId { get; private set; }
        public long YearId { get; private set; }
        public long Stint { get; private set; }
        public string TeamId { get; private set; } = "";
        public string LgId { get; private set; } = "";
        public string Pos { get; private set; } //Position
        public long G { get; private set; } = 0; //Games played
        public long Gs { get; private set; } = 0; //Games started
        public long InnOuts { get; private set; } = 0; //Time played in the field, as # of outs
        public long Po { get; private set; } = 0; //Put Outs
        public long A { get; private set; } = 0; //Assists
        public long E { get; private set; } = 0; //Errors
        public long Dp { get; private set; } = 0; //Double Plays
        //calculated
        public decimal FPct { get; private set; } = 0; //Fielding Percentage: (Po + A) / (Po + A + Errors)
        //queried fields
        public string TeamName { get; private set; } = "";



        public FieldingOfSplitRecord(FieldingOfsplit fieldingOfSplit) {
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
            if (fieldingOfSplit.G != null) {
                G = (long)fieldingOfSplit.G;
            }
            if (fieldingOfSplit.Gs != null) {
                Gs = (long)fieldingOfSplit.Gs;
            }
            if (fieldingOfSplit.InnOuts != null) {
                InnOuts = (long)fieldingOfSplit.InnOuts;
            }
            if (fieldingOfSplit.Po != null) {
                Po = (long)fieldingOfSplit.Po;
            }
            if (fieldingOfSplit.A != null) {
                A = (long)fieldingOfSplit.A;
            }
            if (fieldingOfSplit.E != null) {
                E = (long)fieldingOfSplit.E;
            }
            if (fieldingOfSplit.Dp != null) { 
                Dp = (long)fieldingOfSplit.Dp;
            }

            //calculated fields
            if ((Po + A + E) != 0) {
                FPct = decimal.Round((Po + A) / (decimal)(Po + A + E), 3);
            }
            
            //query for team name
            TeamName = Queries.GetTeamName(TeamId, YearId);

        } // end constructor
    } //end FieldingOfSplitRecord class
} //end BaseballModel.Models namespace
