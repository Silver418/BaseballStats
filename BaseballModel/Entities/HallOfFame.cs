using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    [Table("HallOfFame")]
    public partial class HallOfFame
    {
        [Key]
        [Column("playerID", TypeName = "VARCHAR (10)")]
        public string PlayerId { get; set; } = null!;
        [Key]
        [Column("yearid", TypeName = "SMALLINT")]
        public long Yearid { get; set; }
        [Key]
        [Column("votedBy", TypeName = "VARCHAR (64)")]
        public string VotedBy { get; set; } = null!;
        [Column("ballots", TypeName = "SMALLINT")]
        public long? Ballots { get; set; }
        [Column("needed", TypeName = "SMALLINT")]
        public long? Needed { get; set; }
        [Column("votes", TypeName = "SMALLINT")]
        public long? Votes { get; set; }
        [Column("inducted", TypeName = "CHAR (1)")]
        public string? Inducted { get; set; }
        [Column("category", TypeName = "VARCHAR (20)")]
        public string? Category { get; set; }
        [Column("needed_note", TypeName = "VARCHAR (25)")]
        public string? NeededNote { get; set; }
    }
}
