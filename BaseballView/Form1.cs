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
            //if a Season edit tab already exists, switch to it (only one needed, & avoids having multiple editors open)
            bool alreadyExists = false;
            foreach (TabPage tab in contentTabs.Controls) {
                if (tab.Controls[0] is SeasonDatesEdit) {
                    contentTabs.SelectedTab = tab;
                    alreadyExists = true;
                }
            }
            //otherwise, create new tab
            if (!alreadyExists) {
                TabPage newTab = NewContentTab("Season Dates");
                SeasonDatesEdit seasonDatesEdit = new SeasonDatesEdit(newTab);
                seasonDatesEdit.Dock = DockStyle.Fill;
                newTab.Controls.Add(seasonDatesEdit);
                contentTabs.Controls.Add(newTab);
                contentTabs.SelectedTab = newTab;
            }
        } //end navSeasonDates_Click event

    } //end Form1 class
} //end BaseballView namespace