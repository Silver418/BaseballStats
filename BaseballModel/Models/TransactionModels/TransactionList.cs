using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class TransactionList {
        private List<TransactionRecord> transactions = new List<TransactionRecord>();

        public TransactionList(SeasonPersonStint sps) {
            foreach (PersonStint player in sps.GetPlayers()) {
                if (player.IsComplete) {    //don't want incomplete records
                                            //may assume from here that StintStart & StintEnd are filled for all this player's stints
                    foreach (StintRecord stint in player.GetStints()) {
                        if (!stint.IgnoreStint) {
                            DateTime stintStart = (DateTime)stint.StintStart;
                            DateTime stintEnd = (DateTime)stint.StintEnd;
                            
                            //copy stint's start date & team to transactions
                            if (stintStart.Date != sps.Season.SeasonStart.Date) { //do not want stints beginning on season's first day
                                //check for matching record in transactions list
                                TransactionRecord? matching = (from record in transactions
                                                               where record.PlayerId == stint.PlayerId
                                                               && record.TransactionDate.Date == stintStart.Date
                                                               select record).FirstOrDefault();
                                //if match, copy team player is joining
                                if (matching != null) {
                                    matching.JoinTeam = stint.TeamName;
                                }
                                //if no match, create new record & add to transactions
                                else {
                                    TransactionRecord record = new TransactionRecord(player.PlayerId, player.NameFirst, player.NameLast, stintStart);
                                    record.JoinTeam = stint.TeamName;
                                    transactions.Add(record);
                                }
                            }

                            //copy stint's end date & team to transactions
                            if (stintEnd.Date != sps.Season.SeasonEnd.Date) { //do not want stints ending on season's last day
                                //check for matching record in transactions list
                                TransactionRecord? matching = (from record in transactions
                                                               where record.PlayerId == stint.PlayerId
                                                               && record.TransactionDate.Date == stintEnd.Date
                                                               select record).FirstOrDefault();
                                //if match, copy team player is leaving
                                if (matching != null) {
                                    matching.LeaveTeam = stint.TeamName;
                                }
                                //if no match, create new record & add to transactions
                                else {
                                    TransactionRecord record = new(player.PlayerId, player.NameFirst, player.NameLast, stintEnd);
                                    record.LeaveTeam = stint.TeamName;
                                    transactions.Add(record);
                                }
                            }
                        }

                    }//end foreach stint
                } //end if player's stints IsComplete
            } //end foreach player

            transactions = transactions.OrderBy(x => x.TransactionDate).ThenBy(x => x.PlayerId).ToList();
        } //end constructor

        public List<TransactionRecord> GetTransactions() => transactions;
    }
}
