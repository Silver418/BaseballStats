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
        [Column("stintID", TypeName = "SMALLINT")]
        public long StintId { get; set; }
        [Column("teamID", TypeName = "VARCHAR (3)")]
        public string? TeamId { get; set; }
        [Column("stintStart", TypeName = "VARCHAR (10)")]
        public string? StintStart { get; set; }
        [Column("stintEnd", TypeName = "VARCHAR (10)")]
        public string? StintEnd { get; set; }
        [Column("stintX", TypeName = "NUMERIC")]
        public decimal? StintX { get; set; }
        [Column("ignoreStint", TypeName = "BOOLEAN")]
        public bool IgnoreStint { get; set; } = false;
        [Column("primaryStint", TypeName = "BOOLEAN")]
        public bool PrimaryStint { get; set; } = false;
    }
}
