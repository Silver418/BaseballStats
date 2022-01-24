using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    public partial class SeasonDate
    {
        [Key]
        [Column("yearID", TypeName = "SMALLINT")]
        public long YearId { get; set; }
        [Column("seasonStart", TypeName = "VARCHAR (10)")]
        public string? SeasonStart { get; set; }
        [Column("seasonEnd", TypeName = "VARCHAR (10)")]
        public string? SeasonEnd { get; set; }
    }
}
