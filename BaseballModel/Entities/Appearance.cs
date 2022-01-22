using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    public partial class Appearance
    {
        [Key]
        [Column("yearID", TypeName = "SMALLINT")]
        public long YearId { get; set; }
        [Key]
        [Column("teamID", TypeName = "VARCHAR (3)")]
        public string TeamId { get; set; } = null!;
        [Column("lgID", TypeName = "VARCHAR (2)")]
        public string? LgId { get; set; }
        [Key]
        [Column("playerID", TypeName = "VARCHAR (9)")]
        public string PlayerId { get; set; } = null!;
        [Column("G_all", TypeName = "SMALLINT")]
        public long? GAll { get; set; }
        [Column("GS", TypeName = "SMALLINT")]
        public long? Gs { get; set; }
        [Column("G_batting", TypeName = "SMALLINT")]
        public long? GBatting { get; set; }
        [Column("G_defense", TypeName = "SMALLINT")]
        public long? GDefense { get; set; }
        [Column("G_p", TypeName = "SMALLINT")]
        public long? GP { get; set; }
        [Column("G_c", TypeName = "SMALLINT")]
        public long? GC { get; set; }
        [Column("G_1b", TypeName = "SMALLINT")]
        public long? G1b { get; set; }
        [Column("G_2b", TypeName = "SMALLINT")]
        public long? G2b { get; set; }
        [Column("G_3b", TypeName = "SMALLINT")]
        public long? G3b { get; set; }
        [Column("G_ss", TypeName = "SMALLINT")]
        public long? GSs { get; set; }
        [Column("G_lf", TypeName = "SMALLINT")]
        public long? GLf { get; set; }
        [Column("G_cf", TypeName = "SMALLINT")]
        public long? GCf { get; set; }
        [Column("G_rf", TypeName = "SMALLINT")]
        public long? GRf { get; set; }
        [Column("G_of", TypeName = "SMALLINT")]
        public long? GOf { get; set; }
        [Column("G_dh", TypeName = "SMALLINT")]
        public long? GDh { get; set; }
        [Column("G_ph", TypeName = "SMALLINT")]
        public long? GPh { get; set; }
        [Column("G_pr", TypeName = "SMALLINT")]
        public long? GPr { get; set; }
    }
}
