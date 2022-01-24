namespace BaseballView {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        //*****
        //Helper functions
        private TabPage NewContentTab(string label) {
            TabPage newTab = new TabPage();
            newTab.Text = label;
            newTab.AutoScroll = true;
            return newTab;
        }
        //*****

        private void navPlayerStats_Click(object sender, EventArgs e) {
            TabPage newTab = NewContentTab("Player Statistics");
            PlayerStats playerStats = new PlayerStats(newTab);
            playerStats.Dock = DockStyle.Fill;
            newTab.Controls.Add(playerStats);
            contentTabs.Controls.Add(newTab);
            contentTabs.SelectedTab = newTab;
        }

        private void navTeamYearStats_Click(object sender, EventArgs e) {
            TabPage newTab = NewContentTab("Team Statistics by Year");
            TeamYearStats teamYearStats = new TeamYearStats(newTab);
            teamYearStats.Dock = DockStyle.Fill;
            newTab.Controls.Add(teamYearStats);
            contentTabs.Controls.Add(newTab);
            contentTabs.SelectedTab = newTab;
        }

        private void navSeasonDates_Click(object sender, EventArgs e) {
            TabPage newTab = NewContentTab("Season Dates");
            SeasonDatesEdit seasonDatesEdit = new SeasonDatesEdit();
            seasonDatesEdit.Dock = DockStyle.Fill;
            newTab.Controls.Add(seasonDatesEdit);
            contentTabs.Controls.Add(newTab);
            contentTabs.SelectedTab = newTab;
        }
    }
}