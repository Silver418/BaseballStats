using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class SeasonPersonStint {
        public SeasonDateRecord Season { get; private set; }
        private List<PersonStint> personStintList;

        public SeasonPersonStint(SeasonDateRecord season) {
            Season = season;
            personStintList = Queries.GetPlayersWithStints(Season.YearId, Season.SeasonStart, Season.SeasonEnd, Season.SeasonDuration);
        }

        //get list of players
        public List<PersonStint> GetPlayers() {
            return personStintList;
        }

        public List<PersonStint> FilterPlayers(bool incompleteOnly = false, string teamId = "") {
            List<PersonStint> filtered = new List<PersonStint>();
            foreach (PersonStint person in personStintList) {
                filtered.Add(person);
            } //filtered holds direct handles to the same PersonStint objects as the original, but only a selected subset of them

            if (incompleteOnly) {
                filtered = (from r in filtered
                           where r.IsComplete == false
                           select r).ToList();
            }
            if (!teamId.Equals("")) {
                filtered = (from r in filtered
                            where r.PlayedForTeam(teamId) == true
                            select r).ToList();
            }
            return filtered;
        }

        //get editable list of stints for a given player
        public List<StintRecord>? GetPlayerStints(string playerId) {
            return (from player in personStintList
                    where player.PlayerId == playerId
                    select player.StintsEditable).FirstOrDefault();
        }

        //get sorted dictionary of teams in this year
        public SortedDictionary<string, string> GetTeams() {
            return Queries.GetTeams(Season.YearId);
        }

        //revert a given player's stint records
        public void RevertStintsPlayer(string playerId) {
            PersonStint? player = (from p in personStintList
                                   where p.PlayerId == playerId
                                   select p).FirstOrDefault();
            if (player != null) {
                player.ApprovedToEditableStints();
            }
        }

        //validate a given player's stint records & save
        public (bool isValid, int recordsUpdated) ValidateSavePlayer(string playerId) {
            PersonStint? player = (from p in personStintList
             where p.PlayerId == playerId
             select p).FirstOrDefault();
            if (player != null) {
                return player.ValidateSave(Season.SeasonStart, Season.SeasonEnd, Season.SeasonDuration);
            }
            else {
                return (false, 0);
            }
        }

        //add a PersonStint record to the list & save record; assumes list is sorted by PlayerID
        public int AddPersonStint(PersonStint personStint) {
            //list is empty OR new item is after end of list; add item
            if (personStintList.Count == 0 || personStintList[personStintList.Count - 1].CompareTo(personStint) <= 0) {
                personStintList.Add(personStint);
                return personStint.SaveWithoutValidate();
            }
            //new item is before start of list; add to start
            if (personStintList[0].CompareTo(personStint) >= 0) {
                personStintList.Insert(0, personStint);
                return personStint.SaveWithoutValidate();
            }
            //new item is somewhere in the middle of the list
            int index = personStintList.BinarySearch(personStint, new PersonStintComparer());
            if (index < 0) { //BinarySearch, if item is not found, returns a negative bitwise complement of the next largest item (or Count)
                index = ~index; //undoing the bitwise complement to get the index we want to insert at
                personStintList.Insert(index, personStint);
                return personStint.SaveWithoutValidate();
            }
            return 0; //should only reach here if a record with the same PlayerId already exists. Item will not be added.
        }
    }
}