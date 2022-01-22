using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    [Table("FieldingPost")]
    public partial class FieldingPost
    {
        [Key]
        [Column("playerID", TypeName = "VARCHAR (9)")]
        public string PlayerId { get; set; } = null!;
        [Key]
        [Column("yearID", TypeName = "SMALLINT")]
        public long YearId { get; set; }
        [Column("teamID", TypeName = "VARCHAR (3)")]
        public string? TeamId { get; set; }
        [Column("lgID", TypeName = "VARCHAR (2)")]
        public string? LgId { get; set; }
        [Key]
        [Column("round", TypeName = "VARCHAR (10)")]
        public string Round { get; set; } = null!;
        [Key]
        [Column("POS", TypeName = "VARCHAR (2)")]
        public string Pos { get; set; } = null!;
        [Column(TypeName = "SMALLINT")]
        public long? G { get; set; }
        [Column("GS", TypeName = "SMALLINT")]
        public long? Gs { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? InnOuts { get; set; }
        [Column("PO", TypeName = "SMALLINT")]
        public long? Po { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? A { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? E { get; set; }
        [Column("DP", TypeName = "SMALLINT")]
        public long? Dp { get; set; }
        [Column("TP", TypeName = "SMALLINT")]
        public long? Tp { get; set; }
        [Column("PB", TypeName = "SMALLINT")]
        public long? Pb { get; set; }
        [Column("SB", TypeName = "SMALLINT")]
        public long? Sb { get; set; }
        [Column("CS", TypeName = "SMALLINT")]
        public long? Cs { get; set; }
    }
}
