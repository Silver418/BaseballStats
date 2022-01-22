using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    public partial class Salary
    {
        [Key]
        [Column("yearID", TypeName = "SMALLINT")]
        public long YearId { get; set; }
        [Key]
        [Column("teamID", TypeName = "VARCHAR (3)")]
        public string TeamId { get; set; } = null!;
        [Key]
        [Column("lgID", TypeName = "VARCHAR (2)")]
        public string LgId { get; set; } = null!;
        [Key]
        [Column("playerID", TypeName = "VARCHAR (9)")]
        public string PlayerId { get; set; } = null!;
        [Column("salary")]
        public double? Salary1 { get; set; }
    }
}
