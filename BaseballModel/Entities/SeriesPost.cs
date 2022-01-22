using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    [Table("SeriesPost")]
    public partial class SeriesPost
    {
        [Key]
        [Column("yearID", TypeName = "SMALLINT")]
        public long YearId { get; set; }
        [Key]
        [Column("round", TypeName = "VARCHAR (5)")]
        public string Round { get; set; } = null!;
        [Column("teamIDwinner", TypeName = "VARCHAR (3)")]
        public string? TeamIdwinner { get; set; }
        [Column("lgIDwinner", TypeName = "VARCHAR (2)")]
        public string? LgIdwinner { get; set; }
        [Column("teamIDloser", TypeName = "VARCHAR (3)")]
        public string? TeamIdloser { get; set; }
        [Column("lgIDloser", TypeName = "VARCHAR (2)")]
        public string? LgIdloser { get; set; }
        [Column("wins", TypeName = "SMALLINT")]
        public long? Wins { get; set; }
        [Column("losses", TypeName = "SMALLINT")]
        public long? Losses { get; set; }
        [Column("ties", TypeName = "SMALLINT")]
        public long? Ties { get; set; }
    }
}
