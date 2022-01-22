using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    [Table("Batting")]
    public partial class Batting
    {
        [Key]
        [Column("playerID", TypeName = "VARCHAR (9)")]
        public string PlayerId { get; set; } = null!;
        [Key]
        [Column("yearID", TypeName = "SMALLINT")]
        public long YearId { get; set; }
        [Key]
        [Column("stint", TypeName = "SMALLINT")]
        public long Stint { get; set; }
        [Column("teamID", TypeName = "VARCHAR (3)")]
        public string? TeamId { get; set; }
        [Column("lgID", TypeName = "VARCHAR (2)")]
        public string? LgId { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? G { get; set; }
        [Column("AB", TypeName = "SMALLINT")]
        public long? Ab { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? R { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? H { get; set; }
        [Column("2B", TypeName = "SMALLINT")]
        public long? _2b { get; set; }
        [Column("3B", TypeName = "SMALLINT")]
        public long? _3b { get; set; }
        [Column("HR", TypeName = "SMALLINT")]
        public long? Hr { get; set; }
        [Column("RBI", TypeName = "SMALLINT")]
        public long? Rbi { get; set; }
        [Column("SB", TypeName = "SMALLINT")]
        public long? Sb { get; set; }
        [Column("CS", TypeName = "SMALLINT")]
        public long? Cs { get; set; }
        [Column("BB", TypeName = "SMALLINT")]
        public long? Bb { get; set; }
        [Column("SO", TypeName = "SMALLINT")]
        public long? So { get; set; }
        [Column("IBB", TypeName = "SMALLINT")]
        public long? Ibb { get; set; }
        [Column("HBP", TypeName = "SMALLINT")]
        public long? Hbp { get; set; }
        [Column("SH", TypeName = "SMALLINT")]
        public long? Sh { get; set; }
        [Column("SF", TypeName = "SMALLINT")]
        public long? Sf { get; set; }
        [Column("GIDP", TypeName = "SMALLINT")]
        public long? Gidp { get; set; }
    }
}
