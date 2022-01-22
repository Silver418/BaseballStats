using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    [Index(nameof(DivId), Name = "idx_divID")]
    [Index(nameof(FranchId), Name = "idx_franchID")]
    public partial class Team
    {
        [Key]
        [Column("yearID", TypeName = "SMALLINT")]
        public long YearId { get; set; }
        [Key]
        [Column("lgID", TypeName = "VARCHAR (2)")]
        public string LgId { get; set; } = null!;
        [Key]
        [Column("teamID", TypeName = "VARCHAR (3)")]
        public string TeamId { get; set; } = null!;
        [Column("franchID", TypeName = "VARCHAR (3)")]
        public string? FranchId { get; set; }
        [Column("divID", TypeName = "CHAR (1)")]
        public string? DivId { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? Rank { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? G { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? Ghome { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? W { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? L { get; set; }
        [Column(TypeName = "CHAR (1)")]
        public string? DivWin { get; set; }
        [Column("WCWin", TypeName = "CHAR (1)")]
        public string? Wcwin { get; set; }
        [Column(TypeName = "CHAR (1)")]
        public string? LgWin { get; set; }
        [Column("WSWin", TypeName = "CHAR (1)")]
        public string? Wswin { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? R { get; set; }
        [Column("AB", TypeName = "SMALLINT")]
        public long? Ab { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? H { get; set; }
        [Column("2B", TypeName = "SMALLINT")]
        public long? _2b { get; set; }
        [Column("3B", TypeName = "SMALLINT")]
        public long? _3b { get; set; }
        [Column("HR", TypeName = "SMALLINT")]
        public long? Hr { get; set; }
        [Column("BB", TypeName = "SMALLINT")]
        public long? Bb { get; set; }
        [Column("SO", TypeName = "SMALLINT")]
        public long? So { get; set; }
        [Column("SB", TypeName = "SMALLINT")]
        public long? Sb { get; set; }
        [Column("CS", TypeName = "SMALLINT")]
        public long? Cs { get; set; }
        [Column("HBP", TypeName = "SMALLINT")]
        public long? Hbp { get; set; }
        [Column("SF", TypeName = "SMALLINT")]
        public long? Sf { get; set; }
        [Column("RA", TypeName = "SMALLINT")]
        public long? Ra { get; set; }
        [Column("ER", TypeName = "SMALLINT")]
        public long? Er { get; set; }
        [Column("ERA")]
        public double? Era { get; set; }
        [Column("CG", TypeName = "SMALLINT")]
        public long? Cg { get; set; }
        [Column("SHO", TypeName = "SMALLINT")]
        public long? Sho { get; set; }
        [Column("SV", TypeName = "SMALLINT")]
        public long? Sv { get; set; }
        [Column("IPouts")]
        public long? Ipouts { get; set; }
        [Column("HA", TypeName = "SMALLINT")]
        public long? Ha { get; set; }
        [Column("HRA", TypeName = "SMALLINT")]
        public long? Hra { get; set; }
        [Column("BBA", TypeName = "SMALLINT")]
        public long? Bba { get; set; }
        [Column("SOA", TypeName = "SMALLINT")]
        public long? Soa { get; set; }
        public long? E { get; set; }
        [Column("DP")]
        public long? Dp { get; set; }
        [Column("FP")]
        public double? Fp { get; set; }
        [Column("name", TypeName = "VARCHAR (50)")]
        public string? Name { get; set; }
        [Column("park", TypeName = "VARCHAR (255)")]
        public string? Park { get; set; }
        [Column("attendance")]
        public long? Attendance { get; set; }
        [Column("BPF")]
        public long? Bpf { get; set; }
        [Column("PPF")]
        public long? Ppf { get; set; }
        [Column("teamIDBR", TypeName = "VARCHAR (3)")]
        public string? TeamIdbr { get; set; }
        [Column("teamIDlahman45", TypeName = "VARCHAR (3)")]
        public string? TeamIdlahman45 { get; set; }
        [Column("teamIDretro", TypeName = "VARCHAR (3)")]
        public string? TeamIdretro { get; set; }
    }
}
