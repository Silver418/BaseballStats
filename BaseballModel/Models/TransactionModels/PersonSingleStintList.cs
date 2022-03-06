using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class PersonSingleStintList {
        public List<PersonSingleStintRecord> SingleStinters = new List<PersonSingleStintRecord>();
        private List<PersonStint> multiStinters;

        //event for progress update
        public event Action<int, int> ProgressChanged;

        private void OnProgressChanged(int progress, int max) {
            Action<int, int> eh = ProgressChanged;
            if (eh != null) {
                eh(progress + 1, max);
            }
        }

        //Constructor to be used with the Populate method for progress reporting after subscribing to the OnProgressChanged event
        public PersonSingleStintList() {
        }

        //populate method to be used after default constructor for progress reporting (by ProgressChanged event) & cancellation
        public void Populate(long yearId, List<PersonStint> ms, CancellationToken ct) {

            multiStinters = ms;

            var playerStintsQuery = Queries.GetSingleStintPlayers(yearId);

            try {
                int progress = 0;
                foreach (var record in playerStintsQuery) {
                    ct.ThrowIfCancellationRequested();
                    OnProgressChanged(progress, playerStintsQuery.Count);
                    List<StintRecord> stintList = new List<StintRecord>();
                    if (record.substint != null) {
                        stintList.Add(new StintRecord(record.substint));
                    }
                    else {
                        stintList.Add(new StintRecord(record.a.PlayerId, yearId, 1, record.a.TeamId));
                    }

                    bool isAlreadyEditable =
                        (from stint in ms
                         where stint.YearId == yearId
                         && record.a.PlayerId == stint.PlayerId
                         select stint).Any();

                    SingleStinters.Add(new PersonSingleStintRecord(record.a.PlayerId, yearId, stintList, isAlreadyEditable));
                    progress++;

                }

                SingleStinters.Sort(new PersonStintComparer());
            }
            catch (OperationCanceledException oce) {

            }

        } //end populate method

        public List<PersonSingleStintRecord> FilterPlayers(string teamId) {
            List<PersonSingleStintRecord> filtered =
                (from person in SingleStinters
                 where person.PlayedForTeam(teamId) == true
                 select person).ToList();
            return filtered;
        }

    } //end class
} //end namespace