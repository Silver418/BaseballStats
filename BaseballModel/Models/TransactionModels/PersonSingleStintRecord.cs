using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class PersonSingleStintRecord : PersonStint {
        public bool IsAlreadyEditable { get; set; }
        internal PersonSingleStintRecord(string playerId, long yearId, List<StintRecord> list, bool isAlreadyEditable)
            : base(playerId, yearId, list) {
            IsAlreadyEditable = isAlreadyEditable;
        }
    }
}
