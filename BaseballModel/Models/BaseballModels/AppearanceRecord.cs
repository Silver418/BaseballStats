using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class AppearanceRecord {
        public long YearId { get; private set; }
        public string TeamId { get; private set; } = null!;
        public string LgId { get; private set; } = "";
        public string PlayerId { get; private set; } = null!;
        public long? GAll { get; private set; } //games in all positions
        public long? Gs { get; private set; } //games started
        public long? GBatting { get; private set; } //games batting
        public long? GDefense { get; private set; } //games defense
        public long? GP { get; private set; } //games as pitcher
        public long? GC { get; private set; } //games as catcher
        public long? G1b { get; private set; } //games at first base
        public long? G2b { get; private set; } //games at second base
        public long? G3b { get; private set; } //games at third base
        public long? GSs { get; private set; } //games as short stop
        public long? GLf { get; private set; } //games as left fielder
        public long? GCf { get; private set; } //games as center fielder
        public long? GRf { get; private set; } //games as right fielder
        public long? GOf { get; private set; } //games as outfielder
        public long? GDh { get; private set; } //games as designated hitter
        public long? GPh { get; private set; } //games as pinch hitter
        public long? GPr { get; private set; } //games as pinch runner

        public AppearanceRecord(Appearance appearance) {
            YearId = appearance.YearId;
            TeamId = appearance.TeamId;
            PlayerId = appearance.PlayerId;
            LgId = appearance.LgId ?? "";
            GAll = appearance.GAll;
            Gs = appearance.Gs;
            GBatting = appearance.GBatting;
            GDefense = appearance.GDefense;
            GP = appearance.GP;
            GC = appearance.GC;
            G1b = appearance.G1b;
            G2b = appearance.G2b;
            G3b = appearance.G3b;
            GSs = appearance.GSs;
            GLf = appearance.GLf;
            GCf = appearance.GCf;
            GRf = appearance.GRf;
            GOf = appearance.GOf;
            GDh = appearance.GDh;
            GPh = appearance.GPh;
            GPr = appearance.GPr;
        }
    }
}
