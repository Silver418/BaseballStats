using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class PersonStint {
        public string PlayerId { get; private set; }
        public long YearId { get; private set; }
        public string NameFirst { get; private set; }
        public string NameLast { get; private set; }
        public int Count { get; private set; } //# stints
        public string Teams { get; private set; } = ""; //list of all teams the player was on during this season
        public bool IsComplete { get; private set; } = false; //whether all stint records have complete date data entered
        private List<StintRecord> stintsApproved = new List<StintRecord>(); //for records pulled from database, or validated & saved to database
        public List<StintRecord> stintsEditable = new List<StintRecord>(); //for user-editable records, subject to validation before being saved

        //*****

        //Constructor
        internal PersonStint(string playerId, long yearId, DateTime seasonStart, DateTime seasonEnd, int seasonDuration) {
            PlayerId = playerId;
            YearId = yearId;
            (NameFirst, NameLast) = Queries.PlayerName(PlayerId);
            stintsApproved = Queries.GetPlayerStints(YearId, PlayerId);
            //if first and last stint record don't have dates (ie, they were fresh records), add the season start/stop dates to them
            if (stintsApproved.Count > 0) {
                if (stintsApproved[0].StintStart == null) {
                    stintsApproved[0].StintStart = seasonStart;
                }
                if (stintsApproved[stintsApproved.Count - 1].StintEnd == null) {
                    stintsApproved[stintsApproved.Count - 1].StintEnd = seasonEnd;
                }
            }
            foreach (StintRecord stint in stintsApproved) { //do StintX calculations
                stint.CalcStintX(seasonDuration);
            }
            ApprovedToEditableStints(); //Copy approved records from database to editable stint list for user changes
            Count = stintsApproved.Count;
            FillTeams();
            
            if (Validate(seasonStart, seasonEnd)) { //if record as pulled form db passes validation, mark player as complete
                IsComplete = true;
            }
        }

        //Populate teams string from stints
        private void FillTeams() {
            //make temporary list
            List<string> teams = new List<string>();
            //search stint records for team names that aren't already in the temporary list & add them
            //(it's common for players to trade back to a team they originally started in; we only want a team's name once)
            foreach (StintRecord record in stintsApproved) {
                if (!teams.Any(x => x.Equals(record.TeamName))) {
                    teams.Add(record.TeamName);
                }
            }
            //add all teams in temporary list to Teams string for display
            for (int i = 0; i < teams.Count; i++) {
                if (i == 0) {
                    Teams += teams[i];
                }
                else {
                    Teams += $", {teams[i]}";
                }
            }
        }

        //whether player has any stints with a specific team (by ID)
        internal bool PlayedForTeam(string teamId) {
            foreach (StintRecord stint in stintsApproved) {
                if (stint.TeamId.Equals(teamId)) {
                    return true;
                }
            }
            return false;
        }

        //Copy the approved stints to editable. Use to build initial editable copy and to cancel user changes.
        internal void ApprovedToEditableStints() {
            stintsEditable = new List<StintRecord>();
            foreach (StintRecord record in stintsApproved) {
                stintsEditable.Add(record.Copy());
            }
        }

        //validate stints only
        internal bool Validate(DateTime seasonStart, DateTime seasonEnd) {
            for (int i = 0; i < stintsEditable.Count; i++) {

                if (stintsEditable[i].StintStart == null || stintsEditable[i].StintEnd == null) {
                    return false; //fail if any dates have null values
                }
                if (stintsEditable[i].StintStart >= stintsEditable[i].StintEnd) {
                    return false;
                }
                //check start date
                if (i == 0) { //first record in set fails if it starts before the season starts
                    if (stintsEditable[i].StintStart < seasonStart) {
                        return false;
                    }
                }
                else { //all others fails they start before the previous stint ends
                    if (stintsEditable[i].StintStart < stintsEditable[i - 1].StintEnd) {
                        return false;
                    }
                }

                //check end date
                if (i == stintsEditable.Count - 1) { //last record in set fails if it ends after the season ends
                    if (stintsEditable[i].StintEnd > seasonEnd) {
                        return false;
                    }
                }
                else { //all others fails if they end after the next stint starts
                    if (stintsEditable[i].StintEnd > stintsEditable[i + 1].StintEnd) {
                        return false;
                    }
                }
            } //end for loop validating all stints
            return true;
        }

        //Validate editable stints & save to approved stints if passed
        internal (bool isValid, int recordsUpdated) ValidateSave(DateTime seasonStart, DateTime seasonEnd, int seasonDuration) {
            if (Validate(seasonStart, seasonEnd)) {
                //new Approved Stints list
                stintsApproved = new List<StintRecord>();

                //calculate derived values, copy records to Approved, and save back to database
                int changedRecords = 0;
                foreach (StintRecord stint in stintsEditable) {
                    stint.CalcDuration();
                    stint.CalcStintX(seasonDuration);
                    stintsApproved.Add(stint.Copy());
                    changedRecords += Queries.UpdateStint(stint);
                }

                IsComplete = true;
                return (true, changedRecords);

            }
            else return (false, 0);
        }
    }
}
