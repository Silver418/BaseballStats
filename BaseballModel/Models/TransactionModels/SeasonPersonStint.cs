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

        //get editable list of stints for a given player
        public List<StintRecord>? GetPlayerStints(string playerId) {
            return (from player in personStintList
                    where player.PlayerId == playerId
                    select player.stintsEditable).FirstOrDefault();
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
    }
}