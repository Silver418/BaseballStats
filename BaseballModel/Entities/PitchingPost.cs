using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    [Table("PitchingPost")]
    public partial class PitchingPost
    {
        [Key]
        [Column("playerID", TypeName = "VARCHAR (9)")]
        public string PlayerId { get; set; } = null!;
        [Key]
        [Column("yearID", TypeName = "SMALLINT")]
        public long YearId { get; set; }
        [Key]
        [Column("round", TypeName = "VARCHAR (10)")]
        public string Round { get; set; } = null!;
        [Column("teamID", TypeName = "VARCHAR (3)")]
        public string? TeamId { get; set; }
        [Column("lgID", TypeName = "VARCHAR (2)")]
        public string? LgId { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? W { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? L { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? G { get; set; }
        [Column("GS", TypeName = "SMALLINT")]
        public long? Gs { get; set; }
        [Column("CG", TypeName = "SMALLINT")]
        public long? Cg { get; set; }
        [Column("SHO", TypeName = "SMALLINT")]
        public long? Sho { get; set; }
        [Column("SV", TypeName = "SMALLINT")]
        public long? Sv { get; set; }
        [Column("IPouts")]
        public long? Ipouts { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? H { get; set; }
        [Column("ER", TypeName = "SMALLINT")]
        public long? Er { get; set; }
        [Column("HR", TypeName = "SMALLINT")]
        public long? Hr { get; set; }
        [Column("BB", TypeName = "SMALLINT")]
        public long? Bb { get; set; }
        [Column("SO", TypeName = "SMALLINT")]
        public long? So { get; set; }
        [Column("BAOpp")]
        public double? Baopp { get; set; }
        [Column("ERA")]
        public double? Era { get; set; }
        [Column("IBB", TypeName = "SMALLINT")]
        public long? Ibb { get; set; }
        [Column("WP", TypeName = "SMALLINT")]
        public long? Wp { get; set; }
        [Column("HBP", TypeName = "SMALLINT")]
        public long? Hbp { get; set; }
        [Column("BK", TypeName = "SMALLINT")]
        public long? Bk { get; set; }
        [Column("BFP", TypeName = "SMALLINT")]
        public long? Bfp { get; set; }
        [Column("GF", TypeName = "SMALLINT")]
        public long? Gf { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? R { get; set; }
        [Column("SH", TypeName = "SMALLINT")]
        public long? Sh { get; set; }
        [Column("SF", TypeName = "SMALLINT")]
        public long? Sf { get; set; }
        [Column("GIDP", TypeName = "SMALLINT")]
        public long? Gidp { get; set; }
    }
}
