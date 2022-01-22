using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    [Table("ManagersHalf")]
    public partial class ManagersHalf
    {
        [Key]
        [Column("playerID", TypeName = "VARCHAR (10)")]
        public string PlayerId { get; set; } = null!;
        [Key]
        [Column("yearID", TypeName = "SMALLINT")]
        public long YearId { get; set; }
        [Key]
        [Column("teamID", TypeName = "VARCHAR (3)")]
        public string TeamId { get; set; } = null!;
        [Column("lgID", TypeName = "VARCHAR (2)")]
        public string? LgId { get; set; }
        [Column("inseason", TypeName = "SMALLINT")]
        public long? Inseason { get; set; }
        [Key]
        [Column("half", TypeName = "SMALLINT")]
        public long Half { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? G { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? W { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? L { get; set; }
        [Column("rank", TypeName = "SMALLINT")]
        public long? Rank { get; set; }
    }
}
