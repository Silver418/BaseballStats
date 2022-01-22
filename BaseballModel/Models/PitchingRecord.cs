using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class PitchingRecord {
        //keys from db
        public string PlayerId { get; private set; } = "";
        public long YearId { get; private set; } = 0;
        public long Stint { get; private set; } = 0;
        public string TeamId { get; private set; } = "";
        public string LgId { get; private set; } = "";
        //stats from db
        public long W { get; private set; } = 0; //Wins
        public long L { get; private set; } = 0; //Losses
        public long G { get; private set; } = 0; //Games
        public long Gs { get; private set; } = 0; //Games Started
        public long Cg { get; private set; } = 0; //Complete Games
        public long Sho { get; private set; } = 0; //Shutouts
        public long Sv { get; private set; } = 0; //Saves
        public long Ipouts { get; private set; } = 0; //Outs Pitched
        public long H { get; private set; } = 0; //Hits
        public long Er { get; private set; } = 0; //Earned Runs
        public long Hr { get; private set; } = 0; //Homeruns
        public long Bb { get; private set; } = 0; //Walks
        public long So { get; private set; } = 0; //Strikeouts
        public double Baopp { get; private set; } = 0; //Opponent's batting average
        public double Era { get; private set; } = 0; //Earned Run Average
        public long Ibb { get; private set; } = 0; //Intentional Walks
        public long Wp { get; private set; } = 0; //Wild Pitches
        public long Hbp { get; private set; } = 0; //Batters hit by pitch
        public long Bk { get; private set; } = 0; //Balks
        public long Bfp { get; private set; } = 0; //Batters faced by pitcher
        public long Gf { get; private set; } = 0; //Games finished
        public long R { get; private set; } = 0; //Runs allowed
        public long Sh { get; private set; } = 0; //Sacrifices by opposing batters
        public long Sf { get; private set; } = 0; //Sacrifice flies by opposing batter
        public long Gidp { get; private set; } = 0; //Grounded into double plays by opposing batter
        //calculated fields
        public decimal Ip { get; private set; } = 0; //Innings Pitches (Outs pitched / 3)
        public decimal Whip { get; private set; } = 0; //Walks and hits per innings pitched: (H + BB) / IP
        //queried fields
        public string TeamName { get; private set; } = "";
        public string NameFirst { get; private set; } = "";
        public string NameLast { get; private set; } = "";
        public string ThrowingHand { get; private set; } = "";

        //constructor
        public PitchingRecord(Pitching pitching) {
            //from db
            PlayerId = pitching.PlayerId;
            YearId = pitching.YearId;
            Stint = pitching.Stint;

            if (pitching.TeamId != null) {
                TeamId = pitching.TeamId;
            }

            if (pitching.LgId != null) {
                LgId = pitching.LgId;
            }

            if (pitching.W != null) {
                W = (long)pitching.W;
            }

            if (pitching.L != null) {
                L = (long)pitching.L;
            }

            if (pitching.G != null) {
                G = (long)pitching.G;
            }

            if (pitching.Gs != null) {
                Gs = (long)pitching.Gs;
            }

            if (pitching.Cg != null) {
                Cg = (long)pitching.Cg;
            }

            if (pitching.Sho != null) {
                Sho = (long)pitching.Sho;
            }

            if (pitching.Sv != null) {
                Sv = (long)pitching.Sv;
            }

            if (pitching.Ipouts != null) {
                Ipouts = (long)pitching.Ipouts;
            }

            if (pitching.H != null) {
                H = (long)pitching.H;
            }

            if (pitching.Er != null) {
                Er = (long)pitching.Er;
            }

            if (pitching.Hr != null) {
                Hr = (long)pitching.Hr;
            }

            if (pitching.Bb != null) {
                Bb = (long)pitching.Bb;
            }

            if (pitching.So != null) {
                So = (long)pitching.So;
            }

            if (pitching.Baopp != null) {
                Baopp = (double)pitching.Baopp;
            }

            if (pitching.Era != null) {
                Era = (double)pitching.Era;
            }

            if (pitching.Ibb != null) {
                Ibb = (long)pitching.Ibb;
            }

            if (pitching.Wp != null) {
                Wp = (long)pitching.Wp;
            }

            if (pitching.Hbp != null) {
                Hbp = (long)pitching.Hbp;
            }

            if (pitching.Bk != null) {
                Bk = (long)pitching.Bk;
            }

            if (pitching.Bfp != null) {
                Bfp = (long)pitching.Bfp;
            }

            if (pitching.Gf != null) {
                Gf = (long)pitching.Gf;
            }

            if (pitching.R != null) {
                R = (long)pitching.R;
            }

            if (pitching.Sh != null) {
                Sh = (long)pitching.Sh;
            }

            if (pitching.Sf != null) {
                Sf = (long)pitching.Sf;
            }

            if (pitching.Gidp != null) {
                Gidp = (long)pitching.Gidp;
            }
            //calculated fields
            Ip = decimal.Round(Ipouts / (decimal)3, 2);
            if (Ip != 0) {
                Whip = decimal.Round((H + Bb) / Ip, 3);
            }

            //query for team name
            TeamName = Queries.GetTeamName(TeamId, YearId);
            (NameFirst, NameLast) = Queries.PlayerName(PlayerId);
            ThrowingHand = Queries.PlayerThrowingHand(PlayerId);


        } //end constructor

    } //end PitchingRecord class

} //end namespace BaseballModel.Models

