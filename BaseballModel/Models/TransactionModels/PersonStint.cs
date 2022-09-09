using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class PersonStint : IComparable<PersonStint> {
        public string PlayerId { get; private set; }
        public long YearId { get; private set; }
        public string NameFirst { get; private set; }
        public string NameLast { get; private set; }
        public int Count { get; private set; } //# stints
        public string Teams { get; private set; } = ""; //list of all teams the player was on during this season
        public bool IsComplete { get; private set; } = false; //whether all stint records have complete date data entered
        private List<StintRecord> stintsApproved = new List<StintRecord>(); //for records pulled from database, or validated & saved to database
        public List<StintRecord> StintsEditable = new List<StintRecord>(); //for user-editable records, subject to validation before being saved

        //*****

        //Constructor with season information available; will fill in start & end of season on first/last stints & check if records validate
        internal PersonStint(string playerId, long yearId, DateTime? seasonStart = null, DateTime? seasonEnd = null, int seasonDuration = 0) {
            PlayerId = playerId;
            YearId = yearId;
            (NameFirst, NameLast) = Queries.PlayerName(PlayerId);
            stintsApproved = Queries.GetPlayerStints(YearId, PlayerId);

            //if first and last stint record in a set with 2+ stints don't have dates (ie, they were fresh records), add the season start/stop dates to them
            if (stintsApproved.Count > 1 && seasonStart != null && seasonEnd != null) {
                if (stintsApproved[0].StintStart == null) {
                    stintsApproved[0].StintStart = seasonStart;
                }
                if (stintsApproved[stintsApproved.Count - 1].StintEnd == null) {
                    stintsApproved[stintsApproved.Count - 1].StintEnd = seasonEnd;
                }
            }
            ApprovedToEditableStints(); //Copy approved records from database to editable stint list for user changes
            Count = stintsApproved.Count;
            FillTeams();

            if (seasonStart != null && seasonEnd != null) {
                if (Validate((DateTime)seasonStart, (DateTime)seasonEnd)) { //if record as pulled form db passes validation, mark player as complete
                    IsComplete = true;
                }
            }
        }

        //constructor with premade List<StintRecord> (to avoid ugly GetPlayerStints query if we can get stints more easily elsewhere)
        //this is used when grabbing players with only one stint, since that can be drawn from the Appearances table without having
        //to resort to unioning results from the batting and fielding tables to be sure we're getting all stints.
        //Lahman's database really should've had a Stints table, or the Appearances table should've differentiated between stints for the same team. :<
        //Since the list is premade, this constructor won't do any season start/stop calcs or date validations.
        //Client will have to enter dates & send season info to trigger the validation checking before saving to database.
        internal PersonStint(string playerId, long yearId, List<StintRecord> list) {
            PlayerId = playerId;
            YearId = yearId;
            (NameFirst, NameLast) = Queries.PlayerName(PlayerId);
            stintsApproved = list;
            ApprovedToEditableStints();
            Count = stintsApproved.Count;
            FillTeams();
        }

        //Return a copy of the approved stints list
        public List<StintRecord> GetStints() {
            List<StintRecord> stints  = new List<StintRecord>();
            foreach (StintRecord record in stintsApproved) {
                stints.Add(record.Copy());
            }
            return stints;
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
            StintsEditable = new List<StintRecord>();
            foreach (StintRecord record in stintsApproved) {
                StintsEditable.Add(record.Copy());
            }
        }

        //validate stints only
        internal bool Validate(DateTime seasonStart, DateTime seasonEnd) {
            int numberPrimaryStints = 0;

            for (int i = 0; i < StintsEditable.Count; i++) {

                if (StintsEditable[i].StintStart == null || StintsEditable[i].StintEnd == null) {
                    return false; //fail if any dates have null values
                }
                if (StintsEditable[i].StintStart >= StintsEditable[i].StintEnd) {
                    return false; //fail if the stint's start date is on/after the stint's end date
                }
                //check start date
                if (i == 0) { //first record in set fails if it starts before the season starts
                    if (StintsEditable[i].StintStart < seasonStart) {
                        return false;
                    }
                }
                else { //all others fails they start before the previous stint ends
                    if (StintsEditable[i].StintStart < StintsEditable[i - 1].StintEnd) {
                        return false;
                    }
                }

                //check end date
                if (i == StintsEditable.Count - 1) { //last record in set fails if it ends after the season ends
                    if (StintsEditable[i].StintEnd > seasonEnd) {
                        return false;
                    }
                }
                else { //all others fails if they end after the next stint starts
                    if (StintsEditable[i].StintEnd > StintsEditable[i + 1].StintEnd) {
                        return false;
                    }
                }
                if (StintsEditable[i].PrimaryStint) { //if this stint is marked as primary, increment primary counter
                    numberPrimaryStints++;
                    if (StintsEditable[i].IgnoreStint) { //fail if a primary stint is also marked as an ignored stint
                        return false;
                    }
                }
            } //end for loop validating all stints
            if (numberPrimaryStints > 1) { //fail if more than one stint is marked as a primary stint
                return false;
            }
            return true; //pass validation
        }

        //Validate editable stints & save to approved stints if passed
        internal (bool isValid, int recordsUpdated) ValidateSave(DateTime seasonStart, DateTime seasonEnd, int seasonDuration) {
            if (Validate(seasonStart, seasonEnd)) {
                //new Approved Stints list
                stintsApproved = new List<StintRecord>();

                //calculate derived values, copy records to Approved, and save back to database
                int changedRecords = 0;

                decimal ignoredStintX = 0; //cumulative StintX from ignored stints
                StintRecord primaryStint = null; //stint marked as "primary" - receives the StintX value from ignored stints

                foreach (StintRecord stint in StintsEditable) {
                    stint.CalcDuration();
                    stint.StintX = stint.StintDuration / (decimal)seasonDuration;
                    if (stint.IgnoreStint) { //if stint is ignored, add its StintX to the aggregator & set StintX to 0
                        ignoredStintX += stint.StintX;
                        stint.StintX = 0;
                    } else if (stint.PrimaryStint) { //if stint is primary, bookmark it
                        primaryStint = stint;
                    }
                }
                
                if (primaryStint != null) { //if we have a primary stint, add the ignored StintX values to it
                    primaryStint.StintX += ignoredStintX;
                }

                //finally, copy the records to the Approved Stint list & save updated records to database
                foreach (StintRecord stint in StintsEditable) {
                    stintsApproved.Add(stint.Copy());
                    changedRecords += Queries.UpdateStint(stint);
                }

                IsComplete = true;
                return (true, changedRecords);
            }
            else return (false, 0); //failed validation; do not attempt update, return false for failing to pass & 0 records changed
        }

        //Save player's stints without validating (only use with a fresh, empty record). Returns # of records updated
        //Will not calculate derived values due to lack of validation
        internal int SaveWithoutValidate() {
            //new Approved Stints list
            stintsApproved = new List<StintRecord>();
            
            int changedRecords = 0;
            foreach (StintRecord stint in StintsEditable) {
                stintsApproved.Add(stint.Copy());
                changedRecords += Queries.UpdateStint(stint);
            }
            return changedRecords;
        }

        //PlayerId is all we care about for comparing PersonStint records
        public int CompareTo(PersonStint other) {
            return this.PlayerId.CompareTo(other.PlayerId);
        }

        //delete this player's stints from database
        public int DeleteStints() {
            int deletedRecords = 0;
            foreach (StintRecord stint in stintsApproved) {
                deletedRecords += Queries.DeleteStint(stint);
            }
            return deletedRecords;
        }
    } // end PersonStint class


    //comparer for PersonStint; 
    public class PersonStintComparer : IComparer<PersonStint> {
        public int Compare(PersonStint x, PersonStint y) {
            return x.PlayerId.CompareTo(y.PlayerId);
        }
    }
}
