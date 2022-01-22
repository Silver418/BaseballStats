using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class TeamYearSearchRecord {
        public long YearId { get; private set; } = 0;
        public string LgId { get; private set; } = "";
        public string TeamId { get; private set; } = "";
        public string Name { get; private set; } = "";
        public string Park { get; private set; } = ""; //name of home stadium
        public string DivId { get; private set; } = ""; //division id
        public long Rank { get; private set; } = 0; //rank in league standings
        public long G { get; private set; } = 0; //games played
        public long W { get; private set; } = 0; //wins
        public long L { get; private set; } = 0; //losses
        public long Ab { get; private set; } = 0; //at bats
        public long H { get; private set; } = 0; //hits
        public decimal Era { get; private set; } = 0; //earned run average
        public long Attendance { get; private set; } = 0; //total home game attendance

        //calculated stats
        public decimal Avg { get; private set; } = 0; //Batting average

        //constructor
        public TeamYearSearchRecord(Team team) {
            //guaranteed inputs
            YearId = team.YearId;
            LgId = team.LgId;
            TeamId = team.TeamId;
            //nullable inputs
            if (team.Name != null) {
                Name = team.Name;
            }
            if (team.Park != null) { 
                Park = team.Park;
            }
            if (team.DivId != null) {
                DivId = team.DivId;
            }
            if (team.Rank != null) { 
                Rank = (long)team.Rank;
            }
            if (team.G != null) {
                G = (long)team.G;
            }
            if (team.W != null) { 
                W = (long)team.W;
            }
            if (team.L != null) {
                L = (long)team.L;
            }
            if (team.Ab != null) { 
                Ab = (long)team.Ab;
            }
            if (team.H != null) { 
                H = (long)team.H;
            }
            if (team.Era != null) { 
                Era = (decimal)team.Era;
            }
            if (team.Attendance != null) { 
                Attendance = (long)team.Attendance;
            }
            //Calculated
            if (Ab != 0) {
                // Batting average: hits / at bats
                Avg = decimal.Round(H / (decimal)Ab, 3);
            }

        } //end constructor
    } //end TeamYearSearchRecord class
} //end BaseballModel.Models namespace
