using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballView {


    public partial class PlayerStats : UserControl {
        //handle to container of the PlayerStats control (so the Close button can remove this control)
        private Panel myHome { get; set; }
        //results from child search form
        private BattingList battingResults;
        private PitchingList pitchingResults;
        private FieldingList fieldingResults;
        private FieldingList outfieldResults;

        public PlayerStats(Panel containing) {
            InitializeComponent();
            myHome = containing;

            //batting grid setup
            battingGrid.AutoGenerateColumns = false;

            battingGrid.Columns.Add(Helpers.MakeColumn("Year", "YearId"));
            battingGrid.Columns.Add(Helpers.MakeColumn("Team", "TeamName"));
            battingGrid.Columns.Add(Helpers.MakeColumn("Stint", "Stint"));
            battingGrid.Columns.Add(Helpers.MakeColumn("League", "LgId"));
            battingGrid.Columns.Add(Helpers.MakeColumn("G", "G", "Games Played"));
            battingGrid.Columns.Add(Helpers.MakeColumn("AB", "Ab", "At Bats"));
            battingGrid.Columns.Add(Helpers.MakeColumn("R", "R", "Runs"));
            battingGrid.Columns.Add(Helpers.MakeColumn("H", "H", "Hits"));
            battingGrid.Columns.Add(Helpers.MakeColumn("2B", "_2b", "Doubles"));
            battingGrid.Columns.Add(Helpers.MakeColumn("3B", "_3b", "Triples"));
            battingGrid.Columns.Add(Helpers.MakeColumn("HR", "Hr", "Home Runs"));
            battingGrid.Columns.Add(Helpers.MakeColumn("RBI", "Rbi", "Runs Batted In"));
            battingGrid.Columns.Add(Helpers.MakeColumn("SB", "Sb", "Stolen Bases"));
            battingGrid.Columns.Add(Helpers.MakeColumn("CS", "Cs", "Caught Stealing"));
            battingGrid.Columns.Add(Helpers.MakeColumn("BB", "Bb", "Walks"));
            battingGrid.Columns.Add(Helpers.MakeColumn("SO", "So", "Strike Outs"));
            battingGrid.Columns.Add(Helpers.MakeColumn("IBB", "Ibb", "Intentional Walks"));
            battingGrid.Columns.Add(Helpers.MakeColumn("HBP", "Hbp", "Hit By Pitcher"));
            battingGrid.Columns.Add(Helpers.MakeColumn("SH", "Sh", "Sacrifice Hits"));
            battingGrid.Columns.Add(Helpers.MakeColumn("SF", "Sf", "Sacrifice Flies"));
            battingGrid.Columns.Add(Helpers.MakeColumn("GIDP", "Gidp", "Grounded Into Double Plays"));
            battingGrid.Columns.Add(Helpers.MakeColumn("AVG", "Avg", "Batting Average", "f3"));
            battingGrid.Columns.Add(Helpers.MakeColumn("SLG", "Slg", "Slugging Average", "f3"));
            battingGrid.Columns.Add(Helpers.MakeColumn("OBP", "Obp", "On-Base Percentage", "f3"));
            battingGrid.Columns.Add(Helpers.MakeColumn("OPS", "Ops", "On-Base% + Slugging Avg", "f3"));

            //pitching grid setup
            pitchingGrid.AutoGenerateColumns = false;
            
            pitchingGrid.Columns.Add(Helpers.MakeColumn("Year", "YearId"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("Team", "TeamName"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("League", "LgId"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("Stint", "Stint"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("W", "W", "Wins"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("L", "L", "Losses"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("ERA", "Era", "Earned Run Average", "f2"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("G", "G", "Games Played"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("GS", "Gs", "Games Started"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("CG", "Cg", "Complete Games"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("SHO", "Sho", "Shutouts"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("SV", "Sv", "Saves"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("IP", "Ip", "Innings Pitched", "f2"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("H", "H", "Hits Allowed"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("R", "R", "Runs Allowed"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("ER", "Er", "Earned Runs Allowed"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("HR", "Hr", "Home Runs Allowed"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("BB", "Bb", "Walks Allowed"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("SO", "So", "Strike Outs"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("WHIP", "Whip", "Walks and Hits per Innings Pitched", "f3"));

            
            //fielding grid setup
            fieldingGrid.AutoGenerateColumns = false;

            fieldingGrid.Columns.Add(Helpers.MakeColumn("Year", "YearId"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("Team", "TeamName"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("League", "LgId"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("Stint", "Stint"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("POS", "Pos", "Position"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("GLF", "Glf", "Games Played in Left Field", "#"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("GCF", "Gcf", "Games Played in Center Field", "#"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("GRF", "Grf", "Games Played in Right Field", "#"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("G", "G", "Games Played"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("GS", "Gs", "Games Started"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("PO", "Po", "Put Outs"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("A", "A", "Assists"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("E", "E", "Errors"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("FPct", "FPct", "Fielding Percent", "f3"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("DP", "Dp", "Double Plays"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("PB", "Pb", "Passed Balls (catchers)"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("SB", "Sb", "Stolen Bases Allowed (catchers)"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("CS", "Cs", "Caught Stealing (catchers)"));

            //outfielding splits grid setup
            outfieldGrid.AutoGenerateColumns = false;

            outfieldGrid.Columns.Add(Helpers.MakeColumn("Year", "YearId"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("Team", "TeamName"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("League", "LgId"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("Stint", "Stint"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("POS", "Pos", "Position"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("G", "G", "Games Played"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("GS", "Gs", "Games Started"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("PO", "Po", "Put Outs"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("A", "A", "Assists"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("E", "E", "Errors"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("FPct", "FPct", "Fielding Percent", "f3"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("DP", "Dp", "Double Plays"));
        } //end constructor

        private void searchBtn_Click(object sender, EventArgs e) {
            PersonSearch form = new PersonSearch();
            var result = form.ShowDialog();
            if (result == DialogResult.OK) {
                string value = form.ReturnValueTest;
                playerIdLbl.Text = value;

                if (value != "") {
                    //query matching ID
                    PersonSearchRecord player = Queries.PersonByID(value);
                    //bio info
                    PlayerNameLbl.Text = $"{player.NameFirst} {player.NameLast}";
                    if (!String.IsNullOrEmpty(player.NameGiven)) {
                        GivenNameLbl.Text = $"({player.NameGiven})";
                    }
                    birthDateLbl.Text = player.BirthDate;
                    deathDateLbl.Text = player.DeathDate;
                    debutDateLbl.Text = player.Debut;
                    finalDateLbl.Text = player.FinalGame;
                    batHandLbl.Text = player.BatHand;
                    throwHandLbl.Text = player.ThrowHand;
                    
                    //update tab label
                    if (myHome is TabPage) {
                        TabPage myTab = (TabPage)myHome;
                        myTab.Text = $"{player.NameFirst} {player.NameLast}";
                    }

                    //fetch batting record
                    battingResults = Queries.BattingByID(value);
                    if (battingResults != null) {
                        //data bind to grid
                        battingGrid.DataSource = battingResults.GetResults();
                        //display life totals
                        batLifeAvgLbl.Text = battingResults.LifeAvg.ToString("f3");
                        batLifeAbLbl.Text = battingResults.LifeAb.ToString();
                        batLifeRunLbl.Text = battingResults.LifeR.ToString();
                        batLifeHitLbl.Text = battingResults.LifeH.ToString();
                        batLife2bLbl.Text = battingResults.Life2b.ToString();
                        batLife3bLbl.Text = battingResults.Life3b.ToString();
                        batLifeHrLbl.Text = battingResults.LifeHr.ToString();
                        batLifeRbiLbl.Text = battingResults.LifeRbi.ToString();
                        batLifeSbLbl.Text = battingResults.LifeSb.ToString();
                        batLifeCsLbl.Text = battingResults.LifeCs.ToString();
                        batLifeBbLbl.Text = battingResults.LifeBb.ToString();
                        batLifeSoLbl.Text = battingResults.LifeSo.ToString();
                    }
                    else battingGrid.DataSource = null;

                    //fetch pitching record
                    pitchingResults = Queries.PitchingByID(value);
                    if (pitchingResults != null) {
                        //data bind to grid
                        pitchingGrid.DataSource = pitchingResults.GetResults();
                        //display life totals
                        pchLifeWinLbl.Text = pitchingResults.LifeW.ToString();
                        pchLifeLossLbl.Text =  pitchingResults.LifeL.ToString();
                        pchLifeEraLbl.Text = pitchingResults.LifeEra.ToString("f2");
                        pchLifeGameLbl.Text = pitchingResults.LifeG.ToString();
                        pchLifeGsLbl.Text = pitchingResults.LifeGs.ToString();
                        pchLifeCgLbl.Text = pitchingResults.LifeCg.ToString();
                        pchLifeShoLbl.Text = pitchingResults.LifeSho.ToString();
                        pchLifeSvLbl.Text = pitchingResults.LifeSv.ToString();
                        pchLifeIpLbl.Text = pitchingResults.LifeIp.ToString("f2");
                        pchLifeHitsLbl.Text = pitchingResults.LifeH.ToString();
                        pchLifeRunLbl.Text = pitchingResults.LifeR.ToString();
                        pchLifeErLbl.Text = pitchingResults.LifeEr.ToString();
                        pchLifeHrLbl.Text = pitchingResults.LifeHr.ToString();
                        pchLifeBbLbl.Text = pitchingResults.LifeBb.ToString();
                        pchLifeSoLbl.Text = pitchingResults.LifeSo.ToString();
                    }
                    else pitchingGrid.DataSource = null;



                    //fetch fielding record
                    fieldingResults = Queries.FieldingByID(value);
                    if (fieldingResults != null) {
                        fieldingGrid.DataSource = fieldingResults.GetResults();
                    }
                    else fieldingGrid.DataSource = null;

                    outfieldResults = Queries.OutfieldingByID(value);
                    if (outfieldResults != null) {
                        outfieldGrid.DataSource = outfieldResults.GetResults();
                    }
                }
            }
        } //end search button event

        private void closeBtn_Click(object sender, EventArgs e) {
            if (myHome is TabPage) {
                myHome.Parent.Controls.Remove(myHome);
            }
            else {
                myHome.Controls.Remove(this);
            }
            
        }
    }
}
