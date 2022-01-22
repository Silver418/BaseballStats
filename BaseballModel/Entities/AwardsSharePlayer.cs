using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    public partial class AwardsSharePlayer
    {
        [Key]
        [Column("awardID", TypeName = "VARCHAR (25)")]
        public string AwardId { get; set; } = null!;
        [Key]
        [Column("yearID", TypeName = "SMALLINT")]
        public long YearId { get; set; }
        [Key]
        [Column("lgID", TypeName = "VARCHAR (2)")]
        public string LgId { get; set; } = null!;
        [Key]
        [Column("playerID", TypeName = "VARCHAR (9)")]
        public string PlayerId { get; set; } = null!;
        [Column("pointsWon")]
        public double? PointsWon { get; set; }
        [Column("pointsMax", TypeName = "SMALLINT")]
        public long? PointsMax { get; set; }
        [Column("votesFirst")]
        public double? VotesFirst { get; set; }
    }
}
