using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    [Table("TeamsHalf")]
    public partial class TeamsHalf
    {
        [Key]
        [Column("yearID", TypeName = "SMALLINT")]
        public long YearId { get; set; }
        [Key]
        [Column("lgID", TypeName = "VARCHAR (2)")]
        public string LgId { get; set; } = null!;
        [Key]
        [Column("teamID", TypeName = "VARCHAR (3)")]
        public string TeamId { get; set; } = null!;
        [Key]
        [Column(TypeName = "CHAR (1)")]
        public string Half { get; set; } = null!;
        [Column("divID", TypeName = "CHAR (1)")]
        public string? DivId { get; set; }
        [Column(TypeName = "CHAR (1)")]
        public string? DivWin { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? Rank { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? G { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? W { get; set; }
        [Column(TypeName = "SMALLINT")]
        public long? L { get; set; }
    }
}
