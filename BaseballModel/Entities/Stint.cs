using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    public partial class Stint
    {
        [Key]
        [Column("playerID", TypeName = "VARCHAR (9)")]
        public string PlayerId { get; set; } = null!;
        [Key]
        [Column("yearID", TypeName = "SMALLINT")]
        public long YearId { get; set; }
        [Key]
        [Column("stint", TypeName = "SMALLINT")]
        public long Stint1 { get; set; }
        [Column("stintStart", TypeName = "VARCHAR (10)")]
        public string? StintStart { get; set; }
        [Column("stintEnd", TypeName = "VARCHAR (10)")]
        public string? StintEnd { get; set; }
    }
}
