using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class FieldingOfRecord {
        public string PlayerId { get; private set; }
        public long YearId { get; private set; }
        public long Stint { get; private set; }
        public long Glf { get; private set; } = 0; //games played in left field
        public long Gcf { get; private set; } = 0; //games playedin center field
        public long Grf { get; private set; } = 0; //games played in right field

        public FieldingOfRecord(FieldingOf fieldingOf) {
            PlayerId = fieldingOf.PlayerId;
            YearId = fieldingOf.YearId;
            Stint = fieldingOf.Stint;
            
            if (fieldingOf.Glf != null) {
                Glf = (long)fieldingOf.Glf;
            }
            if (fieldingOf.Gcf != null) {
                Gcf = (long)fieldingOf.Gcf;
            }
            if (fieldingOf.Grf != null) {
                Grf = (long)fieldingOf.Grf;
            }
        }
    }
}
