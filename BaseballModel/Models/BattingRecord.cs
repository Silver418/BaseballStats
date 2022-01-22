using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class BattingRecord {
        //**********
        //fields
        //keys from db
        public string PlayerId { get; set; } = null!;
        public long YearId { get; set; } = 0;
        public long Stint { get; set; } = 0;
        public string TeamId { get; set; } = "";
        public string LgId { get; set; } = "";
        //stats from db
        public long G { get; private set; } = 0; //Games Played
        public long Ab { get; private set; } = 0; //At Bats
        public long R { get; private set; } = 0; //Runs
        public long H { get; private set; } = 0; //Hits
        public long _2b { get; private set; } = 0; //Doubles
        public long _3b { get; private set; } = 0; //Triples
        public long Hr { get; private set; } = 0; //Home Runs
        public long Rbi { get; private set; } = 0; //Runs Batted In
        public long Sb { get; private set; } = 0; //Stolen Bases
        public long Cs { get; private set; } = 0; //Caught Stealing
        public long Bb { get; private set; } = 0; //Walks
        public long So { get; private set; } = 0; //Strike Outs
        public long Ibb { get; private set; } = 0; //Intentional Walks
        public long Hbp { get; private set; } = 0; //Hit By Pitcher
        public long Sh { get; private set; } = 0; //Sacrifice Hits
        public long Sf { get; private set; } = 0; //Sacrifice Flies
        public long Gidp { get; private set; } = 0; //Grounded Into Double Play
        //calculated stats
        public decimal Avg { get; private set; } = 0; //Batting average
        public decimal Slg { get; private set; } = 0; //Slugging percentage
        public decimal Obp { get; private set; } = 0; //On-base percentage
        public decimal Ops { get; private set; } = 0; //On-base plus slugging
        //queried fields
        public string TeamName { get; private set; } = "";
        public string NameFirst { get; private set; } = "";
        public string NameLast { get; private set; } = "";
        public string BattingHand { get; private set; } = "";


        //******
        //constructor
        public BattingRecord(Batting batting) {
            PlayerId = batting.PlayerId;
            YearId = batting.YearId;
            Stint = batting.Stint;

            if (batting.TeamId != null) {
                TeamId = batting.TeamId;
            }

            if (batting.LgId != null) {
                LgId = batting.LgId;
            }

            if (batting.G != null) {
                G = (long)batting.G;
            }

            if (batting.Ab != null) {
                Ab = (long)batting.Ab;
            }

            if (batting.R != null) {
                R = (long)batting.R;
            }

            if (batting.H != null) {
                H = (long)batting.H;
            }

            if (batting._2b != null) {
                _2b = (long)batting._2b;
            }

            if (batting._3b != null) {
                _3b = (long)batting._3b;
            }

            if (batting.Hr != null) {
                Hr = (long)batting.Hr;
            }

            if (batting.Rbi != null) {
                Rbi = (long)batting.Rbi;
            }

            if (batting.Sb != null) {
                Sb = (long)batting.Sb;
            }

            if (batting.Cs != null) {
                Cs = (long)batting.Cs;
            }

            if (batting.Bb != null) {
                Bb = (long)batting.Bb;
            }

            if (batting.So != null) {
                So = (long)batting.So;
            }

            if (batting.Ibb != null) {
                Ibb = (long)batting.Ibb;
            }

            if (batting.Hbp != null) {
                Hbp = (long)batting.Hbp;
            }

            if (batting.Sh != null) {
                Sh = (long)batting.Sh;
            }

            if (batting.Sf != null) {
                Sf = (long)batting.Sf;
            }

            if (batting.Gidp != null) {
                Gidp = (long)batting.Gidp;
            }

            //Calculated
            if (Ab != 0) {
                // Batting average: hits / at bats
                Avg = decimal.Round(H / (decimal)Ab, 3);
                // slugging %: Total bases / at bats
                Slg = decimal.Round((H + _2b + 2 * _3b + 3 * Hr) / (decimal)Ab, 3);
                // on base %: Hits + Walks + HitByPitcher / at bats
                Obp = decimal.Round((H + Bb + Hbp) / (decimal)(Ab + Bb + Hbp + Sf), 3);
                //on base plus slugging: SLG + OBP
                Ops = Slg + Obp;
            }

            //queries
            TeamName = Queries.GetTeamName(TeamId, YearId);
            (NameFirst, NameLast) = Queries.PlayerName(PlayerId);
            BattingHand = Queries.PlayerBattingHand(PlayerId);

        } //end constructor

    } //end BattingRecord

} //end namespace BaseballModels.Model
