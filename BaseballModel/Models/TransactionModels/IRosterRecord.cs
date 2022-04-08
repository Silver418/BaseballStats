using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public interface IRosterRecord {
        public string PlayerId { get; }
        public string NameFirst { get; }
        public string NameLast { get; }
        public string Pos { get; }
        public long? G { get; }
        public long? Gs { get; }
        public DateTime? StintStart { get; }
        public DateTime? StintEnd { get; }
        public int StintDuration { get; }
        public decimal StintX { get; }

    }
}
