﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    public partial class AwardsPlayer
    {
        [Key]
        [Column("playerID", TypeName = "VARCHAR (9)")]
        public string PlayerId { get; set; } = null!;
        [Key]
        [Column("awardID", TypeName = "VARCHAR (255)")]
        public string AwardId { get; set; } = null!;
        [Key]
        [Column("yearID", TypeName = "SMALLINT")]
        public long YearId { get; set; }
        [Key]
        [Column("lgID", TypeName = "VARCHAR (2)")]
        public string LgId { get; set; } = null!;
        [Column("tie", TypeName = "CHAR (1)")]
        public string? Tie { get; set; }
        [Key]
        [Column("notes", TypeName = "VARCHAR (100)")]
        public string? Notes { get; set; }
    }
}
