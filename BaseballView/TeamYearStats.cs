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
    public partial class TeamYearStats : UserControl {
        //handle to container of the this control (so the Close button can remove this control)
        private Panel myHome { get; set; }
        //ID results from search form
        private long yearId { get; set; }
        private string teamId { get; set; }
        private string lgId { get; set; }
        //storage for collections matching IDs from search form
        private BattingList battingResults;
        private PitchingList pitchingResults;
        private FieldingList fieldingResults;
        private FieldingList outfieldResults;
        
        //constructor
        public TeamYearStats(Panel containing) {
            InitializeComponent();
            myHome = containing;

            //batting grid setup
            battingGrid.AutoGenerateColumns = false;

            battingGrid.Columns.Add(Helpers.MakeColumn("Player ID", "PlayerId"));
            battingGrid.Columns.Add(Helpers.MakeColumn("First Name", "NameFirst"));
            battingGrid.Columns.Add(Helpers.MakeColumn("Last Name", "NameLast"));
            battingGrid.Columns.Add(Helpers.MakeColumn("Bats", "BattingHand", "Batting Hand"));
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
            battingGrid.Columns.Add(Helpers.MakeColumn("AVG", "Avg", "Batting Average", "f3"));

            //pitching grid setup
            pitchingGrid.AutoGenerateColumns = false;

            pitchingGrid.Columns.Add(Helpers.MakeColumn("Player ID", "PlayerId"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("First Name", "NameFirst"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("Last Name", "NameLast"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("Throws", "ThrowingHand", "Throwing Hand"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("W", "W", "Wins"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("L", "L", "Losses"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("ERA", "Era", "Earned Run Average", "f2"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("G", "G", "Games Played"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("GS", "Gs", "Games Started"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("CG", "Cg", "Complete Games"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("SV", "Sv", "Saves"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("IP", "Ip", "Innings Pitched", "f2"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("H", "H", "Hits Allowed"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("R", "R", "Runs Allowed"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("ER", "Er", "Earned Runs Allowed"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("HR", "Hr", "Home Runs Allowed"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("BB", "Bb", "Walks Allowed"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("SO", "So", "Strike Outs"));

            //fielding grid setup
            fieldingGrid.AutoGenerateColumns = false;

            fieldingGrid.Columns.Add(Helpers.MakeColumn("Player ID", "PlayerId"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("First Name", "NameFirst"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("Last Name", "NameLast"));
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

            //outfielding splits grid setup
            outfieldGrid.AutoGenerateColumns = false;

            outfieldGrid.Columns.Add(Helpers.MakeColumn("Player ID", "PlayerId"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("First Name", "NameFirst"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("Last Name", "NameLast"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("POS", "Pos", "Position"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("G", "G", "Games Played"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("GS", "Gs", "Games Started"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("PO", "Po", "Put Outs"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("A", "A", "Assists"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("E", "E", "Errors"));
            outfieldGrid.Columns.Add(Helpers.MakeColumn("FPct", "FPct", "Fielding Percent", "f3"));
        } //end constructor

        private void closeBtn_Click(object sender, EventArgs e) {
            if (myHome is TabPage) {
                myHome.Parent.Controls.Remove(myHome);
            }
            else {
                myHome.Controls.Remove(this);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e) {
            TeamYearSearch form = new TeamYearSearch();
            var result = form.ShowDialog();
            if (result == DialogResult.OK) {
                yearId = form.YearIdResult;
                teamId = form.TeamIdResult;
                lgId = form.LgIdResult;

                TeamYearSearchRecord teamRecord = Queries.TeamYearByID(teamId, lgId, yearId);

                //team "bio" info
                yearLbl.Text = teamRecord.YearId.ToString();
                teamIdLbl.Text = teamRecord.TeamId;
                leagueLbl.Text = teamRecord.LgId;
                teamNameLbl.Text = teamRecord.Name;
                divLbl.Text = teamRecord.DivId;
                parkLbl.Text = teamRecord.Park;
                attendanceLbl.Text = teamRecord.Attendance.ToString("n");
                gamesLbl.Text = teamRecord.G.ToString();
                winLbl.Text = teamRecord.W.ToString();
                lossLbl.Text = teamRecord.L.ToString();
                rankLbl.Text = teamRecord.Rank.ToString();
                batAvgLbl.Text = teamRecord.Avg.ToString("f3");
                eraLbl.Text = teamRecord.Era.ToString("f2");

                //update tab label
                if (myHome is TabPage) {
                    TabPage myTab = (TabPage)myHome;
                    myTab.Text = $"{teamRecord.Name} {teamRecord.YearId}";
                }

                //fetch batting record
                battingResults = Queries.TeamBattingByID(teamId, lgId, yearId);
                if (battingResults != null) {
                    //data bind to grid
                    battingGrid.DataSource = battingResults.GetResults();
                }
                else battingGrid.DataSource = null;

                //fetch pitching record
                pitchingResults = Queries.TeamPitchingByID(teamId, lgId, yearId);
                if (pitchingResults != null) {
                    //data bind to grid
                    pitchingGrid.DataSource = pitchingResults.GetResults();
                }
                else pitchingGrid.DataSource = null;



                //fetch fielding record
                fieldingResults = Queries.TeamFieldingByID(teamId, lgId, yearId);
                if (fieldingResults != null) {
                    fieldingGrid.DataSource = fieldingResults.GetResults();
                }
                else fieldingGrid.DataSource = null;

                //fetch outfielding detailed data
                outfieldResults = Queries.TeamOutfieldingByID(teamId, lgId, yearId);
                if (outfieldResults != null) {
                    outfieldGrid.DataSource = outfieldResults.GetResults();
                }
            }
        }  //end search button event
    }
}
