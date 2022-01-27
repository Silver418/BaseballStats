namespace BaseballView {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        //*****
        //Helper functions
        //*****
        private TabPage NewContentTab(string label) {
            TabPage newTab = new TabPage();
            newTab.Text = label;
            newTab.AutoScroll = true;
            return newTab;
        }

        private void AddTabContent(TabPage newTab, UserControl tabContents) {
            tabContents.Dock = DockStyle.Fill;
            newTab.Controls.Add(tabContents);
            contentTabs.Controls.Add(newTab);
            contentTabs.SelectedTab = newTab;
        }
        

        //*****
        //Events
        //*****
        private void navPlayerStats_Click(object sender, EventArgs e) {
            TabPage newTab = NewContentTab("Player Statistics");
            AddTabContent(newTab, new PlayerStats(newTab));
        }

        private void navTeamYearStats_Click(object sender, EventArgs e) {
            TabPage newTab = NewContentTab("Team Statistics by Year");
            AddTabContent(newTab, new TeamYearStats(newTab));
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
                AddTabContent(newTab, new SeasonDatesEdit(newTab));
            }
        } //end navSeasonDates_Click event

        private void navStintEdit_Click(object sender, EventArgs e) {
            //if a stint edit tab already exists, switch to it (avoids having multiple editors open)
            bool alreadyExists = false;
            foreach (TabPage tab in contentTabs.Controls) {
                if (tab.Controls[0] is StintEdit) {
                    contentTabs.SelectedTab = tab;
                    alreadyExists = true;
                }
            }
            //otherwise, new tab
            if (!alreadyExists) {
                TabPage newTab = NewContentTab("Edit Stints");
                AddTabContent(newTab, new StintEdit(newTab));
            }
        }
    } //end Form1 class
} //end BaseballView namespace