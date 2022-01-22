using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    public partial class AwardsShareManager
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
        [Column("playerID", TypeName = "VARCHAR (10)")]
        public string PlayerId { get; set; } = null!;
        [Column("pointsWon", TypeName = "SMALLINT")]
        public long? PointsWon { get; set; }
        [Column("pointsMax", TypeName = "SMALLINT")]
        public long? PointsMax { get; set; }
        [Column("votesFirst", TypeName = "SMALLINT")]
        public long? VotesFirst { get; set; }
    }
}
