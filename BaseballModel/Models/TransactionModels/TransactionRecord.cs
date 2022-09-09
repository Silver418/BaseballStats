using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class TransactionRecord {
        public string PlayerId { get; private set; }
        public string NameFirst { get; private set; }
        public string NameLast { get; private set; }
        public DateTime TransactionDate { get; private set; }
        public string LeaveTeam { get; internal set; } = "";  //team the player left on this date. May be blank.
        public string JoinTeam { get; internal set; } = "";   //team the player joins on this date. May be blank.

        public TransactionRecord(string playerId, string nameFirst, string nameLast, DateTime transactionDate) {
            PlayerId = playerId;
            NameFirst = nameFirst;
            NameLast = nameLast;
            TransactionDate = transactionDate;
        }
    }
}
