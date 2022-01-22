using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    public partial class Manager
    {
        [Column("playerID", TypeName = "VARCHAR (10)")]
        public string? PlayerId { get; set; }
        [Key]
        [Column("yearID", TypeName = "SMALLINT")]
        public long YearId { get; set; }
        [Key]
        [Column("teamID", TypeName = "VARCHAR (3)")]
        public string TeamId { get; set; } = null!;
        [Column("lgID", TypeName = "VARCHAR (2)")]
        public string? LgId { get; set; }
        [Key]
        [Column("inseason", TypeName = "SMALLINT")]
        public long Inseason { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? G { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? W { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? L { get; set; }
        [Column("rank", TypeName = "SMALLINT")]
        public long? Rank { get; set; }
        [Column("plyrMgr", TypeName = "CHAR (1)")]
        public string? PlyrMgr { get; set; }
    }
}
