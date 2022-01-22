using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseballModel.Entities
{
    [Keyless]
    [Table("CollegePlaying")]
    public partial class CollegePlaying
    {
        [Column("playerID", TypeName = "VARCHAR (9)")]
        public string PlayerId { get; set; } = null!;
        [Column("schoolID", TypeName = "VARCHAR (15)")]
        public string? SchoolId { get; set; }
        [Column("yearID", TypeName = "SMALLINT")]
        public long? YearId { get; set; }
    }
}
